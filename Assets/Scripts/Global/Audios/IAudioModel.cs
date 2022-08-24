using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Audios
{
    public interface IAudioModel : IBaseModel
    {
        float BgmVolume { get; }
        float SfxVolume { get; }
    }
}