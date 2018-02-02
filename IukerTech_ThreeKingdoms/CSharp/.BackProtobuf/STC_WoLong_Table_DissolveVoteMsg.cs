using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_WoLong_Table_DissolveVoteMsg
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
        public long reqUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string reqNickName { get; set; }

    }
}
