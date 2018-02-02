using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_Table_DissolveVoteResultMsg
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
        public int result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public long userId { get; set; }

    }
}
