using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_R_ShareMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long tableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int handId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int gameId { get; set; }

    }
}
