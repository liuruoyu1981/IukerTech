using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_LoginMsg
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
        public string machineCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public string comeFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public string sessionid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int regChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public string os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public string IMEI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public string loginIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public SocialInfo socialInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        public string test { get; set; }

    }
}
