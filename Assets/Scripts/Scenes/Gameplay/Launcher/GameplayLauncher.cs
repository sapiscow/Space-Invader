using Agate.MVC.Base;
using Agate.MVC.Core;
using Sapi.SpaceInvader.Boot;
using Sapi.SpaceInvader.Gameplay.Inputs;
using Sapi.SpaceInvader.Gameplay.Spawner.BulletSpawner;
using Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner;
using Sapi.SpaceInvader.Gameplay.Spawner.PlayerSpawner;
using System.Collections;

namespace Sapi.SpaceInvader.Gameplay
{
    public class GameplayLauncher : BaseSceneLauncher<GameplayLauncher, GameplayView>
    {
        private PlayerSpawnerController _playerSpawnerController;
        private EnemySpawnerController _enemySpawnerController;
        private BulletSpawnerController _bulletSpawnerController;
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
                new PlayerSpawnerController(),
                new EnemySpawnerController(),
                new BulletSpawnerController(),
                new InputController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _playerSpawnerController.SetView(_view.PlayerSpawnerView);
            _enemySpawnerController.SetView(_view.EnemySpawnerView);
            _bulletSpawnerController.SetView(_view.BulletSpawnerView);
            _inputController.SetView(_view.InputView);

            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            _inputController.Init();

            _playerSpawnerController.SpawnPlayerPlane(0);
            _playerSpawnerController.SpawnPlayerPlane(1);

            yield return null;
        }
    }
}