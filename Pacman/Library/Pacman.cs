using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PacmanSimulator.Library
{
    public class Pacman : Control, ICharacter
    {
        private readonly Block[] _blocks;

        private bool _catched = false;

        public Pacman()
        {
            Width = Height = 40;
        }
        public Pacman(ref Block[] blocks)
            : this()
        {
            _blocks = blocks;
        }

        private bool IsBlock()
        {
            var result = false;
            
            var loc = new Point
            {
                X = Location.X,
                Y = Location.Y
            };

            if (_movement == MovementWay.Right)
                loc.X += Width;

            for (int i = 0; i <= _blocks.Length - 1; i++)
            {
                if (_blocks[i] == null)
                    continue;

                switch (_movement)
                {
                    case MovementWay.Right:
                        if (loc.X == _blocks[i].Location.X)
                        {
                            if (loc.Y >= (_blocks[i].Location.Y - Speed) && loc.Y <= (_blocks[i].Location.Y + _blocks[i].Height - Speed))
                            {
                                result = true;
                            }
                        }
                        break;
                    case MovementWay.Left:
                        if (loc.X == (_blocks[i].Location.X + _blocks[i].Width))
                        {
                            if (loc.Y >= (_blocks[i].Location.Y - Speed) && loc.Y <= (_blocks[i].Location.Y + _blocks[i].Height - Speed))
                            {
                                result = true;
                            }
                        }
                        break;

                    case MovementWay.Up:
                        if (loc.Y == (_blocks[i].Location.Y + _blocks[i].Height))
                        {
                            if (loc.X >= (_blocks[i].Location.X - Speed) && loc.X <= (_blocks[i].Location.X + _blocks[i].Width - Speed))
                            {
                                result = true;
                            }
                        }
                        break;

                    case MovementWay.Down:
                        if ((loc.Y + Height) == _blocks[i].Location.Y)
                        {
                            if (loc.X >= (_blocks[i].Location.X - Speed) && loc.X <= (_blocks[i].Location.X + _blocks[i].Width - Speed))
                            {
                                result = true;
                            }
                        }
                        break;
                }




            }

            return result;
        }

        private void FillRegion()
        {

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);

            switch (_movement)
            {
                case MovementWay.Right:
                    path.AddPie(0, 0, Width, Height, 310, 100);
                    break;

                case MovementWay.Left:
                    path.AddPie(0, 0, Width, Height, 130, 100);
                    break;

                case MovementWay.Up:
                    path.AddPie(0, 0, Width, Height, 220, 100);
                    break;

                case MovementWay.Down:
                    path.AddPie(0, 0, Width, Height, 40, 100);
                    break;
            }

            Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawCharacter.Draw(ref e, Type, _movement);

            FillRegion();

            base.OnPaint(e);
        }

        private MovementWay _movement = MovementWay.Right;

        public CharacterType Type { get; } = CharacterType.Packman;

        public int Speed { get; set; } = 20;

        public void Place(MovementWay way)
        {
            if (_catched)
                return;

            _movement = way;

            OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));

            if (!IsBlock())
                switch (way)
                {
                    case MovementWay.Up:
                        Location = new Point(Location.X, Location.Y);
                        break;

                    case MovementWay.Down:
                        Location = new Point(Location.X, Location.Y);
                        break;

                    case MovementWay.Left:
                        Location = new Point(Location.X, Location.Y);
                        break;

                    case MovementWay.Right:
                        Location = new Point(Location.X, Location.Y);
                        break;
                }
        }
    }
}
