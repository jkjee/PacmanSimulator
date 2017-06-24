using System.Drawing;

namespace PacmanSimulator.Library
{
    public static class PacmanExtensions
    {
        public static string ToText(this Point point, MovementWay direction)
        {
            switch (direction)
            {
                case MovementWay.Up:
                    return $"Output : {(point.X / 20) - 1}, {(point.Y / 20) - 1}, North";
                case MovementWay.Down:
                    return $"Output : {(point.X / 20) - 1}, {(point.Y / 20) - 1}, South";
                case MovementWay.Right:
                    return $"Output : {(point.X / 20) - 1}, {(point.Y / 20) - 1}, East";
                case MovementWay.Left:
                    return $"Output : {(point.X / 20) - 1}, {(point.Y / 20) - 1}, West";
            }
            return string.Empty;
        }
    }
}
