using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class CTS_WoLong_Table_ActInTableMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public long tableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public int gps_x { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int gps_y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string gps_address { get; set; }

    }
}
