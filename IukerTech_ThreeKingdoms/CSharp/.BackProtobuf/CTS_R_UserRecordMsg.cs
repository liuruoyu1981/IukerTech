using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_R_UserRecordMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int pageNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int pageSize { get; set; }

    }
}
