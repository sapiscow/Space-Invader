namespace Sapi.SpaceInvader.Gameplay
{
    public readonly struct InputMessage
    {
        public int PlayerIndex { get; }
        public InputKey InputKey { get; }

        public InputMessage(int playerIndex, InputKey inputKey)
        {
            PlayerIndex = playerIndex;
            InputKey = inputKey;
        }
    }

    public enum InputKey
    {
        Left,
        Right,
        Shoot
    }
}