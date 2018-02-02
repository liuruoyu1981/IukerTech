using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_WoLong_OperateMsg
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
        public int actonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int cards { get; set; }

    }
}
