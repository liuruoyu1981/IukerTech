using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class EndRankMsg
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
        public int totalScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int maxBomb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int bombCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int isHost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public long winPlayer { get; set; }

    }
}
