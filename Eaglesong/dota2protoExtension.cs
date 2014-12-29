using System;

// Extends the auto-generated protobuf classes
// Adds an interface to required classes to make it easier to parse their embedded data
namespace dota2
{
    public interface BaseWithEmbedded
    {
        byte[] data { get; set; }
        object EmbeddedMessage { get; set; }
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
        public object EmbeddedMessage
        {
            get
            {
                return this.packet.EmbeddedMessage;
            }
            set
            {
                this.packet.EmbeddedMessage = value;
            }
        }
    }

    public partial class CDemoSendTables : BaseWithEmbedded
    {
        public object EmbeddedMessage { get; set; }
    }

    public partial class CDemoPacket : BaseWithEmbedded
    {
        public object EmbeddedMessage { get; set; }
    }
}
