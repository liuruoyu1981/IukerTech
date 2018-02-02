//   Author    : 
//   Email     : 
//   Date      : 2/2/2018 12:04 PM
//   Purpose   : 视图容器Typescript脚本（使用Jint执行引擎）。

namespace IukerTech_ThreeKingdoms {

    export class view_iukertech_threekingdoms_login_jint {

        InitViewWidgets() {

            let v = Iuker.ViewModule.GetJintView('view_iukertech_threekingdoms_login');

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


        }
    }
}
