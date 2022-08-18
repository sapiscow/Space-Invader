using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Audios
{
    public class AudioSfxView : BaseView
    {
        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void PlaySfx(AudioClip sfx)
            => _audioSource.PlayOneShot(sfx);
    }
}