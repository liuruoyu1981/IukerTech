using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_EconomyChangeMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long userId { get; set; }

    }
}
