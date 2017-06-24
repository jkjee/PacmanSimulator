using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PacmanSimulator.Library;

namespace PacmanSimulator
{
    public partial class PacmanPlay : Form
    {

        private Block[] _blocks = new Block[4];
        private Pacman _pack;
        private MovementWay _direction;
        private int _currentX;
        private int _currentY;
        public PacmanPlay()
        {
            InitializeComponent();

            PacmanGroupBox.Controls.Clear();
            PacmanGroupBox.Refresh();

            GameInitialization();
        }

        void GameInitialization()
        {
            LoadBlocks();
            _pack = new Pacman(ref _blocks) {Location = new Point(40, 40)};
            _currentX = 40;
            _currentY = 40;
            _direction = MovementWay.Right;

            PacmanGroupBox.Controls.Add(_pack);
            lblReport.Text = _pack.Location.ToText(MovementWay.Right);

            var directions = new[] {
                new { Name = "NORTH", Direction = MovementWay.Up},
                new { Name = "SOUTH", Direction = MovementWay.Down},
                new { Name = "EAST", Direction = MovementWay.Right},
                new { Name = "WEST", Direction = MovementWay.Left}
            }.ToList();

            ddlDirection.DataSource = directions;
            ddlDirection.DisplayMember = "Name";
            ddlDirection.ValueMember = "Direction";
            ddlDirection.SelectedIndex = 2;

            
        }

        void LoadBlocks()
        {
            Block top = new Block(125, 5, new Point(35, 35));
            Block left = new Block(5, 125, new Point(35, 35));
            Block right = new Block(5, 130, new Point(160, 35));
            Block down = new Block(125, 5, new Point(35, 160));
            
            _blocks[0] = top;
            _blocks[1] = left;
            _blocks[2] = down;
            _blocks[3] = right;

            // ReSharper disable once CoVariantArrayConversion
            PacmanGroupBox.Controls.AddRange(_blocks);
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            _currentX = Convert.ToInt32((updownX.Value + 1) * 20);
            _currentY = Convert.ToInt32((updownY.Value + 1) * 20);
            _direction = (MovementWay) Enum.Parse(typeof(MovementWay), ddlDirection.SelectedValue.ToString());
            PlacePackman();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            switch (_direction)
            {
                case MovementWay.Up:
                    _currentY -= 20;
                    if (_currentY < 40) _currentY = 40;
                    break;
                case MovementWay.Down:
                    _currentY += 20;
                    if (_currentY > 120) _currentY = 120;
                    break;
                case MovementWay.Right:
                    _currentX += 20;
                    if (_currentX > 120) _currentX = 120;
                    break;
                case MovementWay.Left:
                    _currentX -= 20;
                    if (_currentX < 40) _currentX = 40;
                    break;
            }
            PlacePackman();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _direction = MovementWay.Left;
            PlacePackman();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _direction = MovementWay.Right;
            PlacePackman();
        }

        private void PlacePackman()
        {
            _pack.Location = new Point(_currentX, _currentY);
            _pack.Place(_direction);
            lblReport.Text = _pack.Location.ToText(_direction);
        }
    }
}
    