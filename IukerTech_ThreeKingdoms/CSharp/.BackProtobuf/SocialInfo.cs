using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class SocialInfo
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
        public string nickname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string headImg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public string introduce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public string mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public string idcard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public string country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public string province { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public int city { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public string address { get; set; }

    }
}
