using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Extends the auto-generated protobuf classes
namespace dota2
{
    /// <summary>
    /// an interface to required classes to make it easier to parse their embedded data
    /// </summary>
    public interface BaseWithEmbedded
    {
        byte[] data { get; set; }
        object[] EmbeddedMessages { get; set; }
    }

    public partial class CDemoFullPacket : BaseWithEmbedded
    {
        public byte[] data
        {
            get
            {
                return this.packet.data;
            }
            set
            {
                this.packet.data = value;
            }
        }
        public object[] EmbeddedMessages
        {
            get
            {
                return this.packet.EmbeddedMessages;
            }
            set
            {
                this.packet.EmbeddedMessages = value;
            }
        }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            this.packet.OnDeserialized(context);
        }
    }

    public partial class CDemoSendTables : BaseWithEmbedded
    {
        public object[] EmbeddedMessages { get; set; }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            this.EmbeddedMessages = Eaglesong.DemParser.ParseEmbeddedMessages(this.data);
        }
    }

    public partial class CDemoPacket : BaseWithEmbedded
    {
        public object[] EmbeddedMessages { get; set; }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            this.EmbeddedMessages = Eaglesong.DemParser.ParseEmbeddedMessages(this.data);
        }
    }

    /// <summary>
    /// The signon packets are the same as normal packets - this is just a direct copy from the generated class
    /// </summary>
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoSignonPacket")]
    public partial class CDemoSignonPacket : BaseWithEmbedded, global::ProtoBuf.IExtensible
    {
        public CDemoSignonPacket() { }

        private int _sequence_in = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"sequence_in", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int sequence_in
        {
            get { return _sequence_in; }
            set { _sequence_in = value; }
        }
        private int _sequence_out_ack = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"sequence_out_ack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int sequence_out_ack
        {
            get { return _sequence_out_ack; }
            set { _sequence_out_ack = value; }
        }
        private byte[] _data = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get { return _data; }
            set { _data = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }



        public object[] EmbeddedMessages { get; set; }
        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            this.EmbeddedMessages = Eaglesong.DemParser.ParseEmbeddedMessages(this.data);
        }
    }
}
