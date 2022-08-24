using Agate.MVC.Base;
using Agate.MVC.Core;
using Sapi.SpaceInvader.Audios;
using Sapi.SpaceInvader.Boot;
using System.Collections;
using UnityEngine;

namespace Sapi.SpaceInvader.Home
{
    public class HomeLauncher : BaseSceneLauncher<HomeLauncher, HomeView>
    {
        private AudioController _audioController;

        public override string SceneName => "Home";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetPlayButtonListener(OnPlayButtonClicked);
            _view.SetCloseButtonListener(OnCloseButtonClicked);
            _view.SetBgmButtonListener(OnBgmButtonClicked);
            _view.SetSfxButtonListener(OnSfxButtonClicked);

            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            _view.UpdateBgmState(_audioController.IsBgmMuted);
            _view.UpdateSfxState(_audioController.IsSfxMuted);

            _audioController.PlayBgm(AudioBgmName.Home);

            yield return null;
        }

        private void OnPlayButtonClicked()
        {
            GetLoader().LoadScene("Gameplay");
            _audioController.PlaySfx(AudioSfxName.Shoot);
        }

        private void OnCloseButtonClicked()
        {
            Application.Quit();
        }

        private void OnBgmButtonClicked()
        {
            _audioController.ToogleMuteBgm();
            _view.UpdateBgmState(_audioController.IsBgmMuted);
        }

        private void OnSfxButtonClicked()
        {
            _audioController.ToggleMuteSfx();
            _view.UpdateSfxState(_audioController.IsSfxMuted);
        }
    }
}