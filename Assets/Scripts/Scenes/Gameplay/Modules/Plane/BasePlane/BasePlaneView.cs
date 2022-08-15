using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.BasePlane
{
    public abstract class BasePlaneView<TModel> : ObjectView<TModel>
        where TModel : IPlaneModel
    {
        [SerializeField] protected float _moveSpeed = 4f;

        protected override void InitRenderModel(TModel model) { }
        protected override void UpdateRenderModel(TModel model) { }
    }
}