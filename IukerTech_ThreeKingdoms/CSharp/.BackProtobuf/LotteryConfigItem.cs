using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class LotteryConfigItem
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int goodsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string goodsName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int goodsNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public string desc { get; set; }

    }
}
