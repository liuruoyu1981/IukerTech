//   Author    : 
//   Email     : 
//   Date      : 12/6/2017 3:47 AM
//   Purpose   : Typescript本地数据表类型
var Iuker_Project;
(function (Iuker_Project) {
    var LdTable_IukerTech_ThreeKingdoms_Sirdar = /** @class */ (function () {
        function LdTable_IukerTech_ThreeKingdoms_Sirdar() {
        }
        LdTable_IukerTech_ThreeKingdoms_Sirdar.prototype.CreateEntity = function (row) {
            var entity = new LdTable_IukerTech_ThreeKingdoms_Sirdar();
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
        };
        LdTable_IukerTech_ThreeKingdoms_Sirdar.prototype.CreateEntitys = function (rows) {
            var tables = [];
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                var entityStrArray = row.split('[__]');
                var entity = this.CreateEntity(entityStrArray);
                tables.push(entity);
            }
            return tables;
        };
        return LdTable_IukerTech_ThreeKingdoms_Sirdar;
    }());
    Iuker_Project.LdTable_IukerTech_ThreeKingdoms_Sirdar = LdTable_IukerTech_ThreeKingdoms_Sirdar;
})(Iuker_Project || (Iuker_Project = {}));
//# sourceMappingURL=ldtable_iukertech_threekingdoms_sirdar.js.map