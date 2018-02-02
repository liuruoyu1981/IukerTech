using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_Table_HeartbeatMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long tableId { get; set; }

    }
}
