using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace Sapi.SpaceInvader.Audios
{
    public class AudioModel : BaseModel, IAudioModel
    {
        private const string _bgmPath = "Bgm/";
        private const string _sfxPath = "Sfx/";

        private AudioConfigModel _configModel = new AudioConfigModel();
        private Dictionary<string, AudioClip> _bgmLibrary = new Dictionary<string, AudioClip>();
        private Dictionary<string, AudioClip> _sfxLibrary = new Dictionary<string, AudioClip>();

        public float BgmVolume => _configModel.BgmVolume;
        public float SfxVolume => _configModel.SfxVolume;

        public AudioModel()
        {
            _configModel.Load();

            AudioClip[] bgms = Resources.LoadAll<AudioClip>(_bgmPath);
            foreach (AudioClip bgm in bgms)
            {
                _bgmLibrary.Add(bgm.name, bgm);
            }

            AudioClip[] sfxs = Resources.LoadAll<AudioClip>(_sfxPath);
            foreach (AudioClip sfx in sfxs)
            {
                _sfxLibrary.Add(sfx.name, sfx);
            }
        }

        public void ToggleMuteBgm()
        {
            _configModel.SetBgmVolume(BgmVolume == 0f ? 1f : 0f);
            SetDataAsDirty();
        }

        public void ToggleMuteSfx()
        {
            _configModel.SetSfxVolume(SfxVolume == 0f ? 1f : 0f);
            SetDataAsDirty();
        }

        public AudioClip GetBgmClip(AudioBgmName bgm)
            => _bgmLibrary["bgm_" + bgm.ToString().ToLower()];

        public AudioClip GetSfxClip(AudioSfxName sfx)
            => _sfxLibrary["sfx_" + sfx.ToString().ToLower()];
    }
}