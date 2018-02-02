using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_WoLong_Table_CreateMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int gameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public long tableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string tableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int handTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int playerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int sameAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int lianAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public bool singleAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public bool singleDouble { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public int gps_x { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public int gps_y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        public string gps_address { get; set; }

    }
}
