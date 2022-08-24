using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public class BulletView : ObjectView<IBulletModel>, IShootable
    {
        private const float _despawnY = 5.5f;

        public bool IsAlly => _model.IsFromAlly;

        public event System.Action<IShootable> OnCollided;
        public event System.Action OnShooted;

        protected override void InitRenderModel(IBulletModel model) { }
        protected override void UpdateRenderModel(IBulletModel model) { }

        private void Update()
        {
            if (_model.IsPaused)
            {
                return;
            }

            transform.Translate(0f, _model.Speed * Time.deltaTime, 0f);

            if (transform.position.y >= _despawnY)
            {
                gameObject.SetActive(false);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out IShootable shootable))
            {
                OnCollided?.Invoke(shootable);
            }
        }

        public void OnShootedTriggered() => OnShooted?.Invoke();
    }
}