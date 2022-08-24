using Agate.MVC.Base;
using System.Collections;
using UnityEngine;

namespace Sapi.SpaceInvader.Audios
{
    public class AudioController : ObjectController<AudioController, AudioModel, IAudioModel, AudioView>
    {
        private const string _viewPrefabPath = "Audios/AudioView";

        public bool IsBgmMuted => _model.BgmVolume == 0f;
        public bool IsSfxMuted => _model.SfxVolume == 0f;

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();

            AudioView view = AudioView.Instantiate(Resources.Load<AudioView>(_viewPrefabPath));
            GameObject.DontDestroyOnLoad(view);
            SetView(view);
        }

        public void ToogleMuteBgm() => _model.ToggleMuteBgm();
        public void ToggleMuteSfx() => _model.ToggleMuteSfx();

        public void PlayBgm(AudioBgmName bgm)
            => _view.PlayBgm(_model.GetBgmClip(bgm));

        public void PlaySfx(AudioSfxName sfx)
            => _view.PlaySfx(_model.GetSfxClip(sfx));
    }
}