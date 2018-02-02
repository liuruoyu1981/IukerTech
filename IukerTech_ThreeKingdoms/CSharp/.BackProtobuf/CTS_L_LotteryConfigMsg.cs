using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_L_LotteryConfigMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long userId { get; set; }

    }
}
