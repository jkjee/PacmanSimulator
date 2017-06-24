using System;

namespace PacmanSimulator.Library
{
    public interface IBlock : IDisposable
    {
        System.Drawing.Color BlockColor { get; set; }
    }
}
