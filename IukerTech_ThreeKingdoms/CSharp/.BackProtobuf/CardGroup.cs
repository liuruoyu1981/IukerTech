using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CardGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int item { get; set; }

    }
}
