using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class SettleResult
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
        public int posId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string nickName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int score { get; set; }

    }
}
