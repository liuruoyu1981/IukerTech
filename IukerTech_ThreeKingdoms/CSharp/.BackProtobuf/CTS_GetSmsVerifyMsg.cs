using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_GetSmsVerifyMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public string phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public string smsName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string sign { get; set; }

    }
}
