namespace Sapi.SpaceInvader.Gameplay
{
    public readonly struct LevelFinishedMessage
    {
        public int Level { get; }

        public LevelFinishedMessage(int level)
        {
            Level = level;
        }
    }
}