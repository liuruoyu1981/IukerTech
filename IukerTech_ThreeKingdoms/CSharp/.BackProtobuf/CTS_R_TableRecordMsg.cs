using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_R_TableRecordMsg
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
        public int gameId { get; set; }

    }
}
