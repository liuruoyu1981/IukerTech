using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_Pay_SucceedMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public string orderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int diamond { get; set; }

    }
}
