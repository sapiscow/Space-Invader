using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public class BulletView : ObjectView<IBulletModel>
    {
        private const float _despawnY = 5.5f;

        protected override void InitRenderModel(IBulletModel model) { }
        protected override void UpdateRenderModel(IBulletModel model) { }

        private void Update()
        {
            transform.Translate(0f, _model.Speed * Time.deltaTime, 0f);

            if (transform.position.y >= _despawnY)
            {
                gameObject.SetActive(false);
            }
        }
    }
}