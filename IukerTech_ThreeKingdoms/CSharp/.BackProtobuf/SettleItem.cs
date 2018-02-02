using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class SettleItem
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int posId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int grade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int pubMultiple { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int priMultiple { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int surplusCards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int outCardNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int zhadanNum { get; set; }

    }
}
