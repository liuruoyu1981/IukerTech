using ProtoBuf;

namespace ThreeKingdoms
{
    [ProtoContract]
    public class STC_R_UserRecordMsg
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public TableGrade tableGradeList { get; set; }

    }
}
