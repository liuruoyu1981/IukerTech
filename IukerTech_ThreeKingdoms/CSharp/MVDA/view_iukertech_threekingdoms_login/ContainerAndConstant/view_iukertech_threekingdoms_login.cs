/***********************************************************************************************
Author：
CreateDate: 2/2/2018 12:11:04 PM
Email: 
***********************************************************************************************/


/*
*/

using Iuker.UnityKit.Run.Module.View.MVDA;
using Iuker.UnityKit.Run.ViewWidget;
using UnityEngine;
using Iuker.UnityKit.Run.Module.View.ViewWidget;

namespace IukerTech
{
public class view_iukertech_threekingdoms_login : AbsViewBase
{
    // 视图行为字符串常量，避免临时字符串反复构建消耗。
    private const string _onBeforeCreatActionToken = "view_iukertech_threekingdoms_login_BeforeCreat";
    private const string _onCreatedActionToken = "view_iukertech_threekingdoms_login_OnCreated";
    private const string _onBeforeActiveActionToken = "view_iukertech_threekingdoms_login_BeforeActive";
    private const string _onActivedActionToken = "view_iukertech_threekingdoms_login_OnActived";
    private const string _onBeforeHideActionToken = "view_iukertech_threekingdoms_login_BeforeHide";
    private const string _onHidedActionToken = "view_iukertech_threekingdoms_login_OnHided";
    private const string _onBeforeCloseActionToken = "view_iukertech_threekingdoms_login_BeforeClose";
    private const string _onClosedActionToken = "view_iukertech_threekingdoms_login_OnClosed";
    private const string _onCreatedDrawActionToken = "view_iukertech_threekingdoms_login_Draw_OnCreated";
    private const string _onActivedDrawActionToken = "view_iukertech_threekingdoms_login_Draw_OnActived";
    private const string _onHideDrawActionToken = "view_iukertech_threekingdoms_login_Draw_OnHide";
    private const string _onCloseDrawActionToken = "view_iukertech_threekingdoms_login_Draw_OnClose";

    #region 视图控件字段
    #endregion

    protected override void InitViewWidgets()
    {
        base.InitViewWidgets();

        // 容器对象

        // 按钮对象
        InitViewWidget<IButton>("button_start_game").AddTo("button_start_game",ButtonDictionary);
        InitViewWidget<IButton>("button_load_game").AddTo("button_load_game",ButtonDictionary);
        InitViewWidget<IButton>("button_game_option").AddTo("button_game_option",ButtonDictionary);
        InitViewWidget<IButton>("button_exit_game").AddTo("button_exit_game",ButtonDictionary);

        // 文本对象

        // 输入框对象

        // Image对象

        // RawImage对象

        // Toggle对象

        // Slider对象

        // TabGroup对象

        // ListView对象

        // ToggleGroup对象

    }


    #region 视图生命周期
    protected override void BeforeCreat()
{

        base.BeforeCreat();
        var onCreateRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onBeforeCreatActionToken,ViewScriptType.ViewPipeline);
        Issue(onCreateRequest);

}

    protected override void OnCreated()
{

        base.OnCreated();
        var onCreatedRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onCreatedActionToken,ViewScriptType.ViewPipeline);
        Issue(onCreatedRequest);
        var onCreatedDrawRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>()
            .Init(this, _onCreatedDrawActionToken,ViewScriptType.ViewDraw);
        Issue(onCreatedDrawRequest);   

}

    protected override void BeforeActive()
{

        base.BeforeActive();
        var onActiveRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onBeforeActiveActionToken,ViewScriptType.ViewPipeline);
        Issue(onActiveRequest);

}

    protected override void OnActived()
{

        base.OnActived();
        var onActivedRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onActivedActionToken,ViewScriptType.ViewPipeline);
        Issue(onActivedRequest);
        var onActivedDrawRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>()
            .Init(this, _onActivedDrawActionToken,ViewScriptType.ViewDraw);
        Issue(onActivedDrawRequest);   

}

    protected override void BeforeHide()
{

        base.BeforeHide();
        var onHideRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onBeforeHideActionToken,ViewScriptType.ViewPipeline);
        Issue(onHideRequest);
        var onHideDrawRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>()
            .Init(this, _onHideDrawActionToken,ViewScriptType.ViewDraw);
        Issue(onHideDrawRequest);   

}

    protected override void OnHided()
{

        base.OnHided();
        var onHidedRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onHidedActionToken,ViewScriptType.ViewPipeline);
        Issue(onHidedRequest);

}

    protected override void BeforeClose()
{

        base.BeforeClose();
        var onCloseRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onBeforeCloseActionToken,ViewScriptType.ViewPipeline);
        Issue(onCloseRequest);
        var onCloseDrawRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>()
            .Init(this, _onCloseDrawActionToken,ViewScriptType.ViewDraw);
        Issue(onCloseDrawRequest);   

}

    protected override void OnClosed()
{

        base.OnClosed();
        var onClosedRequest = U3DFrame.InjectModule.GetInstance<IViewActionRequest<IView>>().Init(this, _onClosedActionToken,ViewScriptType.ViewPipeline);
        Issue(onClosedRequest);

}

    #endregion
}
}
