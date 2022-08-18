using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Bullet;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.BasePlane
{
    public abstract class BasePlaneView<TModel> : ObjectView<TModel>, IShootable
        where TModel : IPlaneModel
    {
        [SerializeField] protected Transform _bulletSpawnPosition;

        protected SpriteRenderer _renderer;

        public Vector2 BulletSpawnPosition => _bulletSpawnPosition.position;
        public bool IsAlly => _model.IsAlly;

        public event System.Action OnShooted;

        protected override void InitRenderModel(TModel model) { }
        protected override void UpdateRenderModel(TModel model) { }

        protected virtual void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }

        public void OnShootedTriggered() => OnShooted?.Invoke();
    }
}