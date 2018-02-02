using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_PlatformLoginMsg
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
        public string comeFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string sessionid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string refreshToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int regChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public string os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public string IMEI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public string loginIp { get; set; }

    }
}
