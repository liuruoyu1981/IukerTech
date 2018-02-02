using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_L_InviteMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long inviteUid { get; set; }

    }
}
