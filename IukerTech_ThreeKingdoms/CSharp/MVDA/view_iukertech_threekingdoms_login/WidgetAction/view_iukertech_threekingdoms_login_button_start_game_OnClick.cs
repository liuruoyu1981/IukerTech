/***********************************************************************************************
Author：
CreateDate: 1/10/2018 4:17:38 PM
Email: 
***********************************************************************************************/


/*
视图行为处理器脚本，在这里实现视图控件交互、视图生命周期的行为处理逻辑。
*/

using System;
using Iuker.Common;
using Iuker.UnityKit.Run.Module.View.MVDA;
using Iuker.UnityKit.Run.Module.View.ViewWidget;
using Iuker.UnityKit.Run.Base;

namespace IukerTech_ThreeKingdoms
{
    public class view_iukertech_threekingdoms_login_button_start_game_OnClick : IViewActionResponser<IButton>
    {
        private IU3dFrame mU3DFrame;
        private IViewActionRequest<IButton> _viewActionRequest;
        private IView mView;

        public IViewActionResponser<IButton> Init(IU3dFrame frame, IViewActionRequest<IButton> request, IViewModel model)
        {
            mU3DFrame = frame;
            mView = request.ActionRequester.Origin.AttachView;
            return this;
        }

        /// <summary>
        /// 行为处理器关注的视图Id
        /// </summary>
        public string ConcernedViewId { get { return "view_iukertech_threekingdoms_login";} }

        /// <summary>
        /// 行为处理器关注的视图的开启状态
        /// </summary>
        public bool IsConcernedViewClosed { get; set; }

        public void ProcessRequest(IViewActionRequest<IButton> request)
        {
            _viewActionRequest = request;
#if UNITY_EDITOR || DEBUG
            Debuger.Log("button_start_game_button_start_game is  OnClick");
#endif
        }

        public bool CheckProcessResult()
        {
                return true;
        }

        public void ProcessException(Exception ex)
        {
        
        }

        public IButton Origin { get { return _viewActionRequest.ActionRequester.Origin; } }
    }
}
