//   Author    : 
//   Email     : 
//   Date      : 2/2/2018 12:15 PM
//   Purpose   : 视图交互行为处理Javascript脚本（使用Jint执行引擎）。
var IukerTech_ThreeKingdoms;
(function (IukerTech_ThreeKingdoms) {
    var view_iukertech_threekingdoms_login_button_start_game_onclick_jint = /** @class */ (function () {
        function view_iukertech_threekingdoms_login_button_start_game_onclick_jint() {
        }
        //   该函数做一次性的初始化。
        view_iukertech_threekingdoms_login_button_start_game_onclick_jint.prototype.Init = function () {
            this.view = Iuker.ViewModule.GetJintView('view_iukertech_threekingdoms_login');
            this.model = Iuker.ViewModule.GetViewModel('view_iukertech_threekingdoms_login_model_jint', IukerTech_ThreeKingdoms.view_iukertech_threekingdoms_login_model_jint);
        };
        //   该函数用于决定在执行脚本之前是否需要执行脚本自身替换的目标Csharp脚本，执行为True,不执行为False。
        view_iukertech_threekingdoms_login_button_start_game_onclick_jint.prototype.IsDoCsharp = function () {
            return false;
        };
        //   在这里处理目标视图行为请求。
        view_iukertech_threekingdoms_login_button_start_game_onclick_jint.prototype.ProcessRequest = function () {
        };
        return view_iukertech_threekingdoms_login_button_start_game_onclick_jint;
    }());
    IukerTech_ThreeKingdoms.view_iukertech_threekingdoms_login_button_start_game_onclick_jint = view_iukertech_threekingdoms_login_button_start_game_onclick_jint;
})(IukerTech_ThreeKingdoms || (IukerTech_ThreeKingdoms = {}));
//# sourceMappingURL=view_iukertech_threekingdoms_login_button_start_game_onclick_jint.js.map