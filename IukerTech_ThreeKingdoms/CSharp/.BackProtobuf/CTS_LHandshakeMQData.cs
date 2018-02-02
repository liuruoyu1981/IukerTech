using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_LHandshakeMQData
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int type { get; set; }

    }
}
