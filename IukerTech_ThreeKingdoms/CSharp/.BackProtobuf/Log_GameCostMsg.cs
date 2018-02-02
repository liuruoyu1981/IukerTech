using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class Log_GameCostMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long masterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public long joinUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public long onTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int gameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public long tableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int cost { get; set; }

    }
}
