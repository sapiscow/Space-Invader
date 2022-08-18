using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Audios
{
    public class AudioSfxModel : BaseModel
    {
        private const string _audioSfxPath = "Sfx/";

        private Dictionary<string, AudioClip> _sfxLibrary = new Dictionary<string, AudioClip>();

        public AudioSfxModel()
        {
            AudioClip[] sfxs = Resources.LoadAll<AudioClip>(_audioSfxPath);
            foreach (AudioClip sfx in sfxs)
            {
                _sfxLibrary.Add(sfx.name, sfx);
            }
        }

        public AudioClip GetSfxClip(AudioSfx sfx)
            => _sfxLibrary["sfx_" + sfx.ToString().ToLower()];
    }
}