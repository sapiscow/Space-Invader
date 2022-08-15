using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    public class InputController : ObjectController<InputController, InputView>
    {
        public void Init()
        {
            _view.OnLeftKeyPressed += OnLeftKeyPressed;
            _view.OnRightKeyPressed += OnRightKeyPressed;
            _view.OnShootKeyPressed += OnShootKeyPressed;
        }

        private void OnLeftKeyPressed(int playerIndex)
            => Publish(new InputMessage(playerIndex, InputKey.Left));

        private void OnRightKeyPressed(int playerIndex)
            => Publish(new InputMessage(playerIndex, InputKey.Right));

        private void OnShootKeyPressed(int playerIndex)
            => Publish(new InputMessage(playerIndex, InputKey.Shoot));
    }
}