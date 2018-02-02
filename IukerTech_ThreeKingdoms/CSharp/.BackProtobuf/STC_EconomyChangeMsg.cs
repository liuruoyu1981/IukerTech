using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_EconomyChangeMsg
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
        public EconomyInfo economy { get; set; }

    }
}
