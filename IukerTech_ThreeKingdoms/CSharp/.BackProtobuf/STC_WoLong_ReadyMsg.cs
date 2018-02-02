using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_ReadyMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long tableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int posId { get; set; }

    }
}
