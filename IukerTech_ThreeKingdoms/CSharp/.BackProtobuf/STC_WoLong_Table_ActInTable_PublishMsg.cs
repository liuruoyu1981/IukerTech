using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_Table_ActInTable_PublishMsg
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
        public int posId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public SimplePlayer player { get; set; }

    }
}
