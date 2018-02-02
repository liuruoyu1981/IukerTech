using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_WoLong_TableSettleMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long tableId { get; set; }

    }
}
