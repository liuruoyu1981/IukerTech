using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_ErrorMsgMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int errId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public string errMsg { get; set; }

    }
}
