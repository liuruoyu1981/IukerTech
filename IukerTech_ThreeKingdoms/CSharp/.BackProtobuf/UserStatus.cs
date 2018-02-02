using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class UserStatus
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
        public int isOnline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public string createRoomIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        public string lastRoomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int gameId { get; set; }

    }
}
