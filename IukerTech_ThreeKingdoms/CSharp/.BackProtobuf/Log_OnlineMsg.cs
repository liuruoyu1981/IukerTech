using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class Log_OnlineMsg
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
        public int timeLong { get; set; }

    }
}
