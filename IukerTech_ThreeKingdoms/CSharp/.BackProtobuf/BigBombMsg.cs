using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class BigBombMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int hex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public int extraScore { get; set; }

    }
}
