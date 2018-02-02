using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_Gdy_SettleMsg
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
        public int winPosId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public bool isSpring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int boutNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public SettleItem settleLst { get; set; }

    }
}
