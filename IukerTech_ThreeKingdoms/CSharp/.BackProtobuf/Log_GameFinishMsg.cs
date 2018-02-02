using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class Log_GameFinishMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long masterUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public long joinUserList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int handNum { get; set; }

    }
}
