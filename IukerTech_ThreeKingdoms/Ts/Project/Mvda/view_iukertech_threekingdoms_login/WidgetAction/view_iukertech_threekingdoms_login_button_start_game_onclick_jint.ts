//   Author    : 
//   Email     : 
//   Date      : 2/2/2018 12:15 PM
//   Purpose   : 视图交互行为处理Javascript脚本（使用Jint执行引擎）。

namespace IukerTech_ThreeKingdoms {

    export class view_iukertech_threekingdoms_login_button_start_game_onclick_jint {

        private view: IJintView;
        private model: view_iukertech_threekingdoms_login_model_jint;

        //   该函数做一次性的初始化。
        Init() {
            this.view = Iuker.ViewModule.GetJintView('view_iukertech_threekingdoms_login');
            this.model = Iuker.ViewModule.GetViewModel('view_iukertech_threekingdoms_login_model_jint',view_iukertech_threekingdoms_login_model_jint);
        }

        //   该函数用于决定在执行脚本之前是否需要执行脚本自身替换的目标Csharp脚本，执行为True,不执行为False。
        IsDoCsharp() {
            return false;
        }

        //   在这里处理目标视图行为请求。
        ProcessRequest() {
        }
    }
}
