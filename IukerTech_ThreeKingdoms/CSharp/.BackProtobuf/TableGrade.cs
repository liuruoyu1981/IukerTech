using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class TableGrade
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
        public long date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public long masterUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public GameGrade result { get; set; }

    }
}
