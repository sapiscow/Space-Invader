namespace Sapi.SpaceInvader.Gameplay
{
    public readonly struct LevelStartedMessage
    {
        public int Level { get; }

        public LevelStartedMessage(int level)
        {
            Level = level;
        }
    }
}