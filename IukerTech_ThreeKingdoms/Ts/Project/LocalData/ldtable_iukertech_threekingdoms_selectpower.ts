//   Author    : 
//   Email     : 
//   Date      : 12/6/2017 3:48 AM
//   Purpose   : Typescript本地数据表类型

namespace Iuker_Project {

    export class LdTable_IukerTech_ThreeKingdoms_SelectPower implements ILocalDataEntity<LdTable_IukerTech_ThreeKingdoms_SelectPower> {

        /**
        *索引
        */
        public Id: number;

        /**
        *势力名_君主名
        */
        public PowerCN: string;

        /**
        *君主半身像资源名
        */
        public Portrait: string;

        /**
        *势力状态
        */
        public State: string;

        /**
        *首府
        */
        public Capital: string;

        /**
        *都市数量
        */
        public CityCount: string;

        /**
        *人口数量
        */
        public PopulationCount: string;

        /**
        *粮食数量
        */
        public FoodCount: string;

        /**
        *金钱数量
        */
        public GlodCount: string;

        /**
        *武将数量
        */
        public sirdarCount: string;

        /**
        *士兵数量
        */
        public SoldierCount: string;

        /**
        *游戏困难度
        */
        public Hard: string;

        /**
        *发展性
        */
        public Expansibility: string;

        /**
        *人才
        */
        public Talents: string;

        /**
        *国力
        */
        public NationalPower: string;

        /**
        *势力描述文字
        */
        public PowerDesc: string;

        public CreateEntity(row: string[]): LdTable_IukerTech_ThreeKingdoms_SelectPower {

            let entity = new LdTable_IukerTech_ThreeKingdoms_SelectPower();
            entity.Id = entity.Id = parseInt(row[0]);
            entity.PowerCN = entity.PowerCN = row[1];
            entity.Portrait = entity.Portrait = row[2];
            entity.State = entity.State = row[3];
            entity.Capital = entity.Capital = row[4];
            entity.CityCount = entity.CityCount = row[5];
            entity.PopulationCount = entity.PopulationCount = row[6];
            entity.FoodCount = entity.FoodCount = row[7];
            entity.GlodCount = entity.GlodCount = row[8];
            entity.sirdarCount = entity.sirdarCount = row[9];
            entity.SoldierCount = entity.SoldierCount = row[10];
            entity.Hard = entity.Hard = row[11];
            entity.Expansibility = entity.Expansibility = row[12];
            entity.Talents = entity.Talents = row[13];
            entity.NationalPower = entity.NationalPower = row[14];
            entity.PowerDesc = entity.PowerDesc = row[15];
            return entity;
        }

        public CreateEntitys(rows: string[]): LdTable_IukerTech_ThreeKingdoms_SelectPower[] {

            let tables: LdTable_IukerTech_ThreeKingdoms_SelectPower[] = [];
            for (let i = 0; i < rows.length; i++) {

                let row = rows[i];
                let entityStrArray = row.split('[__]');
                let entity = this.CreateEntity(entityStrArray);
                tables.push(entity);
            }

            return tables;
        }
    }
}

