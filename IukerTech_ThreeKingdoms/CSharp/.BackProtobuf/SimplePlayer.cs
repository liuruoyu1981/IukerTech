using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class SimplePlayer
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
        public int gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string nickName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string headImg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int posId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        public int status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        public string ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        public int gameNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public int gps_x { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        public int gps_y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        public string gps_address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        public int online { get; set; }

    }
}
