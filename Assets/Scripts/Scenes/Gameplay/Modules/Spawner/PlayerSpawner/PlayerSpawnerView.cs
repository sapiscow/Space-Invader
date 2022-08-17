using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.PlayerSpawner
{
    public class PlayerSpawnerView : BaseView
    {
        [Header("Prefab")]
        [SerializeField] private PlayerPlaneView _playerPlanePrefab;

        public PlayerPlaneView InstantiatePlayerPlane()
            => Instantiate(_playerPlanePrefab, transform);
    }
}