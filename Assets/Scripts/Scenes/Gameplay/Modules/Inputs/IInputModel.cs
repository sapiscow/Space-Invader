using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Inputs
{
    public interface IInputModel : IBaseModel
    {
        InputPlayerKey[] InputKeys { get; }
    }
}