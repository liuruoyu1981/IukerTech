using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class GameCfgItem
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int gameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int handNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int cost { get; set; }

    }
}
