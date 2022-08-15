using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    public class InputView : BaseView
    {
        [SerializeField] private bool _enableDebug;
        [SerializeField] private InputPlayerKey[] _inputKeys;

        public event System.Action<int> OnLeftKeyPressed;
        public event System.Action<int> OnRightKeyPressed;
        public event System.Action<int> OnShootKeyPressed;

        private void Awake()
        {
            if (_enableDebug)
            {
                EnableDebug();
            }
        }

        private void Update()
        {
            for (int i = 0; i < _inputKeys.Length; i++)
            {
                InputPlayerKey input = _inputKeys[i];
                
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