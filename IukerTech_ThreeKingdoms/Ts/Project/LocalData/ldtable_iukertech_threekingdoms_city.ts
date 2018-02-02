//   Author    : 
//   Email     : 
//   Date      : 11/29/2017 4:30 PM
//   Purpose   : Typescript本地数据表类型

namespace Iuker_Project {

    export class LdTable_IukerTech_ThreeKingdoms_City implements ILocalDataEntity<LdTable_IukerTech_ThreeKingdoms_City> {

        /**
        *索引
        */
        public Il8NCode: number;

        /**
        *城市名_中文
        */
        public CityNameCN: string;

        /**
        *城市名_英文
        */
        public CityNameEN: string;

        /**
        *城市类型
        */
        public Type: string;

        /**
        *可进攻城市集合
        */
        public AttackTargetList: string[];

        /**
        *所属州
        */
        public State: string;

        /**
        *所属郡
        */
        public Shire: string;

        /**
        *所属势力编号
        */
        public PowerId: number;

        /**
        *势力君主名
        */
        public PowerKingName: string;

        /**
        *太守
        */
        public Mayor: string;

        /**
        *农业值
        */
        public Agriculture: number;

        /**
        *商业值
        */
        public Business: number;

        /**
        *治安值
        */
        public Police: number;

        /**
        *人口值
        */
        public Population: number;

        /**
        *城墙值
        */
        public Wall: number;

        /**
        *军粮
        */
        public Food: number;

        /**
        *百姓忠诚度
        */
        public PeopleLoyalty: number;

        /**
        *城市安定度
        */
        public Steady: number;

        /**
        *武将数
        */
        public Sirdar: number;

        /**
        *士兵数
        */
        public Soldier: number;

        /**
        *预备兵
        */
        public Redif: number;

        /**
        *预备兵训练度
        */
        public RedifDiscipline: number;

        public CreateEntity(row: string[]): LdTable_IukerTech_ThreeKingdoms_City {

            let entity = new LdTable_IukerTech_ThreeKingdoms_City();
            entity.Il8NCode = entity.Il8NCode = parseInt(row[0]);
            entity.CityNameCN = entity.CityNameCN = row[1];
            entity.CityNameEN = entity.CityNameEN = row[2];
            entity.Type = entity.Type = row[3];
            entity.AttackTargetList = entity.AttackTargetList = row[4].split('_');
            entity.State = entity.State = row[5];
            entity.Shire = entity.Shire = row[6];
            entity.PowerId = entity.PowerId = parseInt(row[7]);
            entity.PowerKingName = entity.PowerKingName = row[8];
            entity.Mayor = entity.Mayor = row[9];
            entity.Agriculture = entity.Agriculture = parseInt(row[10]);
            entity.Business = entity.Business = parseInt(row[11]);
            entity.Police = entity.Police = parseInt(row[12]);
            entity.Population = entity.Population = parseInt(row[13]);
            entity.Wall = entity.Wall = parseInt(row[14]);
            entity.Food = entity.Food = parseInt(row[15]);
            entity.PeopleLoyalty = entity.PeopleLoyalty = parseInt(row[16]);
            entity.Steady = entity.Steady = parseInt(row[17]);
            entity.Sirdar = entity.Sirdar = parseInt(row[18]);
            entity.Soldier = entity.Soldier = parseInt(row[19]);
            entity.Redif = entity.Redif = parseInt(row[20]);
            entity.RedifDiscipline = entity.RedifDiscipline = parseInt(row[21]);
            return entity;
        }

        public CreateEntitys(rows: string[]): LdTable_IukerTech_ThreeKingdoms_City[] {

            let tables: LdTable_IukerTech_ThreeKingdoms_City[] = [];
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

