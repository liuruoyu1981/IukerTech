/***********************************************************************************************
Author：
CreateDate: 1/1/2018 4:58:15 PM
Email: 
***********************************************************************************************/


/*
Protobuf消息编号解析脚本此脚本由框架自动生成，请勿做任何手动修改！
*/

using IukerTech_ThreeKingdoms_ProtoDefine;
using System.Collections.Generic;
using Iuker.Common.Module.Socket;
using UnityEngine;
using System;

namespace IukerTech
{
    public class IukerTech_ThreeKingdoms_ProtoIdResolver : IProtoIdResolver
    {
        private readonly Dictionary<string, int> mProtoIdDictionary = new Dictionary<string, int>();
        private readonly Dictionary<int, string> mProtoNameDictionary = new Dictionary<int, string>();

        public void Init()
        {
            try
            {
                mProtoIdDictionary.Add("CTS_LHandshakeMQData", 0);
                mProtoIdDictionary.Add("STC_ErrorMsgMsg", 101);
                mProtoIdDictionary.Add("CTS_LoginMsg", 201);
                mProtoIdDictionary.Add("STC_LoginMsg", 202);
                mProtoIdDictionary.Add("CTS_GetUserInfoMsg", 203);
                mProtoIdDictionary.Add("STC_UserInfoMsg", 204);
                mProtoIdDictionary.Add("CTS_PlatformLoginMsg", 205);
                mProtoIdDictionary.Add("STC_PlatformLoginMsg", 206);
                mProtoIdDictionary.Add("CTS_EconomyChangeMsg", 207);
                mProtoIdDictionary.Add("STC_GetSmsVerifyMsg", 208);
                mProtoIdDictionary.Add("CTS_RegisterMsg", 209);
                mProtoIdDictionary.Add("STC_UserTableInfoMsg", 210);
                mProtoIdDictionary.Add("STC_EconomyChangeMsg", 211);
                mProtoIdDictionary.Add("CTS_GetSmsVerifyMsg", 213);
                mProtoIdDictionary.Add("STC_Gdy_SettleMsg", 408);
                mProtoIdDictionary.Add("CTS_Chat_SendMsg", 501);
                mProtoIdDictionary.Add("STC_Chat_ContentMsg", 502);
                mProtoIdDictionary.Add("CTS_R_GameRecordMsg", 601);
                mProtoIdDictionary.Add("STC_R_GameRecordMsg", 602);
                mProtoIdDictionary.Add("CTS_R_UserRecordMsg", 603);
                mProtoIdDictionary.Add("STC_R_UserRecordMsg", 604);
                mProtoIdDictionary.Add("CTS_R_TableRecordMsg", 605);
                mProtoIdDictionary.Add("STC_R_TableRecordMsg", 606);
                mProtoIdDictionary.Add("CTS_R_ShareMsg", 607);
                mProtoIdDictionary.Add("STC_R_ShareMsg", 608);
                mProtoIdDictionary.Add("STC_Pay_SucceedMsg", 701);
                mProtoIdDictionary.Add("CTS_L_GameConfigMsg", 4901);
                mProtoIdDictionary.Add("STC_L_GameConfigMsg", 4902);
                mProtoIdDictionary.Add("CTS_L_InviteMsg", 4903);
                mProtoIdDictionary.Add("STC_L_InviteMsg", 4904);
                mProtoIdDictionary.Add("CTS_L_MobileChargeMsg", 4905);
                mProtoIdDictionary.Add("STC_L_MobileChargeMsg", 4906);
                mProtoIdDictionary.Add("CTS_L_LotteryConfigMsg", 4907);
                mProtoIdDictionary.Add("STC_L_LotteryConfigMsg", 4908);
                mProtoIdDictionary.Add("CTS_L_LotteryOpenMsg", 4909);
                mProtoIdDictionary.Add("STC_L_LotteryOpenMsg", 4910);
                mProtoIdDictionary.Add("CTS_WoLong_Table_CreateMsg", 5001);
                mProtoIdDictionary.Add("STC_WoLong_Table_CreateMsg", 5002);
                mProtoIdDictionary.Add("CTS_WoLong_Table_DissolveRequestMsg", 5003);
                mProtoIdDictionary.Add("STC_WoLong_Table_DissolveRequestMsg", 5004);
                mProtoIdDictionary.Add("CTS_WoLong_Table_ActInTableMsg", 5005);
                mProtoIdDictionary.Add("STC_WoLong_Table_ActInTableMsg", 5006);
                mProtoIdDictionary.Add("STC_WoLong_Table_ActInTable_PublishMsg", 5008);
                mProtoIdDictionary.Add("CTS_WoLong_Table_ActExitTableMsg", 5009);
                mProtoIdDictionary.Add("STC_WoLong_Table_ActExitTableMsg", 5010);
                mProtoIdDictionary.Add("CTS_WoLong_TableSettleMsg", 5011);
                mProtoIdDictionary.Add("CTS_WoLong_Table_DissolveVoteMsg", 5013);
                mProtoIdDictionary.Add("STC_WoLong_Table_DissolveVoteMsg", 5014);
                mProtoIdDictionary.Add("STC_WoLong_Table_DissolveVoteResultMsg", 5015);
                mProtoIdDictionary.Add("STC_WoLong_Table_DissolveResultMsg", 5016);
                mProtoIdDictionary.Add("CTS_WoLong_Table_HeartbeatMsg", 5017);
                mProtoIdDictionary.Add("STC_WoLong_Table_HeartbeatMsg", 5018);
                mProtoIdDictionary.Add("CTS_WoLong_ReadyMsg", 5101);
                mProtoIdDictionary.Add("STC_WoLong_ReadyMsg", 5102);
                mProtoIdDictionary.Add("STC_WoLong_StartMsg", 5103);
                mProtoIdDictionary.Add("STC_WoLong_OperateNoticeMsg", 5104);
                mProtoIdDictionary.Add("STC_WoLong_OperateMsg", 5105);
                mProtoIdDictionary.Add("CTS_WoLong_OperateMsg", 5106);
                mProtoIdDictionary.Add("STC_WoLong_SettleMsg", 5108);
                mProtoIdDictionary.Add("CTS_WoLong_CoutinueMsg", 5109);
                mProtoIdDictionary.Add("STC_WoLong_ContinueMsg", 5110);
                mProtoIdDictionary.Add("CTS_WoLong_HintMsg", 5111);
                mProtoIdDictionary.Add("STC_WoLong_HintMsg", 5112);
                mProtoIdDictionary.Add("CTS_WoLong_ReconnectMsg", 5119);
                mProtoIdDictionary.Add("STC_WoLong_ReconnectMsg", 5121);
                mProtoIdDictionary.Add("CTS_WoLong_RecordMsg", 5122);
                mProtoIdDictionary.Add("STC_WoLong_RecordMsg", 5123);

                mProtoNameDictionary.Add(0, "CTS_LHandshakeMQData");
                mProtoNameDictionary.Add(101, "STC_ErrorMsgMsg");
                mProtoNameDictionary.Add(201, "CTS_LoginMsg");
                mProtoNameDictionary.Add(202, "STC_LoginMsg");
                mProtoNameDictionary.Add(203, "CTS_GetUserInfoMsg");
                mProtoNameDictionary.Add(204, "STC_UserInfoMsg");
                mProtoNameDictionary.Add(205, "CTS_PlatformLoginMsg");
                mProtoNameDictionary.Add(206, "STC_PlatformLoginMsg");
                mProtoNameDictionary.Add(207, "CTS_EconomyChangeMsg");
                mProtoNameDictionary.Add(208, "STC_GetSmsVerifyMsg");
                mProtoNameDictionary.Add(209, "CTS_RegisterMsg");
                mProtoNameDictionary.Add(210, "STC_UserTableInfoMsg");
                mProtoNameDictionary.Add(211, "STC_EconomyChangeMsg");
                mProtoNameDictionary.Add(213, "CTS_GetSmsVerifyMsg");
                mProtoNameDictionary.Add(408, "STC_Gdy_SettleMsg");
                mProtoNameDictionary.Add(501, "CTS_Chat_SendMsg");
                mProtoNameDictionary.Add(502, "STC_Chat_ContentMsg");
                mProtoNameDictionary.Add(601, "CTS_R_GameRecordMsg");
                mProtoNameDictionary.Add(602, "STC_R_GameRecordMsg");
                mProtoNameDictionary.Add(603, "CTS_R_UserRecordMsg");
                mProtoNameDictionary.Add(604, "STC_R_UserRecordMsg");
                mProtoNameDictionary.Add(605, "CTS_R_TableRecordMsg");
                mProtoNameDictionary.Add(606, "STC_R_TableRecordMsg");
                mProtoNameDictionary.Add(607, "CTS_R_ShareMsg");
                mProtoNameDictionary.Add(608, "STC_R_ShareMsg");
                mProtoNameDictionary.Add(701, "STC_Pay_SucceedMsg");
                mProtoNameDictionary.Add(4901, "CTS_L_GameConfigMsg");
                mProtoNameDictionary.Add(4902, "STC_L_GameConfigMsg");
                mProtoNameDictionary.Add(4903, "CTS_L_InviteMsg");
                mProtoNameDictionary.Add(4904, "STC_L_InviteMsg");
                mProtoNameDictionary.Add(4905, "CTS_L_MobileChargeMsg");
                mProtoNameDictionary.Add(4906, "STC_L_MobileChargeMsg");
                mProtoNameDictionary.Add(4907, "CTS_L_LotteryConfigMsg");
                mProtoNameDictionary.Add(4908, "STC_L_LotteryConfigMsg");
                mProtoNameDictionary.Add(4909, "CTS_L_LotteryOpenMsg");
                mProtoNameDictionary.Add(4910, "STC_L_LotteryOpenMsg");
                mProtoNameDictionary.Add(5001, "CTS_WoLong_Table_CreateMsg");
                mProtoNameDictionary.Add(5002, "STC_WoLong_Table_CreateMsg");
                mProtoNameDictionary.Add(5003, "CTS_WoLong_Table_DissolveRequestMsg");
                mProtoNameDictionary.Add(5004, "STC_WoLong_Table_DissolveRequestMsg");
                mProtoNameDictionary.Add(5005, "CTS_WoLong_Table_ActInTableMsg");
                mProtoNameDictionary.Add(5006, "STC_WoLong_Table_ActInTableMsg");
                mProtoNameDictionary.Add(5008, "STC_WoLong_Table_ActInTable_PublishMsg");
                mProtoNameDictionary.Add(5009, "CTS_WoLong_Table_ActExitTableMsg");
                mProtoNameDictionary.Add(5010, "STC_WoLong_Table_ActExitTableMsg");
                mProtoNameDictionary.Add(5011, "CTS_WoLong_TableSettleMsg");
                mProtoNameDictionary.Add(5013, "CTS_WoLong_Table_DissolveVoteMsg");
                mProtoNameDictionary.Add(5014, "STC_WoLong_Table_DissolveVoteMsg");
                mProtoNameDictionary.Add(5015, "STC_WoLong_Table_DissolveVoteResultMsg");
                mProtoNameDictionary.Add(5016, "STC_WoLong_Table_DissolveResultMsg");
                mProtoNameDictionary.Add(5017, "CTS_WoLong_Table_HeartbeatMsg");
                mProtoNameDictionary.Add(5018, "STC_WoLong_Table_HeartbeatMsg");
                mProtoNameDictionary.Add(5101, "CTS_WoLong_ReadyMsg");
                mProtoNameDictionary.Add(5102, "STC_WoLong_ReadyMsg");
                mProtoNameDictionary.Add(5103, "STC_WoLong_StartMsg");
                mProtoNameDictionary.Add(5104, "STC_WoLong_OperateNoticeMsg");
                mProtoNameDictionary.Add(5105, "STC_WoLong_OperateMsg");
                mProtoNameDictionary.Add(5106, "CTS_WoLong_OperateMsg");
                mProtoNameDictionary.Add(5108, "STC_WoLong_SettleMsg");
                mProtoNameDictionary.Add(5109, "CTS_WoLong_CoutinueMsg");
                mProtoNameDictionary.Add(5110, "STC_WoLong_ContinueMsg");
                mProtoNameDictionary.Add(5111, "CTS_WoLong_HintMsg");
                mProtoNameDictionary.Add(5112, "STC_WoLong_HintMsg");
                mProtoNameDictionary.Add(5119, "CTS_WoLong_ReconnectMsg");
                mProtoNameDictionary.Add(5121, "STC_WoLong_ReconnectMsg");
                mProtoNameDictionary.Add(5122, "CTS_WoLong_RecordMsg");
                mProtoNameDictionary.Add(5123, "STC_WoLong_RecordMsg");
            }
            catch (Exception ex)
            {
                Debug.LogException(new Exception(ex.Message));
            }

        }

        /// <summary>
        /// 获取Protobuf协议编号
        /// </summary>
        public int GetProtoId(string protoname)
        {
            if(mProtoIdDictionary.ContainsKey(protoname))
            {
                return mProtoIdDictionary[protoname];
            }
            return int.MaxValue;
        }

        /// <summary>
        /// 获取Protobuf协议名
        /// </summary>
        public string GetProtoName(int commandId)
        {
            if(mProtoNameDictionary.ContainsKey(commandId))
            {
                return mProtoNameDictionary[commandId];
            }
            return null;
        }
    }
}
