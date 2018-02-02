using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class EndPokerMsg
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
        public int poker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int bomb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int extraScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public string nickName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int win { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public int totalScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public int you { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public int otherPoker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public int baseScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        public BigBombMsg maxBomb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        public int supply { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        public int unique { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
        public int noAward { get; set; }

    }
}
