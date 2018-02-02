using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_L_InviteMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public string resultMsg { get; set; }

    }
}
