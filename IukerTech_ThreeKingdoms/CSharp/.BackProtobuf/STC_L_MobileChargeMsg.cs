using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_L_MobileChargeMsg
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
        public int result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string resultMsg { get; set; }

    }
}
