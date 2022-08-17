using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Inputs;
using Sapi.SpaceInvader.Gameplay.Spawner.BulletSpawner;
using Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner;
using Sapi.SpaceInvader.Gameplay.Spawner.PlayerSpawner;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] private PlayerSpawnerView _playerSpawnerView;
        [SerializeField] private EnemySpawnerView _enemySpawnerView;
        [SerializeField] private BulletSpawnerView _bulletSpawnerView;
        [SerializeField] private InputView _inputView;

        public PlayerSpawnerView PlayerSpawnerView => _playerSpawnerView;
        public EnemySpawnerView EnemySpawnerView => _enemySpawnerView;
        public BulletSpawnerView BulletSpawnerView => _bulletSpawnerView;
        public InputView InputView => _inputView;
    }
}