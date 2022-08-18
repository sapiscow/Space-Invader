using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    [CreateAssetMenu]
    public class EnemySpawnerScriptable : ScriptableObject
    {
        [SerializeField] private Vector2Int _gridSize = new Vector2Int(5, 3);

        public int Width => _gridSize.x;
        public int Height => _gridSize.y;
    }
}