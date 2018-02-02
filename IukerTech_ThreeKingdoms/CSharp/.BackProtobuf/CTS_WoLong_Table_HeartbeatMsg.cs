using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_WoLong_Table_HeartbeatMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long tableId { get; set; }

    }
}
