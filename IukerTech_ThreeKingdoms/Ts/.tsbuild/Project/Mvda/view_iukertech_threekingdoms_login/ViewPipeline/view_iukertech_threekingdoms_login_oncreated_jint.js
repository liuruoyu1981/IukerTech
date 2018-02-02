//   Author    : 
//   Email     : 
//   Date      : 2/2/2018 12:18 PM
//   Purpose   : 视图容器生命周期处理Javascript脚本（使用Jint执行引擎）。
var IukerTech_ThreeKingdoms;
(function (IukerTech_ThreeKingdoms) {
    var view_iukertech_threekingdoms_login_oncreated_jint = /** @class */ (function () {
        function view_iukertech_threekingdoms_login_oncreated_jint() {
        }
        //   该函数做一次性的初始化。
        view_iukertech_threekingdoms_login_oncreated_jint.prototype.Init = function () {
        };
        //   该函数用于决定在执行脚本之前是否需要执行脚本自身替换的目标Csharp脚本，执行为True,不执行为False。
        view_iukertech_threekingdoms_login_oncreated_jint.prototype.IsDoCsharp = function () {
            return false;
        };
        //   在这里处理目标视图的生命周期。
        view_iukertech_threekingdoms_login_oncreated_jint.prototype.ProcessRequest = function () {
            Iuker.MusicModule.Play(IukerTech_ThreeKingdoms.AssetId_IukerTech_ThreeKingdoms_Music.iukertech_threekingdoms_music_login);
        };
        return view_iukertech_threekingdoms_login_oncreated_jint;
    }());
    IukerTech_ThreeKingdoms.view_iukertech_threekingdoms_login_oncreated_jint = view_iukertech_threekingdoms_login_oncreated_jint;
})(IukerTech_ThreeKingdoms || (IukerTech_ThreeKingdoms = {}));
//# sourceMappingURL=view_iukertech_threekingdoms_login_oncreated_jint.js.map