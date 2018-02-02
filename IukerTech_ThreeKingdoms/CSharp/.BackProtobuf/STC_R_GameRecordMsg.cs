using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_R_GameRecordMsg
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
        public int handId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int gameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public long shareId { get; set; }

    }
}
