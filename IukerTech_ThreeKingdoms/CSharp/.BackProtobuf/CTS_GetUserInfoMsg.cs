using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_GetUserInfoMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long userId { get; set; }

    }
}
