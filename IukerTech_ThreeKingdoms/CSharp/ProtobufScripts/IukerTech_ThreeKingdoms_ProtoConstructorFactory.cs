/***********************************************************************************************
Author：
CreateDate: 1/1/2018 4:58:09 PM
Email: 
***********************************************************************************************/


/*
Protobuf消息构造函数工厂脚本此脚本由框架自动生成，请勿做任何手动修改！
*/

using IukerTech_ThreeKingdoms_ProtoDefine;
using System.Collections.Generic;

namespace IukerTech
{
    public class IukerTech_ThreeKingdoms_ProtoConstructorFactory
    {
        public static CTS_LHandshakeMQData CreateCTS_LHandshakeMQData() { return new CTS_LHandshakeMQData(); }

        public static CTS_LHandshakeMQData CreateCTS_LHandshakeMQData(int type)
        {
            var message = new CTS_LHandshakeMQData();
            message.type = type;
            return message;
        }

        public static CTS_EconomyChangeMsg CreateCTS_EconomyChangeMsg() { return new CTS_EconomyChangeMsg(); }

        public static CTS_EconomyChangeMsg CreateCTS_EconomyChangeMsg(long userid)
        {
            var message = new CTS_EconomyChangeMsg();
            message.userId = userid;
            return message;
        }

        public static CTS_GetUserInfoMsg CreateCTS_GetUserInfoMsg() { return new CTS_GetUserInfoMsg(); }

        public static CTS_GetUserInfoMsg CreateCTS_GetUserInfoMsg(long userid)
        {
            var message = new CTS_GetUserInfoMsg();
            message.userId = userid;
            return message;
        }

        public static CTS_LoginMsg CreateCTS_LoginMsg() { return new CTS_LoginMsg(); }

        public static CTS_LoginMsg CreateCTS_LoginMsg(long userid,string machinecode,string account,string password,string comefrom,string sessionid,int regchannel,string os,string imei,string loginip,IukerTech_ThreeKingdoms_ProtoDefine.SocialInfo socialinfo,string[] test)
        {
            var message = new CTS_LoginMsg();
            message.userId = userid;
            message.machineCode = machinecode;
            message.account = account;
            message.password = password;
            message.comeFrom = comefrom;
            message.sessionid = sessionid;
            message.regChannel = regchannel;
            message.os = os;
            message.IMEI = imei;
            message.loginIp = loginip;
            message.socialInfo = socialinfo;
            message.test.AddRange(test);
            return message;
        }

        public static CTS_PlatformLoginMsg CreateCTS_PlatformLoginMsg() { return new CTS_PlatformLoginMsg(); }

        public static CTS_PlatformLoginMsg CreateCTS_PlatformLoginMsg(long userid,string comefrom,string sessionid,string refreshtoken,int regchannel,string os,string imei,string loginip)
        {
            var message = new CTS_PlatformLoginMsg();
            message.userId = userid;
            message.comeFrom = comefrom;
            message.sessionid = sessionid;
            message.refreshToken = refreshtoken;
            message.regChannel = regchannel;
            message.os = os;
            message.IMEI = imei;
            message.loginIp = loginip;
            return message;
        }

        public static CTS_Chat_SendMsg CreateCTS_Chat_SendMsg() { return new CTS_Chat_SendMsg(); }

        public static CTS_Chat_SendMsg CreateCTS_Chat_SendMsg(int type,int index,System.Byte[] msg,long[] consumeids)
        {
            var message = new CTS_Chat_SendMsg();
            message.type = type;
            message.index = index;
            message.msg = msg;
            message.consumeIds.AddRange(consumeids);
            return message;
        }

        public static CTS_L_GameConfigMsg CreateCTS_L_GameConfigMsg()        {
            var message = new CTS_L_GameConfigMsg();
            return message;
        }

        public static CTS_L_InviteMsg CreateCTS_L_InviteMsg() { return new CTS_L_InviteMsg(); }

        public static CTS_L_InviteMsg CreateCTS_L_InviteMsg(long inviteuid)
        {
            var message = new CTS_L_InviteMsg();
            message.inviteUid = inviteuid;
            return message;
        }

        public static CTS_L_LotteryConfigMsg CreateCTS_L_LotteryConfigMsg() { return new CTS_L_LotteryConfigMsg(); }

        public static CTS_L_LotteryConfigMsg CreateCTS_L_LotteryConfigMsg(long userid)
        {
            var message = new CTS_L_LotteryConfigMsg();
            message.userId = userid;
            return message;
        }

        public static CTS_L_LotteryOpenMsg CreateCTS_L_LotteryOpenMsg() { return new CTS_L_LotteryOpenMsg(); }

        public static CTS_L_LotteryOpenMsg CreateCTS_L_LotteryOpenMsg(long userid)
        {
            var message = new CTS_L_LotteryOpenMsg();
            message.userId = userid;
            return message;
        }

        public static CTS_L_MobileChargeMsg CreateCTS_L_MobileChargeMsg() { return new CTS_L_MobileChargeMsg(); }

        public static CTS_L_MobileChargeMsg CreateCTS_L_MobileChargeMsg(int value,long mobile)
        {
            var message = new CTS_L_MobileChargeMsg();
            message.value = value;
            message.mobile = mobile;
            return message;
        }

        public static CTS_R_GameRecordMsg CreateCTS_R_GameRecordMsg() { return new CTS_R_GameRecordMsg(); }

        public static CTS_R_GameRecordMsg CreateCTS_R_GameRecordMsg(long tableid,int handid,int gameid,long shareid)
        {
            var message = new CTS_R_GameRecordMsg();
            message.tableId = tableid;
            message.handId = handid;
            message.gameId = gameid;
            message.shareId = shareid;
            return message;
        }

        public static CTS_R_ShareMsg CreateCTS_R_ShareMsg() { return new CTS_R_ShareMsg(); }

        public static CTS_R_ShareMsg CreateCTS_R_ShareMsg(long tableid,int handid,int gameid)
        {
            var message = new CTS_R_ShareMsg();
            message.tableId = tableid;
            message.handId = handid;
            message.gameId = gameid;
            return message;
        }

        public static CTS_R_TableRecordMsg CreateCTS_R_TableRecordMsg() { return new CTS_R_TableRecordMsg(); }

        public static CTS_R_TableRecordMsg CreateCTS_R_TableRecordMsg(long tableid,int gameid)
        {
            var message = new CTS_R_TableRecordMsg();
            message.tableId = tableid;
            message.gameId = gameid;
            return message;
        }

        public static CTS_R_UserRecordMsg CreateCTS_R_UserRecordMsg() { return new CTS_R_UserRecordMsg(); }

        public static CTS_R_UserRecordMsg CreateCTS_R_UserRecordMsg(int pagenum,int pagesize)
        {
            var message = new CTS_R_UserRecordMsg();
            message.pageNum = pagenum;
            message.pageSize = pagesize;
            return message;
        }

        public static CTS_WoLong_CoutinueMsg CreateCTS_WoLong_CoutinueMsg() { return new CTS_WoLong_CoutinueMsg(); }

        public static CTS_WoLong_CoutinueMsg CreateCTS_WoLong_CoutinueMsg(long tableid)
        {
            var message = new CTS_WoLong_CoutinueMsg();
            message.tableId = tableid;
            return message;
        }

        public static CTS_WoLong_HintMsg CreateCTS_WoLong_HintMsg() { return new CTS_WoLong_HintMsg(); }

        public static CTS_WoLong_HintMsg CreateCTS_WoLong_HintMsg(long tableid)
        {
            var message = new CTS_WoLong_HintMsg();
            message.tableId = tableid;
            return message;
        }

        public static CTS_WoLong_OperateMsg CreateCTS_WoLong_OperateMsg() { return new CTS_WoLong_OperateMsg(); }

        public static CTS_WoLong_OperateMsg CreateCTS_WoLong_OperateMsg(long tableid,int actonid,int[] cards)
        {
            var message = new CTS_WoLong_OperateMsg();
            message.tableId = tableid;
            message.actonId = actonid;
            message.cards.AddRange(cards);
            return message;
        }

        public static CTS_WoLong_ReadyMsg CreateCTS_WoLong_ReadyMsg() { return new CTS_WoLong_ReadyMsg(); }

        public static CTS_WoLong_ReadyMsg CreateCTS_WoLong_ReadyMsg(long tableid,int value)
        {
            var message = new CTS_WoLong_ReadyMsg();
            message.tableId = tableid;
            message.value = value;
            return message;
        }

        public static CTS_WoLong_ReconnectMsg CreateCTS_WoLong_ReconnectMsg() { return new CTS_WoLong_ReconnectMsg(); }

        public static CTS_WoLong_ReconnectMsg CreateCTS_WoLong_ReconnectMsg(long tableid)
        {
            var message = new CTS_WoLong_ReconnectMsg();
            message.tableId = tableid;
            return message;
        }

        public static CTS_WoLong_RecordMsg CreateCTS_WoLong_RecordMsg() { return new CTS_WoLong_RecordMsg(); }

        public static CTS_WoLong_RecordMsg CreateCTS_WoLong_RecordMsg(long tableid,int bankid,int handid,int gameid)
        {
            var message = new CTS_WoLong_RecordMsg();
            message.tableId = tableid;
            message.bankId = bankid;
            message.handId = handid;
            message.gameId = gameid;
            return message;
        }

        public static CTS_WoLong_TableSettleMsg CreateCTS_WoLong_TableSettleMsg() { return new CTS_WoLong_TableSettleMsg(); }

        public static CTS_WoLong_TableSettleMsg CreateCTS_WoLong_TableSettleMsg(long tableid)
        {
            var message = new CTS_WoLong_TableSettleMsg();
            message.tableId = tableid;
            return message;
        }

        public static CTS_WoLong_Table_ActExitTableMsg CreateCTS_WoLong_Table_ActExitTableMsg() { return new CTS_WoLong_Table_ActExitTableMsg(); }

        public static CTS_WoLong_Table_ActExitTableMsg CreateCTS_WoLong_Table_ActExitTableMsg(long tableid)
        {
            var message = new CTS_WoLong_Table_ActExitTableMsg();
            message.tableId = tableid;
            return message;
        }

        public static CTS_WoLong_Table_ActInTableMsg CreateCTS_WoLong_Table_ActInTableMsg() { return new CTS_WoLong_Table_ActInTableMsg(); }

        public static CTS_WoLong_Table_ActInTableMsg CreateCTS_WoLong_Table_ActInTableMsg(long tableid,int gps_x,int gps_y,string gps_address)
        {
            var message = new CTS_WoLong_Table_ActInTableMsg();
            message.tableId = tableid;
            message.gps_x = gps_x;
            message.gps_y = gps_y;
            message.gps_address = gps_address;
            return message;
        }

        public static CTS_WoLong_Table_CreateMsg CreateCTS_WoLong_Table_CreateMsg() { return new CTS_WoLong_Table_CreateMsg(); }

        public static CTS_WoLong_Table_CreateMsg CreateCTS_WoLong_Table_CreateMsg(int gameid,long tableid,string tablename,int handtotal,int playercount,int sameaward,int lianaward,bool singleaward,bool singledouble,int gps_x,int gps_y,string gps_address)
        {
            var message = new CTS_WoLong_Table_CreateMsg();
            message.gameId = gameid;
            message.tableId = tableid;
            message.tableName = tablename;
            message.handTotal = handtotal;
            message.playerCount = playercount;
            message.sameAward = sameaward;
            message.lianAward = lianaward;
            message.singleAward = singleaward;
            message.singleDouble = singledouble;
            message.gps_x = gps_x;
            message.gps_y = gps_y;
            message.gps_address = gps_address;
            return message;
        }

        public static CTS_WoLong_Table_DissolveRequestMsg CreateCTS_WoLong_Table_DissolveRequestMsg() { return new CTS_WoLong_Table_DissolveRequestMsg(); }

        public static CTS_WoLong_Table_DissolveRequestMsg CreateCTS_WoLong_Table_DissolveRequestMsg(long tableid)
        {
            var message = new CTS_WoLong_Table_DissolveRequestMsg();
            message.tableId = tableid;
            return message;
        }

        public static CTS_WoLong_Table_DissolveVoteMsg CreateCTS_WoLong_Table_DissolveVoteMsg() { return new CTS_WoLong_Table_DissolveVoteMsg(); }

        public static CTS_WoLong_Table_DissolveVoteMsg CreateCTS_WoLong_Table_DissolveVoteMsg(long tableid,int vote)
        {
            var message = new CTS_WoLong_Table_DissolveVoteMsg();
            message.tableId = tableid;
            message.vote = vote;
            return message;
        }

        public static CTS_WoLong_Table_HeartbeatMsg CreateCTS_WoLong_Table_HeartbeatMsg() { return new CTS_WoLong_Table_HeartbeatMsg(); }

        public static CTS_WoLong_Table_HeartbeatMsg CreateCTS_WoLong_Table_HeartbeatMsg(long tableid)
        {
            var message = new CTS_WoLong_Table_HeartbeatMsg();
            message.tableId = tableid;
            return message;
        }

        public static CTS_RegisterMsg CreateCTS_RegisterMsg() { return new CTS_RegisterMsg(); }

        public static CTS_RegisterMsg CreateCTS_RegisterMsg(string account,string password,int smscode,string machinecode,string comefrom,string sessionid,int regchannel,string os,string imei,string loginip,IukerTech_ThreeKingdoms_ProtoDefine.SocialInfo socialinfo,string[] test)
        {
            var message = new CTS_RegisterMsg();
            message.account = account;
            message.password = password;
            message.smsCode = smscode;
            message.machineCode = machinecode;
            message.comeFrom = comefrom;
            message.sessionid = sessionid;
            message.regChannel = regchannel;
            message.os = os;
            message.IMEI = imei;
            message.loginIp = loginip;
            message.socialInfo = socialinfo;
            message.test.AddRange(test);
            return message;
        }

        public static CTS_GetSmsVerifyMsg CreateCTS_GetSmsVerifyMsg() { return new CTS_GetSmsVerifyMsg(); }

        public static CTS_GetSmsVerifyMsg CreateCTS_GetSmsVerifyMsg(string phone,string smsname,string sign)
        {
            var message = new CTS_GetSmsVerifyMsg();
            message.phone = phone;
            message.smsName = smsname;
            message.sign = sign;
            return message;
        }

        public static EconomyInfo CreateEconomyInfo() { return new EconomyInfo(); }

        public static EconomyInfo CreateEconomyInfo(long userid,long gold,int diamond,int paycount,int paytotal,long lastpaytime,int mobilecharge,long inviteuid,int lotterynum,int invitenum,int createtableandcostnum,int tablegamenum)
        {
            var message = new EconomyInfo();
            message.userId = userid;
            message.gold = gold;
            message.diamond = diamond;
            message.payCount = paycount;
            message.payTotal = paytotal;
            message.lastPayTime = lastpaytime;
            message.mobileCharge = mobilecharge;
            message.inviteUid = inviteuid;
            message.lotteryNum = lotterynum;
            message.inviteNum = invitenum;
            message.createTableAndCostNum = createtableandcostnum;
            message.tableGameNum = tablegamenum;
            return message;
        }

        public static SocialInfo CreateSocialInfo() { return new SocialInfo(); }

        public static SocialInfo CreateSocialInfo(long userid,string nickname,int gender,string headimg,string introduce,string mobile,string idcard,string country,string province,int city,string address)
        {
            var message = new SocialInfo();
            message.userId = userid;
            message.nickname = nickname;
            message.gender = gender;
            message.headImg = headimg;
            message.introduce = introduce;
            message.mobile = mobile;
            message.idcard = idcard;
            message.country = country;
            message.province = province;
            message.city = city;
            message.address = address;
            return message;
        }

        public static UserStatus CreateUserStatus() { return new UserStatus(); }

        public static UserStatus CreateUserStatus(long userid,int isonline,string createroomids,string lastroomid,int gameid)
        {
            var message = new UserStatus();
            message.userId = userid;
            message.isOnline = isonline;
            message.createRoomIds = createroomids;
            message.lastRoomId = lastroomid;
            message.gameId = gameid;
            return message;
        }

        public static Log_GameCostMsg CreateLog_GameCostMsg() { return new Log_GameCostMsg(); }

        public static Log_GameCostMsg CreateLog_GameCostMsg(long masterid,long[] joinusers,long ontime,int gameid,long tableid,int cost)
        {
            var message = new Log_GameCostMsg();
            message.masterId = masterid;
            message.joinUsers.AddRange(joinusers);
            message.onTime = ontime;
            message.gameId = gameid;
            message.tableId = tableid;
            message.cost = cost;
            return message;
        }

        public static Log_GameFinishMsg CreateLog_GameFinishMsg() { return new Log_GameFinishMsg(); }

        public static Log_GameFinishMsg CreateLog_GameFinishMsg(long masteruid,long[] joinuserlist,int handnum)
        {
            var message = new Log_GameFinishMsg();
            message.masterUid = masteruid;
            message.joinUserList.AddRange(joinuserlist);
            message.handNum = handnum;
            return message;
        }

        public static Log_inviteMsg CreateLog_inviteMsg() { return new Log_inviteMsg(); }

        public static Log_inviteMsg CreateLog_inviteMsg(long userid,long inviteuid,long times)
        {
            var message = new Log_inviteMsg();
            message.userId = userid;
            message.inviteUid = inviteuid;
            message.times = times;
            return message;
        }

        public static Log_LoginMsg CreateLog_LoginMsg() { return new Log_LoginMsg(); }

        public static Log_LoginMsg CreateLog_LoginMsg(long userid,long ontime)
        {
            var message = new Log_LoginMsg();
            message.userId = userid;
            message.onTime = ontime;
            return message;
        }

        public static Log_OnlineMsg CreateLog_OnlineMsg() { return new Log_OnlineMsg(); }

        public static Log_OnlineMsg CreateLog_OnlineMsg(long userid,int timelong)
        {
            var message = new Log_OnlineMsg();
            message.userId = userid;
            message.timeLong = timelong;
            return message;
        }

        public static Log_OnlineCountMsg CreateLog_OnlineCountMsg() { return new Log_OnlineCountMsg(); }

        public static Log_OnlineCountMsg CreateLog_OnlineCountMsg(int playernum,long ontime)
        {
            var message = new Log_OnlineCountMsg();
            message.playerNum = playernum;
            message.onTime = ontime;
            return message;
        }

        public static Log_RegisterMsg CreateLog_RegisterMsg() { return new Log_RegisterMsg(); }

        public static Log_RegisterMsg CreateLog_RegisterMsg(long userid,long ontime)
        {
            var message = new Log_RegisterMsg();
            message.userId = userid;
            message.onTime = ontime;
            return message;
        }

        public static WoLong_PlayerScore CreateWoLong_PlayerScore() { return new WoLong_PlayerScore(); }

        public static WoLong_PlayerScore CreateWoLong_PlayerScore(int awardscore,int gatherscore)
        {
            var message = new WoLong_PlayerScore();
            message.awardScore = awardscore;
            message.gatherScore = gatherscore;
            return message;
        }

        public static SettleItem CreateSettleItem() { return new SettleItem(); }

        public static SettleItem CreateSettleItem(int posid,int grade,int pubmultiple,int primultiple,int surpluscards,int outcardnum,int zhadannum)
        {
            var message = new SettleItem();
            message.posId = posid;
            message.grade = grade;
            message.pubMultiple = pubmultiple;
            message.priMultiple = primultiple;
            message.surplusCards = surpluscards;
            message.outCardNum = outcardnum;
            message.zhadanNum = zhadannum;
            return message;
        }

        public static GameCfgItem CreateGameCfgItem() { return new GameCfgItem(); }

        public static GameCfgItem CreateGameCfgItem(int gameid,int handnum,int cost)
        {
            var message = new GameCfgItem();
            message.gameId = gameid;
            message.handNum = handnum;
            message.cost = cost;
            return message;
        }

        public static LotteryConfigItem CreateLotteryConfigItem() { return new LotteryConfigItem(); }

        public static LotteryConfigItem CreateLotteryConfigItem(int id,int goodsid,string goodsname,int goodsnum,string desc)
        {
            var message = new LotteryConfigItem();
            message.id = id;
            message.goodsId = goodsid;
            message.goodsName = goodsname;
            message.goodsNum = goodsnum;
            message.desc = desc;
            return message;
        }

        public static RoundRecord CreateRoundRecord() { return new RoundRecord(); }

        public static RoundRecord CreateRoundRecord(long date,int handid,SettleResult[] result)
        {
            var message = new RoundRecord();
            message.date = date;
            message.handId = handid;
            message.result.AddRange(result);
            return message;
        }

        public static SettleResult CreateSettleResult() { return new SettleResult(); }

        public static SettleResult CreateSettleResult(long userid,int posid,string nickname,int score)
        {
            var message = new SettleResult();
            message.userId = userid;
            message.posId = posid;
            message.nickName = nickname;
            message.score = score;
            return message;
        }

        public static TableGrade CreateTableGrade() { return new TableGrade(); }

        public static TableGrade CreateTableGrade(long tableid,int gameid,long date,long masteruserid,GameGrade[] result)
        {
            var message = new TableGrade();
            message.tableId = tableid;
            message.gameId = gameid;
            message.date = date;
            message.masterUserId = masteruserid;
            message.result.AddRange(result);
            return message;
        }

        public static GameGrade CreateGameGrade() { return new GameGrade(); }

        public static GameGrade CreateGameGrade(long userid,int posid,string nickname,int score)
        {
            var message = new GameGrade();
            message.userId = userid;
            message.posId = posid;
            message.nickName = nickname;
            message.score = score;
            return message;
        }

        public static WoLongPlayerInfo CreateWoLongPlayerInfo() { return new WoLongPlayerInfo(); }

        public static WoLongPlayerInfo CreateWoLongPlayerInfo(int posid,int cardnum,int you,int grade,IukerTech_ThreeKingdoms_ProtoDefine.SimplePlayer player,int awardscore,int gatherscore)
        {
            var message = new WoLongPlayerInfo();
            message.posId = posid;
            message.cardNum = cardnum;
            message.you = you;
            message.grade = grade;
            message.player = player;
            message.awardScore = awardscore;
            message.gatherScore = gatherscore;
            return message;
        }

        public static SimplePlayer CreateSimplePlayer() { return new SimplePlayer(); }

        public static SimplePlayer CreateSimplePlayer(long userid,int gender,string nickname,string headimg,int posid,int status,string ip,int gamenum,int gps_x,int gps_y,string gps_address,int online)
        {
            var message = new SimplePlayer();
            message.userId = userid;
            message.gender = gender;
            message.nickName = nickname;
            message.headImg = headimg;
            message.posId = posid;
            message.status = status;
            message.ip = ip;
            message.gameNum = gamenum;
            message.gps_x = gps_x;
            message.gps_y = gps_y;
            message.gps_address = gps_address;
            message.online = online;
            return message;
        }

        public static CardGroup CreateCardGroup() { return new CardGroup(); }

        public static CardGroup CreateCardGroup(int[] item)
        {
            var message = new CardGroup();
            message.item.AddRange(item);
            return message;
        }

        public static PlayerInfo CreatePlayerInfo() { return new PlayerInfo(); }

        public static PlayerInfo CreatePlayerInfo(long userid,int posid,string nickname,int[] pricards)
        {
            var message = new PlayerInfo();
            message.userId = userid;
            message.posId = posid;
            message.nickName = nickname;
            message.priCards.AddRange(pricards);
            return message;
        }

        public static EndRankMsg CreateEndRankMsg() { return new EndRankMsg(); }

        public static EndRankMsg CreateEndRankMsg(long userid,int totalscore,int maxbomb,int bombcount,int ishost,long winplayer)
        {
            var message = new EndRankMsg();
            message.userId = userid;
            message.totalScore = totalscore;
            message.maxBomb = maxbomb;
            message.bombCount = bombcount;
            message.isHost = ishost;
            message.winPlayer = winplayer;
            return message;
        }

        public static EndPokerMsg CreateEndPokerMsg() { return new EndPokerMsg(); }

        public static EndPokerMsg CreateEndPokerMsg(long userid,int[] poker,int bomb,int score,int extrascore,string nickname,int win,int totalscore,int you,int[] otherpoker,int basescore,IukerTech_ThreeKingdoms_ProtoDefine.BigBombMsg maxbomb,int supply,int unique,int noaward)
        {
            var message = new EndPokerMsg();
            message.userId = userid;
            message.poker.AddRange(poker);
            message.bomb = bomb;
            message.score = score;
            message.extraScore = extrascore;
            message.nickName = nickname;
            message.win = win;
            message.totalScore = totalscore;
            message.you = you;
            message.otherPoker.AddRange(otherpoker);
            message.baseScore = basescore;
            message.maxBomb = maxbomb;
            message.supply = supply;
            message.unique = unique;
            message.noAward = noaward;
            return message;
        }

        public static BigBombMsg CreateBigBombMsg() { return new BigBombMsg(); }

        public static BigBombMsg CreateBigBombMsg(int count,int[] hex,string name,int extrascore)
        {
            var message = new BigBombMsg();
            message.count = count;
            message.hex.AddRange(hex);
            message.name = name;
            message.extraScore = extrascore;
            return message;
        }

        public static TeoError CreateTeoError() { return new TeoError(); }

        public static TeoError CreateTeoError(int errid,string errmsg,bool isshow)
        {
            var message = new TeoError();
            message.errId = errid;
            message.errMsg = errmsg;
            message.isShow = isshow;
            return message;
        }

        public static CreateResult CreateCreateResult() { return new CreateResult(); }

        public static CreateResult CreateCreateResult(long masterid,int password,long tableid,long createtime)
        {
            var message = new CreateResult();
            message.masterId = masterid;
            message.password = password;
            message.tableId = tableid;
            message.createTime = createtime;
            return message;
        }

        public static STC_EconomyChangeMsg CreateSTC_EconomyChangeMsg() { return new STC_EconomyChangeMsg(); }

        public static STC_EconomyChangeMsg CreateSTC_EconomyChangeMsg(long userid,IukerTech_ThreeKingdoms_ProtoDefine.EconomyInfo economy)
        {
            var message = new STC_EconomyChangeMsg();
            message.userId = userid;
            message.economy = economy;
            return message;
        }

        public static STC_LoginMsg CreateSTC_LoginMsg() { return new STC_LoginMsg(); }

        public static STC_LoginMsg CreateSTC_LoginMsg(long userid,string session,int status,string loginip,IukerTech_ThreeKingdoms_ProtoDefine.SocialInfo socialinfo,IukerTech_ThreeKingdoms_ProtoDefine.EconomyInfo economyinfo,IukerTech_ThreeKingdoms_ProtoDefine.UserStatus userstatus,string[] test,string account,string password,string gameserverip,string gameserverport,string chatport)
        {
            var message = new STC_LoginMsg();
            message.userId = userid;
            message.session = session;
            message.status = status;
            message.loginIp = loginip;
            message.socialInfo = socialinfo;
            message.economyInfo = economyinfo;
            message.userStatus = userstatus;
            message.test.AddRange(test);
            message.account = account;
            message.password = password;
            message.gameServerIp = gameserverip;
            message.gameServerPort = gameserverport;
            message.chatPort = chatport;
            return message;
        }

        public static STC_PlatformLoginMsg CreateSTC_PlatformLoginMsg() { return new STC_PlatformLoginMsg(); }

        public static STC_PlatformLoginMsg CreateSTC_PlatformLoginMsg(long userid,string refreshtoken,int status,string loginip,IukerTech_ThreeKingdoms_ProtoDefine.SocialInfo socialinfo,IukerTech_ThreeKingdoms_ProtoDefine.EconomyInfo economyinfo,IukerTech_ThreeKingdoms_ProtoDefine.UserStatus userstatus,string account,string password,string session,string platformstr,string gameserverip,string gameserverport,string chatport)
        {
            var message = new STC_PlatformLoginMsg();
            message.userId = userid;
            message.refreshToken = refreshtoken;
            message.status = status;
            message.loginIp = loginip;
            message.socialInfo = socialinfo;
            message.economyInfo = economyinfo;
            message.userStatus = userstatus;
            message.account = account;
            message.password = password;
            message.session = session;
            message.platformStr = platformstr;
            message.gameServerIp = gameserverip;
            message.gameServerPort = gameserverport;
            message.chatPort = chatport;
            return message;
        }

        public static STC_UserInfoMsg CreateSTC_UserInfoMsg() { return new STC_UserInfoMsg(); }

        public static STC_UserInfoMsg CreateSTC_UserInfoMsg(long userid,string account,int regchannel,string os,string loginip,IukerTech_ThreeKingdoms_ProtoDefine.SocialInfo socialinfo,IukerTech_ThreeKingdoms_ProtoDefine.EconomyInfo economyinfo,IukerTech_ThreeKingdoms_ProtoDefine.UserStatus userstatus,string password)
        {
            var message = new STC_UserInfoMsg();
            message.userId = userid;
            message.account = account;
            message.regChannel = regchannel;
            message.os = os;
            message.loginIp = loginip;
            message.socialInfo = socialinfo;
            message.economyInfo = economyinfo;
            message.userStatus = userstatus;
            message.password = password;
            return message;
        }

        public static STC_UserTableInfoMsg CreateSTC_UserTableInfoMsg() { return new STC_UserTableInfoMsg(); }

        public static STC_UserTableInfoMsg CreateSTC_UserTableInfoMsg(string sessionid)
        {
            var message = new STC_UserTableInfoMsg();
            message.sessionId = sessionid;
            return message;
        }

        public static STC_Chat_ContentMsg CreateSTC_Chat_ContentMsg() { return new STC_Chat_ContentMsg(); }

        public static STC_Chat_ContentMsg CreateSTC_Chat_ContentMsg(int type,int index,System.Byte[] msg,long sendid)
        {
            var message = new STC_Chat_ContentMsg();
            message.type = type;
            message.index = index;
            message.msg = msg;
            message.sendId = sendid;
            return message;
        }

        public static STC_Gdy_SettleMsg CreateSTC_Gdy_SettleMsg() { return new STC_Gdy_SettleMsg(); }

        public static STC_Gdy_SettleMsg CreateSTC_Gdy_SettleMsg(long tableid,int winposid,bool isspring,int boutnum,SettleItem[] settlelst)
        {
            var message = new STC_Gdy_SettleMsg();
            message.tableId = tableid;
            message.winPosId = winposid;
            message.isSpring = isspring;
            message.boutNum = boutnum;
            message.settleLst.AddRange(settlelst);
            return message;
        }

        public static STC_L_GameConfigMsg CreateSTC_L_GameConfigMsg() { return new STC_L_GameConfigMsg(); }

        public static STC_L_GameConfigMsg CreateSTC_L_GameConfigMsg(GameCfgItem[] list)
        {
            var message = new STC_L_GameConfigMsg();
            message.list.AddRange(list);
            return message;
        }

        public static STC_L_InviteMsg CreateSTC_L_InviteMsg() { return new STC_L_InviteMsg(); }

        public static STC_L_InviteMsg CreateSTC_L_InviteMsg(int result,string resultmsg)
        {
            var message = new STC_L_InviteMsg();
            message.result = result;
            message.resultMsg = resultmsg;
            return message;
        }

        public static STC_L_LotteryConfigMsg CreateSTC_L_LotteryConfigMsg() { return new STC_L_LotteryConfigMsg(); }

        public static STC_L_LotteryConfigMsg CreateSTC_L_LotteryConfigMsg(LotteryConfigItem[] list,int lotterynum,int invitepronum,int inviteprototal,int createtablepronum,int createtableprototal)
        {
            var message = new STC_L_LotteryConfigMsg();
            message.list.AddRange(list);
            message.lotteryNum = lotterynum;
            message.inviteProNum = invitepronum;
            message.inviteProTotal = inviteprototal;
            message.createTableProNum = createtablepronum;
            message.createTableProTotal = createtableprototal;
            return message;
        }

        public static STC_L_LotteryOpenMsg CreateSTC_L_LotteryOpenMsg() { return new STC_L_LotteryOpenMsg(); }

        public static STC_L_LotteryOpenMsg CreateSTC_L_LotteryOpenMsg(int resultid,string resultmsg,int lotterynum,int invitepronum,int inviteprototal,int createtablepronum,int createtableprototal)
        {
            var message = new STC_L_LotteryOpenMsg();
            message.resultId = resultid;
            message.resultMsg = resultmsg;
            message.lotteryNum = lotterynum;
            message.inviteProNum = invitepronum;
            message.inviteProTotal = inviteprototal;
            message.createTableProNum = createtablepronum;
            message.createTableProTotal = createtableprototal;
            return message;
        }

        public static STC_L_MobileChargeMsg CreateSTC_L_MobileChargeMsg() { return new STC_L_MobileChargeMsg(); }

        public static STC_L_MobileChargeMsg CreateSTC_L_MobileChargeMsg(int value,int result,string resultmsg)
        {
            var message = new STC_L_MobileChargeMsg();
            message.value = value;
            message.result = result;
            message.resultMsg = resultmsg;
            return message;
        }

        public static STC_Pay_SucceedMsg CreateSTC_Pay_SucceedMsg() { return new STC_Pay_SucceedMsg(); }

        public static STC_Pay_SucceedMsg CreateSTC_Pay_SucceedMsg(string orderid,int diamond)
        {
            var message = new STC_Pay_SucceedMsg();
            message.orderId = orderid;
            message.diamond = diamond;
            return message;
        }

        public static STC_R_GameRecordMsg CreateSTC_R_GameRecordMsg() { return new STC_R_GameRecordMsg(); }

        public static STC_R_GameRecordMsg CreateSTC_R_GameRecordMsg(long tableid,int handid,int gameid,long shareid)
        {
            var message = new STC_R_GameRecordMsg();
            message.tableId = tableid;
            message.handId = handid;
            message.gameId = gameid;
            message.shareId = shareid;
            return message;
        }

        public static STC_R_ShareMsg CreateSTC_R_ShareMsg() { return new STC_R_ShareMsg(); }

        public static STC_R_ShareMsg CreateSTC_R_ShareMsg(long shareid)
        {
            var message = new STC_R_ShareMsg();
            message.shareId = shareid;
            return message;
        }

        public static STC_R_TableRecordMsg CreateSTC_R_TableRecordMsg() { return new STC_R_TableRecordMsg(); }

        public static STC_R_TableRecordMsg CreateSTC_R_TableRecordMsg(long tableid,int gameid,long masteruserid,RoundRecord[] roundlist)
        {
            var message = new STC_R_TableRecordMsg();
            message.tableId = tableid;
            message.gameId = gameid;
            message.masterUserId = masteruserid;
            message.roundList.AddRange(roundlist);
            return message;
        }

        public static STC_R_UserRecordMsg CreateSTC_R_UserRecordMsg() { return new STC_R_UserRecordMsg(); }

        public static STC_R_UserRecordMsg CreateSTC_R_UserRecordMsg(TableGrade[] tablegradelist)
        {
            var message = new STC_R_UserRecordMsg();
            message.tableGradeList.AddRange(tablegradelist);
            return message;
        }

        public static STC_ErrorMsgMsg CreateSTC_ErrorMsgMsg() { return new STC_ErrorMsgMsg(); }

        public static STC_ErrorMsgMsg CreateSTC_ErrorMsgMsg(int errid,string errmsg)
        {
            var message = new STC_ErrorMsgMsg();
            message.errId = errid;
            message.errMsg = errmsg;
            return message;
        }

        public static STC_WoLong_ContinueMsg CreateSTC_WoLong_ContinueMsg() { return new STC_WoLong_ContinueMsg(); }

        public static STC_WoLong_ContinueMsg CreateSTC_WoLong_ContinueMsg(long tableid,long password,string tablename,int handnum,int postionnum,int gamestatus,int actionid,int handid,WoLongPlayerInfo[] playerlist,int[] pricards,int operateposid,int[] oeratebecards,int beposid,int sameaward,int lianaward,bool singleaward,bool singledouble)
        {
            var message = new STC_WoLong_ContinueMsg();
            message.tableId = tableid;
            message.password = password;
            message.tableName = tablename;
            message.handNum = handnum;
            message.postionNum = postionnum;
            message.gameStatus = gamestatus;
            message.actionId = actionid;
            message.handId = handid;
            message.playerList.AddRange(playerlist);
            message.priCards.AddRange(pricards);
            message.operatePosId = operateposid;
            message.oerateBeCards.AddRange(oeratebecards);
            message.bePosId = beposid;
            message.sameAward = sameaward;
            message.lianAward = lianaward;
            message.singleAward = singleaward;
            message.singleDouble = singledouble;
            return message;
        }

        public static STC_WoLong_HintMsg CreateSTC_WoLong_HintMsg() { return new STC_WoLong_HintMsg(); }

        public static STC_WoLong_HintMsg CreateSTC_WoLong_HintMsg(long tableid,CardGroup[] cardslist,int[] becards)
        {
            var message = new STC_WoLong_HintMsg();
            message.tableId = tableid;
            message.cardsList.AddRange(cardslist);
            message.beCards.AddRange(becards);
            return message;
        }

        public static STC_WoLong_OperateMsg CreateSTC_WoLong_OperateMsg() { return new STC_WoLong_OperateMsg(); }

        public static STC_WoLong_OperateMsg CreateSTC_WoLong_OperateMsg(long tableid,int posid,int actonid,int[] cards,int awardscore,int sameaward,int continuousaward,int gatherscore,int gatherscoreosid,int[] you)
        {
            var message = new STC_WoLong_OperateMsg();
            message.tableId = tableid;
            message.posId = posid;
            message.actonId = actonid;
            message.cards.AddRange(cards);
            message.awardScore = awardscore;
            message.sameAward = sameaward;
            message.continuousAward = continuousaward;
            message.gatherScore = gatherscore;
            message.gatherScoreosId = gatherscoreosid;
            message.you.AddRange(you);
            return message;
        }

        public static STC_WoLong_OperateNoticeMsg CreateSTC_WoLong_OperateNoticeMsg() { return new STC_WoLong_OperateNoticeMsg(); }

        public static STC_WoLong_OperateNoticeMsg CreateSTC_WoLong_OperateNoticeMsg(long tableid,int posid,int[] becards)
        {
            var message = new STC_WoLong_OperateNoticeMsg();
            message.tableId = tableid;
            message.posId = posid;
            message.beCards.AddRange(becards);
            return message;
        }

        public static STC_WoLong_ReadyMsg CreateSTC_WoLong_ReadyMsg() { return new STC_WoLong_ReadyMsg(); }

        public static STC_WoLong_ReadyMsg CreateSTC_WoLong_ReadyMsg(long tableid,int value,int posid)
        {
            var message = new STC_WoLong_ReadyMsg();
            message.tableId = tableid;
            message.value = value;
            message.posId = posid;
            return message;
        }

        public static STC_WoLong_ReconnectMsg CreateSTC_WoLong_ReconnectMsg() { return new STC_WoLong_ReconnectMsg(); }

        public static STC_WoLong_ReconnectMsg CreateSTC_WoLong_ReconnectMsg(long tableid,long password,string tablename,int handnum,int postionnum,int gamestatus,int actionid,int handid,WoLongPlayerInfo[] playerlist,int[] pricards,int operateposid,int[] oeratebecards,int beposid)
        {
            var message = new STC_WoLong_ReconnectMsg();
            message.tableId = tableid;
            message.password = password;
            message.tableName = tablename;
            message.handNum = handnum;
            message.postionNum = postionnum;
            message.gameStatus = gamestatus;
            message.actionId = actionid;
            message.handId = handid;
            message.playerList.AddRange(playerlist);
            message.priCards.AddRange(pricards);
            message.operatePosId = operateposid;
            message.oerateBeCards.AddRange(oeratebecards);
            message.bePosId = beposid;
            return message;
        }

        public static STC_WoLong_RecordMsg CreateSTC_WoLong_RecordMsg() { return new STC_WoLong_RecordMsg(); }

        public static STC_WoLong_RecordMsg CreateSTC_WoLong_RecordMsg(long tableid,int bankid,int handid,PlayerInfo[] playerlist,STC_WoLong_OperateMsg[] operatehistory)
        {
            var message = new STC_WoLong_RecordMsg();
            message.tableId = tableid;
            message.bankId = bankid;
            message.handId = handid;
            message.playerList.AddRange(playerlist);
            message.operateHistory.AddRange(operatehistory);
            return message;
        }

        public static STC_WoLong_SettleMsg CreateSTC_WoLong_SettleMsg() { return new STC_WoLong_SettleMsg(); }

        public static STC_WoLong_SettleMsg CreateSTC_WoLong_SettleMsg(long tableid,int snid,int handtotal,string starttime,int bankid,EndPokerMsg[] info,EndRankMsg[] rank)
        {
            var message = new STC_WoLong_SettleMsg();
            message.tableId = tableid;
            message.snId = snid;
            message.handTotal = handtotal;
            message.startTime = starttime;
            message.bankId = bankid;
            message.info.AddRange(info);
            message.rank.AddRange(rank);
            return message;
        }

        public static STC_WoLong_StartMsg CreateSTC_WoLong_StartMsg() { return new STC_WoLong_StartMsg(); }

        public static STC_WoLong_StartMsg CreateSTC_WoLong_StartMsg(long tableid,int bankid,int handid,int[] pricards)
        {
            var message = new STC_WoLong_StartMsg();
            message.tableId = tableid;
            message.bankId = bankid;
            message.handId = handid;
            message.priCards.AddRange(pricards);
            return message;
        }

        public static STC_WoLong_Table_ActExitTableMsg CreateSTC_WoLong_Table_ActExitTableMsg() { return new STC_WoLong_Table_ActExitTableMsg(); }

        public static STC_WoLong_Table_ActExitTableMsg CreateSTC_WoLong_Table_ActExitTableMsg(long userid,long tableid)
        {
            var message = new STC_WoLong_Table_ActExitTableMsg();
            message.userId = userid;
            message.tableId = tableid;
            return message;
        }

        public static STC_WoLong_Table_ActInTableMsg CreateSTC_WoLong_Table_ActInTableMsg() { return new STC_WoLong_Table_ActInTableMsg(); }

        public static STC_WoLong_Table_ActInTableMsg CreateSTC_WoLong_Table_ActInTableMsg(long tableid,long password,string tablename,int handnum,int postionnum,SimplePlayer[] playerlist,IukerTech_ThreeKingdoms_ProtoDefine.TeoError error,int sameaward,int lianaward,bool singleaward,bool singledouble)
        {
            var message = new STC_WoLong_Table_ActInTableMsg();
            message.tableId = tableid;
            message.password = password;
            message.tableName = tablename;
            message.handNum = handnum;
            message.postionNum = postionnum;
            message.playerList.AddRange(playerlist);
            message.error = error;
            message.sameAward = sameaward;
            message.lianAward = lianaward;
            message.singleAward = singleaward;
            message.singleDouble = singledouble;
            return message;
        }

        public static STC_WoLong_Table_ActInTable_PublishMsg CreateSTC_WoLong_Table_ActInTable_PublishMsg() { return new STC_WoLong_Table_ActInTable_PublishMsg(); }

        public static STC_WoLong_Table_ActInTable_PublishMsg CreateSTC_WoLong_Table_ActInTable_PublishMsg(long tableid,int posid,IukerTech_ThreeKingdoms_ProtoDefine.SimplePlayer player)
        {
            var message = new STC_WoLong_Table_ActInTable_PublishMsg();
            message.tableId = tableid;
            message.posId = posid;
            message.player = player;
            return message;
        }

        public static STC_WoLong_Table_CreateMsg CreateSTC_WoLong_Table_CreateMsg() { return new STC_WoLong_Table_CreateMsg(); }

        public static STC_WoLong_Table_CreateMsg CreateSTC_WoLong_Table_CreateMsg(int gameid,long tableid,string tablename,int handtotal,int playercount,int sameaward,int lianaward,bool singleaward,bool singledouble,IukerTech_ThreeKingdoms_ProtoDefine.CreateResult createresult,IukerTech_ThreeKingdoms_ProtoDefine.TeoError error)
        {
            var message = new STC_WoLong_Table_CreateMsg();
            message.gameId = gameid;
            message.tableId = tableid;
            message.tableName = tablename;
            message.handTotal = handtotal;
            message.playerCount = playercount;
            message.sameAward = sameaward;
            message.lianAward = lianaward;
            message.singleAward = singleaward;
            message.singleDouble = singledouble;
            message.createResult = createresult;
            message.error = error;
            return message;
        }

        public static STC_WoLong_Table_DissolveRequestMsg CreateSTC_WoLong_Table_DissolveRequestMsg() { return new STC_WoLong_Table_DissolveRequestMsg(); }

        public static STC_WoLong_Table_DissolveRequestMsg CreateSTC_WoLong_Table_DissolveRequestMsg(long tableid,long userid,string nickname,IukerTech_ThreeKingdoms_ProtoDefine.TeoError error,int result)
        {
            var message = new STC_WoLong_Table_DissolveRequestMsg();
            message.tableId = tableid;
            message.userId = userid;
            message.nickName = nickname;
            message.error = error;
            message.result = result;
            return message;
        }

        public static STC_WoLong_Table_DissolveResultMsg CreateSTC_WoLong_Table_DissolveResultMsg() { return new STC_WoLong_Table_DissolveResultMsg(); }

        public static STC_WoLong_Table_DissolveResultMsg CreateSTC_WoLong_Table_DissolveResultMsg(long tableid,int result)
        {
            var message = new STC_WoLong_Table_DissolveResultMsg();
            message.tableId = tableid;
            message.result = result;
            return message;
        }

        public static STC_WoLong_Table_DissolveVoteMsg CreateSTC_WoLong_Table_DissolveVoteMsg() { return new STC_WoLong_Table_DissolveVoteMsg(); }

        public static STC_WoLong_Table_DissolveVoteMsg CreateSTC_WoLong_Table_DissolveVoteMsg(long tableid,long requserid,string reqnickname)
        {
            var message = new STC_WoLong_Table_DissolveVoteMsg();
            message.tableId = tableid;
            message.reqUserId = requserid;
            message.reqNickName = reqnickname;
            return message;
        }

        public static STC_WoLong_Table_DissolveVoteResultMsg CreateSTC_WoLong_Table_DissolveVoteResultMsg() { return new STC_WoLong_Table_DissolveVoteResultMsg(); }

        public static STC_WoLong_Table_DissolveVoteResultMsg CreateSTC_WoLong_Table_DissolveVoteResultMsg(long tableid,int result,long userid)
        {
            var message = new STC_WoLong_Table_DissolveVoteResultMsg();
            message.tableId = tableid;
            message.result = result;
            message.userId = userid;
            return message;
        }

        public static STC_WoLong_Table_HeartbeatMsg CreateSTC_WoLong_Table_HeartbeatMsg() { return new STC_WoLong_Table_HeartbeatMsg(); }

        public static STC_WoLong_Table_HeartbeatMsg CreateSTC_WoLong_Table_HeartbeatMsg(long tableid)
        {
            var message = new STC_WoLong_Table_HeartbeatMsg();
            message.tableId = tableid;
            return message;
        }

        public static STC_GetSmsVerifyMsg CreateSTC_GetSmsVerifyMsg() { return new STC_GetSmsVerifyMsg(); }

        public static STC_GetSmsVerifyMsg CreateSTC_GetSmsVerifyMsg(string returncode)
        {
            var message = new STC_GetSmsVerifyMsg();
            message.returnCode = returncode;
            return message;
        }

    }
}
