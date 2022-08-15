using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Sapi.SpaceInvader.Boot
{
    public abstract class BaseSceneLauncher<TLauncher, TView> : BaseLauncher<TLauncher, TView>
        where TLauncher : BaseSceneLauncher<TLauncher, TView>
        where TView : BaseSceneView
    {
        protected override ILoad GetLoader() => SceneLoader.Instance;
        protected override IMain GetMain() => GameMain.Instance;
        protected override ISplash GetSplash() => SplashScreen.Instance;
    }
}