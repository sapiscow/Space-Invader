using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.BasePlane
{
    public abstract class BasePlaneView<TModel> : ObjectView<TModel>
        where TModel : IPlaneModel
    {
        [SerializeField] protected Transform _bulletSpawnPosition;

        protected SpriteRenderer _renderer;

        public Vector2 BulletSpawnPosition => _bulletSpawnPosition.position;

        protected override void InitRenderModel(TModel model) { }
        protected override void UpdateRenderModel(TModel model) { }

        protected virtual void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }
    }
}