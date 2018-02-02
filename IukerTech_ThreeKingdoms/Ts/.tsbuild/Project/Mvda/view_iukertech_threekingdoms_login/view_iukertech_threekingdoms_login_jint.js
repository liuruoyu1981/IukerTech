//   Author    : 
//   Email     : 
//   Date      : 2/2/2018 12:04 PM
//   Purpose   : 视图容器Typescript脚本（使用Jint执行引擎）。
var IukerTech_ThreeKingdoms;
(function (IukerTech_ThreeKingdoms) {
    var view_iukertech_threekingdoms_login_jint = /** @class */ (function () {
        function view_iukertech_threekingdoms_login_jint() {
        }
        view_iukertech_threekingdoms_login_jint.prototype.InitViewWidgets = function () {
            var v = Iuker.ViewModule.GetJintView('view_iukertech_threekingdoms_login');
            //   获取容器控件
            //   获取按钮控件
            v.GetJintButton("button_start_game");
            v.GetJintButton("button_load_game");
            v.GetJintButton("button_game_option");
            v.GetJintButton("button_exit_game");
            //   获取文本控件
            //   获取输入框控件
            //   获取图片控件
            //   获取原始图片控件
            //   获取开关控件
            //   获取滑动器控件
        };
        return view_iukertech_threekingdoms_login_jint;
    }());
    IukerTech_ThreeKingdoms.view_iukertech_threekingdoms_login_jint = view_iukertech_threekingdoms_login_jint;
})(IukerTech_ThreeKingdoms || (IukerTech_ThreeKingdoms = {}));
//# sourceMappingURL=view_iukertech_threekingdoms_login_jint.js.map