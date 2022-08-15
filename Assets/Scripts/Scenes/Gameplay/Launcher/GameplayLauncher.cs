using Agate.MVC.Base;
using Agate.MVC.Core;
using Sapi.SpaceInvader.Boot;
using Sapi.SpaceInvader.Gameplay.Inputs;
using Sapi.SpaceInvader.Gameplay.Spawner;
using System.Collections;

namespace Sapi.SpaceInvader.Gameplay
{
    public class GameplayLauncher : BaseSceneLauncher<GameplayLauncher, GameplayView>
    {
        private SpawnerController _spawnerController;
        private InputController _inputController;

        public override string SceneName => "Gameplay";

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayInputConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new SpawnerController(),
                new InputController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _spawnerController.SetView(_view.SpawnerView);
            _inputController.SetView(_view.InputView);

            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            _inputController.Init();
            _spawnerController.SpawnPlayerPlane(0);

            yield return null;
        }
    }
}