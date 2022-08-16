using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane
{
    public class PlayerPlaneModel : BasePlaneModel, IPlayerPlaneModel
    {
        private const string _playerPlaneConfigPath = "Plane/PlayerPlaneScriptable";

        private PlayerPlaneScriptable _playerPlaneConfig;

        public int PlayerIndex { get; private set; }

        public Color Color => _playerPlaneConfig.PlaneColors[PlayerIndex];
        public float MoveSpeed => _playerPlaneConfig.MoveSpeed;
        public float BulletSpeed => _playerPlaneConfig.BulletSpeed;

        public PlayerPlaneModel()
        {
            _playerPlaneConfig = Resources.Load<PlayerPlaneScriptable>(_playerPlaneConfigPath);
        }

        public void SetPlayerIndex(int playerIndex)
        {
            PlayerIndex = playerIndex;
            SetDataAsDirty();
        }
    }
}