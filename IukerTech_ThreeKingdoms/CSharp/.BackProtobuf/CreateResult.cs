using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CreateResult
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long masterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public long tableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public long createTime { get; set; }

    }
}
