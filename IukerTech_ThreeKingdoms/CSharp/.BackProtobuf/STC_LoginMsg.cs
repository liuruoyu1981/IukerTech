using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_LoginMsg
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
        public string session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string loginIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public SocialInfo socialInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public EconomyInfo economyInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public UserStatus userStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public string test { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public string account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public string password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public string gameServerIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        public string gameServerPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        public string chatPort { get; set; }

    }
}
