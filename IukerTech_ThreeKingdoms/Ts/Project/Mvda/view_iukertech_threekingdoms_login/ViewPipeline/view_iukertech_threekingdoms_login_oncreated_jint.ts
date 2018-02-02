//   Author    : 
//   Email     : 
//   Date      : 2/2/2018 12:18 PM
//   Purpose   : 视图容器生命周期处理Javascript脚本（使用Jint执行引擎）。

namespace IukerTech_ThreeKingdoms {

    export class view_iukertech_threekingdoms_login_oncreated_jint {

        //   该函数做一次性的初始化。
        Init() {

        }

        //   该函数用于决定在执行脚本之前是否需要执行脚本自身替换的目标Csharp脚本，执行为True,不执行为False。
        IsDoCsharp() {
            return false;
        }

        //   在这里处理目标视图的生命周期。
        ProcessRequest() {

            Iuker.MusicModule.Play(AssetId_IukerTech_ThreeKingdoms_Music.iukertech_threekingdoms_music_login);
        }
    }
}
