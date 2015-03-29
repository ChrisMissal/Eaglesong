namespace Eaglesong
{
    public class UserInfo
    {
        public const int MaxPlayerNameLength = 32;
        public const int SignedGuidLen = 32;

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
            var stream = new BitStream(buf);

            info.XUID = stream.ReadLong();
            info.Name = stream.ReadString(UserInfo.MaxPlayerNameLength);
            info.UserId = stream.ReadInt();
            info.GUID = stream.ReadString(UserInfo.SignedGuidLen+1);
            info.FriendsId = (uint)stream.ReadInt();
            info.FriendsName = stream.ReadString(UserInfo.MaxPlayerNameLength);

            return info;
        }
    }
}