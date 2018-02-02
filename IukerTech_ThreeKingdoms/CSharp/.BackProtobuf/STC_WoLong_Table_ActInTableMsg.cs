using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_Table_ActInTableMsg
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
        public SimplePlayer playerList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public TeoError error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public int sameAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public int lianAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public bool singleAward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public bool singleDouble { get; set; }

    }
}
