using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_R_ShareMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long shareId { get; set; }

    }
}
