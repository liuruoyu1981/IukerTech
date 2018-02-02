using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class TeoError
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int errId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public string errMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public bool isShow { get; set; }

    }
}
