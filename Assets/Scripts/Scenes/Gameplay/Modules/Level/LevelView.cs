using Agate.MVC.Base;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sapi.SpaceInvader.Gameplay.Level
{
    public class LevelView : ObjectView<ILevelModel>
    {
        [SerializeField] private Button _pauseButton;
        [SerializeField] private TextMeshProUGUI _pauseText;

        protected override void InitRenderModel(ILevelModel model) { }
        
        protected override void UpdateRenderModel(ILevelModel model)
        {
            _pauseText.SetText(_model.IsPaused ? "Resume" : "Pause");
        }

        public void SetPauseButton(UnityAction listener)
        {
            _pauseButton.onClick.RemoveAllListeners();
            _pauseButton.onClick.AddListener(listener);
        }
    }
}