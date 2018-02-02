//   Author    : 
//   Email     : 
//   Date      : 11/29/2017 4:30 PM
//   Purpose   : Typescript本地数据表类型
var Iuker_Project;
(function (Iuker_Project) {
    var LdTable_IukerTech_ThreeKingdoms_City = /** @class */ (function () {
        function LdTable_IukerTech_ThreeKingdoms_City() {
        }
        LdTable_IukerTech_ThreeKingdoms_City.prototype.CreateEntity = function (row) {
            var entity = new LdTable_IukerTech_ThreeKingdoms_City();
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
        };
        LdTable_IukerTech_ThreeKingdoms_City.prototype.CreateEntitys = function (rows) {
            var tables = [];
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                var entityStrArray = row.split('[__]');
                var entity = this.CreateEntity(entityStrArray);
                tables.push(entity);
            }
            return tables;
        };
        return LdTable_IukerTech_ThreeKingdoms_City;
    }());
    Iuker_Project.LdTable_IukerTech_ThreeKingdoms_City = LdTable_IukerTech_ThreeKingdoms_City;
})(Iuker_Project || (Iuker_Project = {}));
//# sourceMappingURL=ldtable_iukertech_threekingdoms_city.js.map