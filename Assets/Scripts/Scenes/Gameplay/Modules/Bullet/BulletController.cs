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
		}

        public void SetViewActive(bool isActive) => _view.gameObject.SetActive(isActive);

        public void SetPosition(Vector2 position) => _view.transform.position = position;
        public void SetSpeed(float speed) => _model.SetSpeed(speed);
    }
}