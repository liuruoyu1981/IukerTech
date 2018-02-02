using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class Log_OnlineCountMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int playerNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public long onTime { get; set; }

    }
}
