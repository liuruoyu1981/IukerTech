using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_StartMsg
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
        public int bankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int handId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int priCards { get; set; }

    }
}
