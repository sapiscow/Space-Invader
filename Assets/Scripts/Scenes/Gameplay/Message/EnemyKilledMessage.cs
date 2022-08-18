namespace Sapi.SpaceInvader.Gameplay
{
    public readonly struct EnemyKilledMessage
    {
        public int X { get; }
        public int Y { get; }

        public EnemyKilledMessage(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}