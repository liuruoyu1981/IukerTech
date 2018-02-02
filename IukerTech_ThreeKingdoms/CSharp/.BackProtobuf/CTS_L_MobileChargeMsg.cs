using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_L_MobileChargeMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public long mobile { get; set; }

    }
}
