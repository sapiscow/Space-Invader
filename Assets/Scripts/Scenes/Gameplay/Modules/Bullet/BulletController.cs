using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public class BulletController : ObjectController<BulletController, BulletModel, IBulletModel, BulletView>
    {
        public bool IsViewActive => _view.gameObject.activeSelf;

        public virtual void Init(BulletModel model, BulletView view)
		{
		    _model = model;
		    SetView(view);

            _view.OnCollided += OnCollided;
        }

        public void SetViewActive(bool isActive) => _view.gameObject.SetActive(isActive);

        public void Spawn(Vector2 position, bool isAlly, float speed)
        {
            _view.transform.position = position;
            _model.SetFromAllyState(isAlly);
            _model.SetSpeed(speed);
        }

        public void SetPauseState(bool isPaused)
            => _model.SetPauseState(isPaused);

        public void OnCollided(IShootable shootable)
        {
            if (shootable.IsAlly != _model.IsFromAlly)
            {
                SetViewActive(false);
                shootable.OnShootedTriggered();
            }
        }
    }
}