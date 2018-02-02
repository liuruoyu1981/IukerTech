using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_GetSmsVerifyMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public string returnCode { get; set; }

    }
}
