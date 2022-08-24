using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;
using System.Collections.Generic;

namespace Sapi.SpaceInvader.Gameplay.Spawner.PlayerSpawner
{
    public class PlayerSpawnerModel : BaseModel
    {
        private List<PlayerPlaneController> _playerPlanes = new List<PlayerPlaneController>();

        public int MaxPlayer { get; private set; } = 4;

        public void RegisterPlayerPlane(PlayerPlaneController playerPlane)
            => _playerPlanes.Add(playerPlane);
            
        public PlayerPlaneController GetPlayerPlane(int playerIndex)
        {
            if (playerIndex < _playerPlanes.Count)
            {
                return _playerPlanes[playerIndex];
            }

            return null;
        }
    }
}