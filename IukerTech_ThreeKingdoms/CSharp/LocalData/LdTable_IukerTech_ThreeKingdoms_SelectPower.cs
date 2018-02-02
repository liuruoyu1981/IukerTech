/***********************************************************************************************
Author：
CreateDate: 12/6/2017 3:48:43 AM
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
    /// 本地数据表_LdTable_IukerTech_ThreeKingdoms_SelectPower
    /// </summary>
    [Serializable]
    public class LdTable_IukerTech_ThreeKingdoms_SelectPower : IDeepCopyLocalData<LdTable_IukerTech_ThreeKingdoms_SelectPower>
    {
        /// <summary>
        /// 索引
        /// </summary>
        public int Id;

        /// <summary>
        /// 势力名_君主名
        /// </summary>
        public string PowerCN;

        /// <summary>
        /// 君主半身像资源名
        /// </summary>
        public string Portrait;

        /// <summary>
        /// 势力状态
        /// </summary>
        public string State;

        /// <summary>
        /// 首府
        /// </summary>
        public string Capital;

        /// <summary>
        /// 都市数量
        /// </summary>
        public string CityCount;

        /// <summary>
        /// 人口数量
        /// </summary>
        public string PopulationCount;

        /// <summary>
        /// 粮食数量
        /// </summary>
        public string FoodCount;

        /// <summary>
        /// 金钱数量
        /// </summary>
        public string GlodCount;

        /// <summary>
        /// 武将数量
        /// </summary>
        public string sirdarCount;

        /// <summary>
        /// 士兵数量
        /// </summary>
        public string SoldierCount;

        /// <summary>
        /// 游戏困难度
        /// </summary>
        public string Hard;

        /// <summary>
        /// 发展性
        /// </summary>
        public string Expansibility;

        /// <summary>
        /// 人才
        /// </summary>
        public string Talents;

        /// <summary>
        /// 国力
        /// </summary>
        public string NationalPower;

        /// <summary>
        /// 势力描述文字
        /// </summary>
        public string PowerDesc;

        public LdTable_IukerTech_ThreeKingdoms_SelectPower CreateEntity(List<string> row)
        {
            LdTable_IukerTech_ThreeKingdoms_SelectPower entity = new LdTable_IukerTech_ThreeKingdoms_SelectPower();
            entity.Id = Convert.ToInt32(row[0]);
            entity.PowerCN = row[1];
            entity.Portrait = row[2];
            entity.State = row[3];
            entity.Capital = row[4];
            entity.CityCount = row[5];
            entity.PopulationCount = row[6];
            entity.FoodCount = row[7];
            entity.GlodCount = row[8];
            entity.sirdarCount = row[9];
            entity.SoldierCount = row[10];
            entity.Hard = row[11];
            entity.Expansibility = row[12];
            entity.Talents = row[13];
            entity.NationalPower = row[14];
            entity.PowerDesc = row[15];
            return entity;
        }

        public List<LdTable_IukerTech_ThreeKingdoms_SelectPower> CreateEntitys(List<string> listObj)
        {
            var result = new List<LdTable_IukerTech_ThreeKingdoms_SelectPower>();
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
            entityStr = entityStr + PowerCN + "[__]";
            entityStr = entityStr + Portrait + "[__]";
            entityStr = entityStr + State + "[__]";
            entityStr = entityStr + Capital + "[__]";
            entityStr = entityStr + CityCount + "[__]";
            entityStr = entityStr + PopulationCount + "[__]";
            entityStr = entityStr + FoodCount + "[__]";
            entityStr = entityStr + GlodCount + "[__]";
            entityStr = entityStr + sirdarCount + "[__]";
            entityStr = entityStr + SoldierCount + "[__]";
            entityStr = entityStr + Hard + "[__]";
            entityStr = entityStr + Expansibility + "[__]";
            entityStr = entityStr + Talents + "[__]";
            entityStr = entityStr + NationalPower + "[__]";
            entityStr = entityStr + PowerDesc + "[__]";
            entityStr = entityStr.Remove(entityStr.Length - 1);
            return entityStr;
        }

        /// <summary>
        /// 获得本地数据的一份深度复制副本
        /// </summary>
        public LdTable_IukerTech_ThreeKingdoms_SelectPower DeepCopy()
        {
            var buff = SerializeUitlity.Serialize(this);
            var entity = SerializeUitlity.DeSerialize<LdTable_IukerTech_ThreeKingdoms_SelectPower>(buff);
            return entity;
        }
    }
}
