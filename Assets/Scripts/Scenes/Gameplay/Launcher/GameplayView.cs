using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Inputs;
using Sapi.SpaceInvader.Gameplay.Spawner;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] private SpawnerView _spawnerView;
        [SerializeField] private InputView _inputView;

        public SpawnerView SpawnerView => _spawnerView;
        public InputView InputView => _inputView;
    }
}