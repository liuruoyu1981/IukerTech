using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class EconomyInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long userId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public long gold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int diamond { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int payCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int payTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public long lastPayTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int mobileCharge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public long inviteUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public int lotteryNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public int inviteNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public int createTableAndCostNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        public int tableGameNum { get; set; }

    }
}
