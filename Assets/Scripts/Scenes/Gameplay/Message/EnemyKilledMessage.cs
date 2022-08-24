namespace Sapi.SpaceInvader.Gameplay
{
    public readonly struct EnemyKilledMessage
    {
        public int X { get; }
        public int Y { get; }
        public int ScoreValue { get; }

        public EnemyKilledMessage(int x, int y, int scoreValue)
        {
            X = x;
            Y = y;
            ScoreValue = scoreValue;
        }
    }
}