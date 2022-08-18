namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public interface IShootable
    {
        bool IsAlly { get; }
        
        void OnShootedTriggered();
    }
}