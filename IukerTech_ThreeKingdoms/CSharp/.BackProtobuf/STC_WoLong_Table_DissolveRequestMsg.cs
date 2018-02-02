using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_Table_DissolveRequestMsg
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
        public long userId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string nickName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public TeoError error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int result { get; set; }

    }
}
