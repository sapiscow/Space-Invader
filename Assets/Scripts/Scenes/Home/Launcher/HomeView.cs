using Agate.MVC.Base;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sapi.SpaceInvader.Home
{
    public class HomeView : BaseSceneView
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _closeButton;
        [SerializeField] private Button _bgmButton;
        [SerializeField] private Button _sfxButton;
        [SerializeField] private TextMeshProUGUI _bgmText;
        [SerializeField] private TextMeshProUGUI _sfxText;

        public void SetPlayButtonListener(UnityAction listener) => SetButtonListener(_playButton, listener);
        public void SetCloseButtonListener(UnityAction listener) => SetButtonListener(_closeButton, listener);
        public void SetBgmButtonListener(UnityAction listener) => SetButtonListener(_bgmButton, listener);
        public void SetSfxButtonListener(UnityAction listener) => SetButtonListener(_sfxButton, listener);

        public void UpdateBgmState(bool isMuted)
            => _bgmText.SetText($"BGM {(isMuted ? "Off" : "On")}");

        public void UpdateSfxState(bool isMuted)
            => _sfxText.SetText($"SFX {(isMuted ? "Off" : "On")}");

        private void SetButtonListener(Button button, UnityAction listener)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(listener);
        }
    }
}