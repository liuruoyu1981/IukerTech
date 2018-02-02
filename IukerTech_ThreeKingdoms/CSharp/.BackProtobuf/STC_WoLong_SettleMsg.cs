using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_SettleMsg
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
        public int snId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int handTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string startTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int bankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public EndPokerMsg info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public EndRankMsg rank { get; set; }

    }
}
