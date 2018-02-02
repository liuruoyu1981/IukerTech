using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_L_LotteryConfigMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public LotteryConfigItem list { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int lotteryNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int inviteProNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int inviteProTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int createTableProNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int createTableProTotal { get; set; }

    }
}
