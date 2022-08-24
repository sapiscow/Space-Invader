using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    public interface IEnemySpawnerModel : IBaseModel
    {
        float MoveSpeed { get; }
        bool IsPaused { get; }
    }
}