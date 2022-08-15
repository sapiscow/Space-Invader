using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner
{
    public class SpawnerView : BaseView
    {
        [Header("Prefab")]
        [SerializeField] private PlayerPlaneView _playerPlanePrefab;

        [Header("Component")]
        [SerializeField] private Transform _playerParent;

        public PlayerPlaneView InstantiatePlayerPlane()
            => Instantiate(_playerPlanePrefab, _playerParent);
    }
}