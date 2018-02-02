//   Author    : 
//   Email     : 
//   Date      : 12/6/2017 3:48 AM
//   Purpose   : Typescript本地数据表类型
var Iuker_Project;
(function (Iuker_Project) {
    var LdTable_IukerTech_ThreeKingdoms_SelectPower = /** @class */ (function () {
        function LdTable_IukerTech_ThreeKingdoms_SelectPower() {
        }
        LdTable_IukerTech_ThreeKingdoms_SelectPower.prototype.CreateEntity = function (row) {
            var entity = new LdTable_IukerTech_ThreeKingdoms_SelectPower();
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
        };
        LdTable_IukerTech_ThreeKingdoms_SelectPower.prototype.CreateEntitys = function (rows) {
            var tables = [];
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                var entityStrArray = row.split('[__]');
                var entity = this.CreateEntity(entityStrArray);
                tables.push(entity);
            }
            return tables;
        };
        return LdTable_IukerTech_ThreeKingdoms_SelectPower;
    }());
    Iuker_Project.LdTable_IukerTech_ThreeKingdoms_SelectPower = LdTable_IukerTech_ThreeKingdoms_SelectPower;
})(Iuker_Project || (Iuker_Project = {}));
//# sourceMappingURL=ldtable_iukertech_threekingdoms_selectpower.js.map