using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class WoLongPlayerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int posId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int cardNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int you { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int grade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public SimplePlayer player { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int awardScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int gatherScore { get; set; }

    }
}
