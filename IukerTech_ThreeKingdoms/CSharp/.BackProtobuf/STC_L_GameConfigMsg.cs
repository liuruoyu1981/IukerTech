using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_L_GameConfigMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public GameCfgItem list { get; set; }

    }
}
