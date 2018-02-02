using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_UserInfoMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long userId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public string account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int regChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public string loginIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public SocialInfo socialInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public EconomyInfo economyInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public UserStatus userStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public string password { get; set; }

    }
}
