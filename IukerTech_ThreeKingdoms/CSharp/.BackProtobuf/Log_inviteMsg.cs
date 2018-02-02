using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class Log_inviteMsg
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
        public long inviteUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public long times { get; set; }

    }
}
