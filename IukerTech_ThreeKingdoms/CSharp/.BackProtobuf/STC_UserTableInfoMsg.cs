using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_UserTableInfoMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public string sessionId { get; set; }

    }
}
