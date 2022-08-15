using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Spawner;

namespace Sapi.SpaceInvader.Gameplay
{
    public class GameplayInputConnector : BaseConnector
    {
        private SpawnerController _spawnerController;

        protected override void Connect()
        {
            Subscribe<InputMessage>(OnInputKeyPressed);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InputMessage>(OnInputKeyPressed);
        }

        private void OnInputKeyPressed(InputMessage message)
        {
            _spawnerController.OnInputKeyPressed(message.PlayerIndex, message.InputKey);
        }
    }
}