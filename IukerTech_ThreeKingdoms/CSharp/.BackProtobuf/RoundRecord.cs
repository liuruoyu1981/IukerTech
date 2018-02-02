using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class RoundRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int handId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public SettleResult result { get; set; }

    }
}
