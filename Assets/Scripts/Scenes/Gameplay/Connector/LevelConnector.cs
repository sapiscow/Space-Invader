using Agate.MVC.Base;
using Sapi.SpaceInvader.Audios;
using Sapi.SpaceInvader.Gameplay.Level;
using Sapi.SpaceInvader.Gameplay.Score;
using Sapi.SpaceInvader.Gameplay.Spawner.BulletSpawner;
using Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner;

namespace Sapi.SpaceInvader.Gameplay
{
    public class LevelConnector : BaseConnector
    {
        private AudioController _audioController;

        private LevelController _levelController;
        private ScoreController _scoreController;
        private EnemySpawnerController _enemySpawnerController;
        private BulletSpawnerController _bulletSpawnerController;

        protected override void Connect()
        {
            Subscribe<LevelStartedMessage>(OnLevelStarted);
            Subscribe<LevelPausedMessage>(OnLevelPaused);
            Subscribe<EnemyKilledMessage>(OnEnemyKilled);
            Subscribe<EnemiesClearedMessage>(OnEnemiesCleared);
        }

        protected override void Disconnect()
        {
            Unsubscribe<LevelStartedMessage>(OnLevelStarted);
            Unsubscribe<LevelPausedMessage>(OnLevelPaused);
            Unsubscribe<EnemyKilledMessage>(OnEnemyKilled);
            Unsubscribe<EnemiesClearedMessage>(OnEnemiesCleared);
        }

        private void OnLevelStarted(LevelStartedMessage message)
        {
            _enemySpawnerController.SpawnGroupEnemies();
        }

        private void OnLevelPaused(LevelPausedMessage message)
        {
            _enemySpawnerController.SetPauseState(message.IsPaused);
            _bulletSpawnerController.SetBulletsPauseState(message.IsPaused);
        }

        private void OnEnemyKilled(EnemyKilledMessage message)
        {
            _enemySpawnerController.OnEnemyKilled();
            _scoreController.AddScore(message.ScoreValue);
            _audioController.PlaySfx(AudioSfxName.Killed);
        }

        private void OnEnemiesCleared(EnemiesClearedMessage message)
        {
            _levelController.FinishLevel();
        }
    }
}