using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Eaglesong
{
    public class DemParser
    {
        private const ulong COMPRESSED_KIND_MASK = 0x70;

        public static LinkedList<Object> Read(string fileName)
        {
            LinkedList<object> messages = new LinkedList<object>();

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] buf = new byte[8];
                fs.Read(buf, 0, 8);
                if (System.Text.Encoding.UTF8.GetString(buf) != "PBUFDEM\0")
                {
                    throw new InvalidDataException("Invalid Header");
                }

                buf = new byte[4];
                fs.Read(buf, 0, 4);
                if (BitConverter.IsLittleEndian != true) // the bit converter requires the bytes in the computer's endian-ness
                {
                    Array.Reverse(buf);
                }
                int summaryOffset = BitConverter.ToInt32(buf, 0);

                while (fs.Position < fs.Length)
                {
                    messages.AddLast(ParseMessage(fs));
                }
            }

            return messages;
        }

        private static Dictionary<ulong, Type> BaseTypeMap = new Dictionary<ulong, Type>
        {
            {0, typeof(dota2.CDemoStop)},
            {1, typeof(dota2.CDemoFileHeader)},
            {2, typeof(dota2.CDemoFileInfo)},
            {3, typeof(dota2.CDemoSyncTick)},
            {4, typeof(dota2.CDemoSendTables)},
            {5, typeof(dota2.CDemoClassInfo)},
            {6, typeof(dota2.CDemoStringTables)},
            {7, typeof(dota2.CDemoPacket)},
            {8, typeof(dota2.CDemoPacket)},
            {9, typeof(dota2.CDemoConsoleCmd)},
            {10, typeof(dota2.CDemoCustomData)},
            {11, typeof(dota2.CDemoCustomDataCallbacks)},
            {12, typeof(dota2.CDemoUserCmd)},
            {13, typeof(dota2.CDemoFullPacket)},
            {14, typeof(dota2.CDemoSaveGame)}
        };
        private static ulong[] BaseWithEmbedded = new ulong[]{
            4, 7, 8, 13
        };
        private static Dictionary<ulong, Type> EmbeddedTypeMap = new Dictionary<ulong, Type>
        {
            {4, typeof(dota2.CNETMsg_Tick)},
            {6, typeof(dota2.CNETMsg_SetConVar)},
            {7, typeof(dota2.SIGNONSTATE)},
            {8, typeof(dota2.CSVCMsg_ServerInfo)},
            {9, typeof(dota2.CSVCMsg_SendTable)},
            {10, typeof(dota2.CSVCMsg_ClassInfo)},
            {12, typeof(dota2.CSVCMsg_CreateStringTable)},
            {13, typeof(dota2.CSVCMsg_UpdateStringTable)},
            {14, typeof(dota2.CSVCMsg_VoiceInit)},
            {15, typeof(dota2.CSVCMsg_VoiceData)},
            {17, typeof(dota2.CSVCMsg_Sounds)},
            {18, typeof(dota2.CSVCMsg_SetView)},
            {23, typeof(dota2.CSVCMsg_UserMessage)},
            {24, typeof(dota2.EDotaEntityMessages)},
            {25, typeof(dota2.CSVCMsg_GameEvent)},
            {26, typeof(dota2.CSVCMsg_PacketEntities)},
            {27, typeof(dota2.CSVCMsg_TempEntities)},
            {30, typeof(dota2.CSVCMsg_GameEventList)}
        };

        /// <summary>
        /// Parses a base message and its embedded message (if required)
        /// </summary>
        /// <param name="fs"></param>
        /// <returns></returns>
        private static object ParseMessage(FileStream fs)
        {
            ulong kind = ReadVarInt(fs);
            ulong tick = ReadVarInt(fs);
            ulong size = ReadVarInt(fs);
            byte[] buf = new byte[size];
            fs.Read(buf, 0, (int)size);

            // decompress if needed
            bool isCompressed = (kind & COMPRESSED_KIND_MASK) != 0;
            if (isCompressed)
            {
                kind = kind - COMPRESSED_KIND_MASK;
                buf = Snappy.SnappyCodec.Uncompress(buf);
            }

            object message = ProtoBuf.Meta.RuntimeTypeModel.Default.Deserialize(new MemoryStream(buf), null, BaseTypeMap[kind]);

            if (Array.FindIndex(BaseWithEmbedded, v => v == kind) != -1)
            {
                dota2.BaseWithEmbedded msg = (dota2.BaseWithEmbedded)message;
                msg.EmbeddedMessage = ParseEmbeddedMessage(msg.data);
            }

            return message;
        }

        /// <summary>
        /// Parses the embedded message from within a base message
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static object ParseEmbeddedMessage(byte[] data)
        {
            MemoryStream fs = new MemoryStream(data);

            ulong kind = ReadVarInt(fs);
            ulong size = ReadVarInt(fs);
            byte[] buf = new byte[size];
            fs.Read(buf, 0, (int)size);

            return ProtoBuf.Meta.RuntimeTypeModel.Default.Deserialize(new MemoryStream(buf), null, EmbeddedTypeMap[kind]);
        }

        /// <summary>
        /// Reads in a VarInt
        /// </summary>
        /// <param name="fs"></param>
        /// <returns></returns>
        private static ulong ReadVarInt(Stream fs)
        {
            ulong result = 0;
            int shift = 0;

            int max = sizeof(long) * 8;
            while (shift < max)
            {
                byte b = (byte)fs.ReadByte();
                ulong temp = (ulong)(b & 0x7f);
                result |= temp << shift;

                if ((b & 0x80) != 0x80)
                {
                    return result;
                }

                shift += 7;
            }

            throw new InvalidDataException("Invalid VarInt.");
        }
    }
}
