using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sapi.SpaceInvader.Home
{
    public class HomeView : BaseSceneView
    {
        [SerializeField] private Button _playButton;

        public void SetPlayButtonListener(UnityAction listener)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(listener);
        }
    }
}