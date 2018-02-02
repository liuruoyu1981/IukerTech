using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class WoLong_PlayerScore
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int awardScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int gatherScore { get; set; }

    }
}
