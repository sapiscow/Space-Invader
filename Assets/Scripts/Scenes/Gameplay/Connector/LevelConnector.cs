using Agate.MVC.Base;
using Sapi.SpaceInvader.Audios;
using Sapi.SpaceInvader.Gameplay.Level;
using Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner;

namespace Sapi.SpaceInvader.Gameplay
{
    public class LevelConnector : BaseConnector
    {
        private AudioSfxController _audioSfxController;

        private LevelController _levelController;
        private EnemySpawnerController _enemySpawnerController;

        protected override void Connect()
        {
            Subscribe<LevelStartedMessage>(OnLevelStarted);
            Subscribe<EnemyKilledMessage>(OnEnemyKilled);
            Subscribe<EnemiesClearedMessage>(OnEnemiesCleared);
        }

        protected override void Disconnect()
        {
            Unsubscribe<LevelStartedMessage>(OnLevelStarted);
            Unsubscribe<EnemiesClearedMessage>(OnEnemiesCleared);
        }

        private void OnLevelStarted(LevelStartedMessage message)
        {
            _enemySpawnerController.SpawnGroupEnemies();
        }

        private void OnEnemyKilled(EnemyKilledMessage message)
        {
            _enemySpawnerController.OnEnemyKilled();
            _audioSfxController.PlaySfx(AudioSfx.Killed);
        }

        private void OnEnemiesCleared(EnemiesClearedMessage message)
        {
            _levelController.FinishLevel();
        }
    }
}