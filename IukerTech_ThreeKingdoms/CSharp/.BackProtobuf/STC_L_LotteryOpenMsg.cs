using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_L_LotteryOpenMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int resultId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public string resultMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int lotteryNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int inviteProNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int inviteProTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int createTableProNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public int createTableProTotal { get; set; }

    }
}
