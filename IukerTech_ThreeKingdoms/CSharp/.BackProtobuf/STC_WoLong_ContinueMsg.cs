using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_ContinueMsg
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
        public long password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string tableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int handNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int postionNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int gameStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int actionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public int handId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public WoLongPlayerInfo playerList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public int priCards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public int operatePosId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        public int oerateBeCards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        public int bePosId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        public int sameAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
        public int lianAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(16)]
        public bool singleAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(17)]
        public bool singleDouble { get; set; }

    }
}
