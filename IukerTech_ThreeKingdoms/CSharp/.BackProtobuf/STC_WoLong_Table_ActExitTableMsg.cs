using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_Table_ActExitTableMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long userId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public long tableId { get; set; }

    }
}
