using Agate.MVC.Base;
using Agate.MVC.Core;
using Sapi.SpaceInvader.Boot;
using System.Collections;

namespace Sapi.SpaceInvader.Home
{
    public class HomeLauncher : BaseSceneLauncher<HomeLauncher, HomeView>
    {
        public override string SceneName => "Home";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetPlayButtonListener(OnPlayButtonClicked);
            
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnPlayButtonClicked()
        {
            GetLoader().LoadScene("Gameplay");
        }
    }
}