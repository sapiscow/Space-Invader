using Agate.MVC.Base;
using Agate.MVC.Core;
using Sapi.SpaceInvader.Boot;
using Sapi.SpaceInvader.Gameplay.Inputs;
using Sapi.SpaceInvader.Gameplay.Level;
using Sapi.SpaceInvader.Gameplay.Spawner.BulletSpawner;
using Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner;
using Sapi.SpaceInvader.Gameplay.Spawner.PlayerSpawner;
using System.Collections;

namespace Sapi.SpaceInvader.Gameplay
{
    public class GameplayLauncher : BaseSceneLauncher<GameplayLauncher, GameplayView>
    {
        private LevelController _levelController;
        private InputController _inputController;
        private PlayerSpawnerController _playerSpawnerController;
        private EnemySpawnerController _enemySpawnerController;
        private BulletSpawnerController _bulletSpawnerController;

        public override string SceneName => "Gameplay";

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new LevelConnector(),
                new InputConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new LevelController(),
                new InputController(),
                new PlayerSpawnerController(),
                new EnemySpawnerController(),
                new BulletSpawnerController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _inputController.SetView(_view.InputView);
            _playerSpawnerController.SetView(_view.PlayerSpawnerView);
            _enemySpawnerController.SetView(_view.EnemySpawnerView);
            _bulletSpawnerController.SetView(_view.BulletSpawnerView);

            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            _levelController.StartLevel();

            _inputController.Init();

            _playerSpawnerController.SpawnPlayerPlane(0);
            _playerSpawnerController.SpawnPlayerPlane(1);

            yield return null;
        }
    }
}