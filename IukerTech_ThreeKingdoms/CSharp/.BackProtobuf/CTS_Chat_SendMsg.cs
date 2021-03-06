using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_Chat_SendMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public byte[] msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public long consumeIds { get; set; }

    }
}
