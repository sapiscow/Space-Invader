using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Audios
{
    public class AudioView : ObjectView<IAudioModel>
    {
        [SerializeField] private AudioSource _bgmAudioSource;
        [SerializeField] private AudioSource _sfxAudioSource;

        protected override void InitRenderModel(IAudioModel model) { }

        protected override void UpdateRenderModel(IAudioModel model)
        {
            _bgmAudioSource.volume = model.BgmVolume;
            _sfxAudioSource.volume = model.SfxVolume;
        }

        public void PlayBgm(AudioClip bgm)
        {
            _bgmAudioSource.clip = bgm;
            _bgmAudioSource.Play();
        }

        public void PlaySfx(AudioClip sfx)
            => _sfxAudioSource.PlayOneShot(sfx);
    }
}