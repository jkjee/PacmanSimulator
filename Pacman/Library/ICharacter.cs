using System;

namespace PacmanSimulator.Library
{
    public enum CharacterType
    {
        Packman
    }

    public enum MovementWay
    {
        Up,
        Down,
        Left,
        Right
    }

    public interface ICharacter : IDisposable
    {
        int Speed { get; set; }
        CharacterType Type { get; }
        void Place(MovementWay way);
    }
}
