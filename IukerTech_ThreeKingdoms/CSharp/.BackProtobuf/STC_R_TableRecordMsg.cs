using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_R_TableRecordMsg
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
        public int gameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public long masterUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public RoundRecord roundList { get; set; }

    }
}
