using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    [CreateAssetMenu]
    public class InputScriptable : ScriptableObject
    {
        [SerializeField] private InputPlayerKey[] _inputKeys;

        public InputPlayerKey[] InputKeys => _inputKeys;
    }
}