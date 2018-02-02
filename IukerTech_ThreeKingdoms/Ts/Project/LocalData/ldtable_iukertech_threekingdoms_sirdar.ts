//   Author    : 
//   Email     : 
//   Date      : 12/6/2017 3:47 AM
//   Purpose   : Typescript本地数据表类型

namespace Iuker_Project {

    export class LdTable_IukerTech_ThreeKingdoms_Sirdar implements ILocalDataEntity<LdTable_IukerTech_ThreeKingdoms_Sirdar> {

        /**
        *索引
        */
        public Id: number;

        /**
        *武将名_中文
        */
        public SirdarNameCN: string;

        /**
        *武将名_字
        */
        public SirdarZi: string;

        /**
        *武将名_英文
        */
        public SirdarNameEN: string;

        /**
        *贴图名
        */
        public TextureName: string;

        /**
        *是否武将
        */
        public IsSirdar: boolean;

        /**
        *是否工作中
        */
        public IsWorking: boolean;

        /**
        *是否出战中
        */
        public IsBatting: boolean;

        /**
        *兵种
        */
        public Arms: string;

        /**
        *年龄
        */
        public Age: number;

        /**
        *武勇
        */
        public Force: number;

        /**
        *统率
        */
        public Command: number;

        /**
        *智谋
        */
        public Resourcefulness: number;

        /**
        *政治
        */
        public Politics: number;

        /**
        *忠诚
        */
        public Loyalty: number;

        /**
        *段位
        */
        public Level: number;

        /**
        *经验
        */
        public Exp: number;

        /**
        *君主名
        */
        public KingName: string;

        /**
        *士兵数
        */
        public SoldierCount: number;

        /**
        *训练度
        */
        public Discipline: number;

        /**
        *战斗力
        */
        public Fighting: number;

        /**
        *所在地
        */
        public Location: string;

        /**
        *官位
        */
        public Position: string;

        /**
        *太守职
        */
        public Prefecture: string;

        /**
        *最大带兵数
        */
        public MaxSoldier: number;

        /**
        *美女_默认为无
        */
        public Belle: string;

        /**
        *肖像
        */
        public Portrait: string;

        public CreateEntity(row: string[]): LdTable_IukerTech_ThreeKingdoms_Sirdar {

            let entity = new LdTable_IukerTech_ThreeKingdoms_Sirdar();
            entity.Id = entity.Id = parseInt(row[0]);
            entity.SirdarNameCN = entity.SirdarNameCN = row[1];
            entity.SirdarZi = entity.SirdarZi = row[2];
            entity.SirdarNameEN = entity.SirdarNameEN = row[3];
            entity.TextureName = entity.TextureName = row[4];
            entity.IsSirdar = entity.IsSirdar = parseBoolean(row[5]);
            entity.IsWorking = entity.IsWorking = parseBoolean(row[6]);
            entity.IsBatting = entity.IsBatting = parseBoolean(row[7]);
            entity.Arms = entity.Arms = row[8];
            entity.Age = entity.Age = parseInt(row[9]);
            entity.Force = entity.Force = parseInt(row[10]);
            entity.Command = entity.Command = parseInt(row[11]);
            entity.Resourcefulness = entity.Resourcefulness = parseInt(row[12]);
            entity.Politics = entity.Politics = parseInt(row[13]);
            entity.Loyalty = entity.Loyalty = parseInt(row[14]);
            entity.Level = entity.Level = parseInt(row[15]);
            entity.Exp = entity.Exp = parseInt(row[16]);
            entity.KingName = entity.KingName = row[17];
            entity.SoldierCount = entity.SoldierCount = parseInt(row[18]);
            entity.Discipline = entity.Discipline = parseInt(row[19]);
            entity.Fighting = entity.Fighting = parseInt(row[20]);
            entity.Location = entity.Location = row[21];
            entity.Position = entity.Position = row[22];
            entity.Prefecture = entity.Prefecture = row[23];
            entity.MaxSoldier = entity.MaxSoldier = parseInt(row[24]);
            entity.Belle = entity.Belle = row[25];
            entity.Portrait = entity.Portrait = row[26];
            return entity;
        }

        public CreateEntitys(rows: string[]): LdTable_IukerTech_ThreeKingdoms_Sirdar[] {

            let tables: LdTable_IukerTech_ThreeKingdoms_Sirdar[] = [];
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

