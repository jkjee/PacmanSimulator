using System.Drawing;
using System.Windows.Forms;

namespace PacmanSimulator.Library
{
    public sealed class Block : Control, IBlock
    {
        public Block()
        {
            BackColor = BlockColor;
        }

        public Block(int width, int height)
            : this()
        {
            Width = width;
            Height = height;
        }

        public Block(int width, int height, Point location)
            : this(width, height)
        {
            Location = location;
        }

        Color _mBlockColor = Color.OrangeRed;
        public Color BlockColor
        {
            get
            {
                return _mBlockColor;
            }
            set
            {
                _mBlockColor = value;
            }
        }
    }
}
