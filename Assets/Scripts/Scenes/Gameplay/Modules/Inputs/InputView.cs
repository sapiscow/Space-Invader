using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    public class InputView : ObjectView<IInputModel>
    {
        [SerializeField] private bool _enableDebug;

        public event System.Action<int> OnLeftKeyPressed;
        public event System.Action<int> OnRightKeyPressed;
        public event System.Action<int> OnShootKeyPressed;

        protected override void InitRenderModel(IInputModel model) { }
        protected override void UpdateRenderModel(IInputModel model) { }

        private void Awake()
        {
            if (_enableDebug)
            {
                EnableDebug();
            }
        }

        private void Update()
        {
            if (_model == null || _model.InputKeys == null)
            {
                return;
            }

            for (int i = 0; i < _model.InputKeys.Length; i++)
            {
                InputPlayerKey input = _model.InputKeys[i];
                
                if (Input.GetKey(input.LeftKey)) OnLeftKeyPressed?.Invoke(i);
                if (Input.GetKey(input.RightKey)) OnRightKeyPressed?.Invoke(i);
                if (Input.GetKeyDown(input.ShootKey)) OnShootKeyPressed?.Invoke(i);
            }
        }

        private void EnableDebug()
        {
            OnLeftKeyPressed += index => Debug.Log($"Player {index} pressed Left Key");
            OnRightKeyPressed += index => Debug.Log($"Player {index} pressed Right Key");
            OnShootKeyPressed += index => Debug.Log($"Player {index} pressed Shoot Key");
        }
    }
}