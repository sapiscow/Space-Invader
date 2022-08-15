using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    public class InputModel : BaseModel, IInputModel
    {
        private const string _inputConfigPath = "Inputs/InputScriptable";

        private InputScriptable _inputConfig;

        public InputPlayerKey[] InputKeys => _inputConfig.InputKeys;

        public InputModel()
        {
            _inputConfig = Resources.Load<InputScriptable>(_inputConfigPath);
        }
    }
}