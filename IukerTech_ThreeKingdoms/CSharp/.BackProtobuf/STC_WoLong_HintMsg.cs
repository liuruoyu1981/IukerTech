using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_HintMsg
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
        public CardGroup cardsList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int beCards { get; set; }

    }
}
