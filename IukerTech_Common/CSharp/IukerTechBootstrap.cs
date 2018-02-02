using System.Collections;
using System.Reflection;
using Iuker.Jint;
using Iuker.UnityKit.Run;
using Iuker.UnityKit.Run.Base;

public class IukerTechBootstrap : Bootstrap
{
    protected override IEnumerator StartFrame()
    {
        Instance = this;
        U3DFrame = new DefaultU3DFrame();
        U3DFrame.BindingAssemblys(Assembly.GetExecutingAssembly())
            .BindingCommunicationDispatcher(typeof(U3dJintCommunicationDispatcher))
            .EnableJint()
            .SetCurrentSonProject("IukerTech_ThreeKingdoms");
        U3DFrame.Init();

        yield break;
    }
}
