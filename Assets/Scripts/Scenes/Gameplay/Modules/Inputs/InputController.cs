using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Level;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    public class InputController : ObjectController<InputController, InputModel, IInputModel, InputView>
    {
        private LevelController _levelController;

        public override void SetView(InputView view)
        {
            base.SetView(view);
            
            _view.OnLeftKeyPressed += OnLeftKeyPressed;
            _view.OnRightKeyPressed += OnRightKeyPressed;
            _view.OnShootKeyPressed += OnShootKeyPressed;
        }

        private void OnLeftKeyPressed(int playerIndex)
        {
            if (!_levelController.IsPaused)
            {
                Publish(new InputMessage(playerIndex, InputKey.Left));
            }
        }

        private void OnRightKeyPressed(int playerIndex)
        {
            if (!_levelController.IsPaused)
            {
                Publish(new InputMessage(playerIndex, InputKey.Right));
            }
        }

        private void OnShootKeyPressed(int playerIndex)
        {
            if (!_levelController.IsPaused)
            {
                Publish(new InputMessage(playerIndex, InputKey.Shoot));
            }
        }
    }
}