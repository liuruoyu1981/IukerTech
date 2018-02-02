/***********************************************************************************************
Author：
CreateDate: 12/6/2017 3:47:41 AM
Email: 
***********************************************************************************************/


/*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Iuker.Common.Module.LocalData;
using Iuker.Common.Constant;
using Iuker.Common.Utility;

namespace IukerTech
{
    /// <summary>
    /// 本地数据表_LdTable_IukerTech_ThreeKingdoms_Sirdar
    /// </summary>
    [Serializable]
    public class LdTable_IukerTech_ThreeKingdoms_Sirdar : IDeepCopyLocalData<LdTable_IukerTech_ThreeKingdoms_Sirdar>
    {
        /// <summary>
        /// 索引
        /// </summary>
        public int Id;

        /// <summary>
        /// 武将名_中文
        /// </summary>
        public string SirdarNameCN;

        /// <summary>
        /// 武将名_字
        /// </summary>
        public string SirdarZi;

        /// <summary>
        /// 武将名_英文
        /// </summary>
        public string SirdarNameEN;

        /// <summary>
        /// 贴图名
        /// </summary>
        public string TextureName;

        /// <summary>
        /// 是否武将
        /// </summary>
        public bool IsSirdar;

        /// <summary>
        /// 是否工作中
        /// </summary>
        public bool IsWorking;

        /// <summary>
        /// 是否出战中
        /// </summary>
        public bool IsBatting;

        /// <summary>
        /// 兵种
        /// </summary>
        public string Arms;

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age;

        /// <summary>
        /// 武勇
        /// </summary>
        public int Force;

        /// <summary>
        /// 统率
        /// </summary>
        public int Command;

        /// <summary>
        /// 智谋
        /// </summary>
        public int Resourcefulness;

        /// <summary>
        /// 政治
        /// </summary>
        public int Politics;

        /// <summary>
        /// 忠诚
        /// </summary>
        public int Loyalty;

        /// <summary>
        /// 段位
        /// </summary>
        public int Level;

        /// <summary>
        /// 经验
        /// </summary>
        public int Exp;

        /// <summary>
        /// 君主名
        /// </summary>
        public string KingName;

        /// <summary>
        /// 士兵数
        /// </summary>
        public int SoldierCount;

        /// <summary>
        /// 训练度
        /// </summary>
        public int Discipline;

        /// <summary>
        /// 战斗力
        /// </summary>
        public int Fighting;

        /// <summary>
        /// 所在地
        /// </summary>
        public string Location;

        /// <summary>
        /// 官位
        /// </summary>
        public string Position;

        /// <summary>
        /// 太守职
        /// </summary>
        public string Prefecture;

        /// <summary>
        /// 最大带兵数
        /// </summary>
        public int MaxSoldier;

        /// <summary>
        /// 美女_默认为无
        /// </summary>
        public string Belle;

        /// <summary>
        /// 肖像
        /// </summary>
        public string Portrait;

        public LdTable_IukerTech_ThreeKingdoms_Sirdar CreateEntity(List<string> row)
        {
            LdTable_IukerTech_ThreeKingdoms_Sirdar entity = new LdTable_IukerTech_ThreeKingdoms_Sirdar();
            entity.Id = Convert.ToInt32(row[0]);
            entity.SirdarNameCN = row[1];
            entity.SirdarZi = row[2];
            entity.SirdarNameEN = row[3];
            entity.TextureName = row[4];
            entity.IsSirdar = Convert.ToBoolean(row[5]);
            entity.IsWorking = Convert.ToBoolean(row[6]);
            entity.IsBatting = Convert.ToBoolean(row[7]);
            entity.Arms = row[8];
            entity.Age = Convert.ToInt32(row[9]);
            entity.Force = Convert.ToInt32(row[10]);
            entity.Command = Convert.ToInt32(row[11]);
            entity.Resourcefulness = Convert.ToInt32(row[12]);
            entity.Politics = Convert.ToInt32(row[13]);
            entity.Loyalty = Convert.ToInt32(row[14]);
            entity.Level = Convert.ToInt32(row[15]);
            entity.Exp = Convert.ToInt32(row[16]);
            entity.KingName = row[17];
            entity.SoldierCount = Convert.ToInt32(row[18]);
            entity.Discipline = Convert.ToInt32(row[19]);
            entity.Fighting = Convert.ToInt32(row[20]);
            entity.Location = row[21];
            entity.Position = row[22];
            entity.Prefecture = row[23];
            entity.MaxSoldier = Convert.ToInt32(row[24]);
            entity.Belle = row[25];
            entity.Portrait = row[26];
            return entity;
        }

        public List<LdTable_IukerTech_ThreeKingdoms_Sirdar> CreateEntitys(List<string> listObj)
        {
            var result = new List<LdTable_IukerTech_ThreeKingdoms_Sirdar>();
            foreach (var list in listObj)
            {
                var entityListText = list.Split(Constant.TxtSeparators, StringSplitOptions.None).ToList();
                var entity = CreateEntity(entityListText);
                result.Add(entity);
            }
            return result;
        }

        /// <summary>
        /// 将本地数据对象转换为txt源数据字符串
        /// </summary>
        public string ToTxt()
        {
            string entityStr = string.Empty;
            entityStr = entityStr + Id + "[__]";
            entityStr = entityStr + SirdarNameCN + "[__]";
            entityStr = entityStr + SirdarZi + "[__]";
            entityStr = entityStr + SirdarNameEN + "[__]";
            entityStr = entityStr + TextureName + "[__]";
            entityStr = entityStr + IsSirdar + "[__]";
            entityStr = entityStr + IsWorking + "[__]";
            entityStr = entityStr + IsBatting + "[__]";
            entityStr = entityStr + Arms + "[__]";
            entityStr = entityStr + Age + "[__]";
            entityStr = entityStr + Force + "[__]";
            entityStr = entityStr + Command + "[__]";
            entityStr = entityStr + Resourcefulness + "[__]";
            entityStr = entityStr + Politics + "[__]";
            entityStr = entityStr + Loyalty + "[__]";
            entityStr = entityStr + Level + "[__]";
            entityStr = entityStr + Exp + "[__]";
            entityStr = entityStr + KingName + "[__]";
            entityStr = entityStr + SoldierCount + "[__]";
            entityStr = entityStr + Discipline + "[__]";
            entityStr = entityStr + Fighting + "[__]";
            entityStr = entityStr + Location + "[__]";
            entityStr = entityStr + Position + "[__]";
            entityStr = entityStr + Prefecture + "[__]";
            entityStr = entityStr + MaxSoldier + "[__]";
            entityStr = entityStr + Belle + "[__]";
            entityStr = entityStr + Portrait + "[__]";
            entityStr = entityStr.Remove(entityStr.Length - 1);
            return entityStr;
        }

        /// <summary>
        /// 获得本地数据的一份深度复制副本
        /// </summary>
        public LdTable_IukerTech_ThreeKingdoms_Sirdar DeepCopy()
        {
            var buff = SerializeUitlity.Serialize(this);
            var entity = SerializeUitlity.DeSerialize<LdTable_IukerTech_ThreeKingdoms_Sirdar>(buff);
            return entity;
        }
    }
}
