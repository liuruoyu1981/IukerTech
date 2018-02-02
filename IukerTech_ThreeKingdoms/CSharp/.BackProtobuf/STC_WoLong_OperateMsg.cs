using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_OperateMsg
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
        public int posId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int actonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int cards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int awardScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int sameAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int continuousAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public int gatherScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public int gatherScoreosId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public int you { get; set; }

    }
}
