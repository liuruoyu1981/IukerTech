/***********************************************************************************************
Author：
CreateDate: 11/28/2017 5:32:16 PM
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
    /// 本地数据表_LdTable_IukerTech_ThreeKingdoms_City
    /// </summary>
    [Serializable]
    public class LdTable_IukerTech_ThreeKingdoms_City : IDeepCopyLocalData<LdTable_IukerTech_ThreeKingdoms_City>
    {
        /// <summary>
        /// 索引
        /// </summary>
        public int Il8NCode;

        /// <summary>
        /// 城市名_中文
        /// </summary>
        public string CityNameCN;

        /// <summary>
        /// 城市名_英文
        /// </summary>
        public string CityNameEN;

        /// <summary>
        /// 城市类型
        /// </summary>
        public string Type;

        /// <summary>
        /// 可进攻城市集合
        /// </summary>
        public List<string> AttackTargetList;

        /// <summary>
        /// 所属州
        /// </summary>
        public string State;

        /// <summary>
        /// 所属郡
        /// </summary>
        public string Shire;

        /// <summary>
        /// 所属势力编号
        /// </summary>
        public int PowerId;

        /// <summary>
        /// 势力君主名
        /// </summary>
        public string PowerKingName;

        /// <summary>
        /// 太守
        /// </summary>
        public string Mayor;

        /// <summary>
        /// 农业值
        /// </summary>
        public int Agriculture;

        /// <summary>
        /// 商业值
        /// </summary>
        public int Business;

        /// <summary>
        /// 治安值
        /// </summary>
        public int Police;

        /// <summary>
        /// 人口值
        /// </summary>
        public int Population;

        /// <summary>
        /// 城墙值
        /// </summary>
        public int Wall;

        /// <summary>
        /// 军粮
        /// </summary>
        public int Food;

        /// <summary>
        /// 百姓忠诚度
        /// </summary>
        public int PeopleLoyalty;

        /// <summary>
        /// 城市安定度
        /// </summary>
        public int Steady;

        /// <summary>
        /// 武将数
        /// </summary>
        public int Sirdar;

        /// <summary>
        /// 士兵数
        /// </summary>
        public int Soldier;

        /// <summary>
        /// 预备兵
        /// </summary>
        public int Redif;

        /// <summary>
        /// 预备兵训练度
        /// </summary>
        public int RedifDiscipline;

        public LdTable_IukerTech_ThreeKingdoms_City CreateEntity(List<string> row)
        {
            LdTable_IukerTech_ThreeKingdoms_City entity = new LdTable_IukerTech_ThreeKingdoms_City();
            entity.Il8NCode = Convert.ToInt32(row[0]);
            entity.CityNameCN = row[1];
            entity.CityNameEN = row[2];
            entity.Type = row[3];
            entity.AttackTargetList = row[4].Split(',').ToList();
            entity.State = row[5];
            entity.Shire = row[6];
            entity.PowerId = Convert.ToInt32(row[7]);
            entity.PowerKingName = row[8];
            entity.Mayor = row[9];
            entity.Agriculture = Convert.ToInt32(row[10]);
            entity.Business = Convert.ToInt32(row[11]);
            entity.Police = Convert.ToInt32(row[12]);
            entity.Population = Convert.ToInt32(row[13]);
            entity.Wall = Convert.ToInt32(row[14]);
            entity.Food = Convert.ToInt32(row[15]);
            entity.PeopleLoyalty = Convert.ToInt32(row[16]);
            entity.Steady = Convert.ToInt32(row[17]);
            entity.Sirdar = Convert.ToInt32(row[18]);
            entity.Soldier = Convert.ToInt32(row[19]);
            entity.Redif = Convert.ToInt32(row[20]);
            entity.RedifDiscipline = Convert.ToInt32(row[21]);
            return entity;
        }

        public List<LdTable_IukerTech_ThreeKingdoms_City> CreateEntitys(List<string> listObj)
        {
            var result = new List<LdTable_IukerTech_ThreeKingdoms_City>();
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
            entityStr = entityStr + Il8NCode + "[__]";
            entityStr = entityStr + CityNameCN + "[__]";
            entityStr = entityStr + CityNameEN + "[__]";
            entityStr = entityStr + Type + "[__]";
            entityStr = entityStr + AttackTargetList + "[__]";
            entityStr = entityStr + State + "[__]";
            entityStr = entityStr + Shire + "[__]";
            entityStr = entityStr + PowerId + "[__]";
            entityStr = entityStr + PowerKingName + "[__]";
            entityStr = entityStr + Mayor + "[__]";
            entityStr = entityStr + Agriculture + "[__]";
            entityStr = entityStr + Business + "[__]";
            entityStr = entityStr + Police + "[__]";
            entityStr = entityStr + Population + "[__]";
            entityStr = entityStr + Wall + "[__]";
            entityStr = entityStr + Food + "[__]";
            entityStr = entityStr + PeopleLoyalty + "[__]";
            entityStr = entityStr + Steady + "[__]";
            entityStr = entityStr + Sirdar + "[__]";
            entityStr = entityStr + Soldier + "[__]";
            entityStr = entityStr + Redif + "[__]";
            entityStr = entityStr + RedifDiscipline + "[__]";
            entityStr = entityStr.Remove(entityStr.Length - 1);
            return entityStr;
        }

        /// <summary>
        /// 获得本地数据的一份深度复制副本
        /// </summary>
        public LdTable_IukerTech_ThreeKingdoms_City DeepCopy()
        {
            var buff = SerializeUitlity.Serialize(this);
            var entity = SerializeUitlity.DeSerialize<LdTable_IukerTech_ThreeKingdoms_City>(buff);
            return entity;
        }
    }
}
