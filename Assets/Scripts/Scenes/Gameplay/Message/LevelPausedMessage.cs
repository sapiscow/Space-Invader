namespace Sapi.SpaceInvader.Gameplay.Level
{
    public readonly struct LevelPausedMessage
    {
        public bool IsPaused { get; }

        public LevelPausedMessage(bool isPaused)
        {
            IsPaused = isPaused;
        }
    }
}