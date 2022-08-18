using System.Collections;
using Agate.MVC.Base;
using UnityEngine;

namespace Sapi.SpaceInvader.Audios
{
    public class AudioSfxController : ObjectController<AudioSfxController, AudioSfxModel, AudioSfxView>
    {
        private const string _viewPrefabPath = "Audios/AudioSfxView";

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();

            AudioSfxView view = AudioSfxView.Instantiate(Resources.Load<AudioSfxView>(_viewPrefabPath));
            GameObject.DontDestroyOnLoad(view);
            SetView(view);
        }

        public void PlaySfx(AudioSfx sfx)
            => _view.PlaySfx(_model.GetSfxClip(sfx));
    }
}