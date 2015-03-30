using System;
using System.Text.RegularExpressions;

namespace Eaglesong
{
    public class UserInfo
    {
        public const int MaxPlayerNameLength = 32;
        public const int SignedGuidLen = 32 + 1; // is 33 long
        public static readonly Regex SteamIdPattern = new Regex("STEAM_(\\d+):(\\d+):(\\d+)");
        public const long SteamIdIdentifier = 0x0110000100000000;

        public long XUID { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string GUID { get; set; }
        public uint FriendsId { get; set; }
        public string FriendsName { get; set; }
        public long SteamId { get; set; }

        public static UserInfo ParseUserInfo(byte[] buf)
        {
            var info = new UserInfo();
            var pos = 0;
            
            info.XUID = BitConverter.ToInt64(buf, pos);
            pos += 8;

            info.Name = BitStream.ReadString(buf, pos);
            pos += UserInfo.MaxPlayerNameLength;

            info.UserId = BitConverter.ToInt32(buf, pos);
            pos += 4;

            info.GUID = BitStream.ReadString(buf, pos);
            pos += UserInfo.SignedGuidLen;

            info.FriendsId = BitConverter.ToUInt32(buf, pos);
            pos += 4;

            info.FriendsName = BitStream.ReadString(buf, pos);
            
            // https://developer.valvesoftware.com/wiki/SteamID
            MatchCollection matches = UserInfo.SteamIdPattern.Matches(info.GUID);
            if (matches.Count == 4)
            {
                long y = Int64.Parse(matches[2].Value);
                long z = Int64.Parse(matches[3].Value);
                info.SteamId = (z*2) + y + UserInfo.SteamIdIdentifier;
            }
            return info;
        }

    }
}