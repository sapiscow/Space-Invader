using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.BasePlane
{
    public abstract class BasePlaneView<TModel> : ObjectView<TModel>
        where TModel : IPlaneModel
    {
        protected SpriteRenderer _renderer;

        protected override void InitRenderModel(TModel model) { }
        protected override void UpdateRenderModel(TModel model) { }

        protected virtual void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }
    }
}