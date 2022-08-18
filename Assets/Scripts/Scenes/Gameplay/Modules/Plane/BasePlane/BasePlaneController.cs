using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Plane.BasePlane
{
    public abstract class BasePlaneController<TController, TModel, TInterfaceModel, TView> : ObjectController<TController, TModel, TInterfaceModel, TView>
        where TController : BasePlaneController<TController, TModel, TInterfaceModel, TView>
        where TModel : BasePlaneModel, TInterfaceModel, new()
        where TInterfaceModel : IPlaneModel
        where TView : BasePlaneView<TInterfaceModel>
    {
        public bool IsViewActive => _view.gameObject.activeSelf;

        public virtual void Init(TModel model, TView view)
		{
		    _model = model;
		    SetView(view);

            _view.OnShooted += OnShooted;
        }

        public void SetViewActive(bool isActive) => _view.gameObject.SetActive(isActive);

        protected virtual void Shoot()
        {
            Publish(new ShootMessage(_view.BulletSpawnPosition, _model.IsAlly, _model.BulletSpeed));
        }

        public virtual void OnShooted()
        {
            SetViewActive(false);
        }
    }
}