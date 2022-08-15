using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Sapi.SpaceInvader.Boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        protected override ILoad GetLoader() => SceneLoader.Instance;
        protected override IMain GetMain() => GameMain.Instance;
    }
}