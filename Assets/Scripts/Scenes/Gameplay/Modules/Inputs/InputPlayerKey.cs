using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    [System.Serializable]
    public struct InputPlayerKey
    {
        [SerializeField] private KeyCode _leftKey;
        [SerializeField] private KeyCode _rightKey;
        [SerializeField] private KeyCode _shootKey;

        public KeyCode LeftKey => _leftKey;
        public KeyCode RightKey => _rightKey;
        public KeyCode ShootKey => _shootKey;
    }
}