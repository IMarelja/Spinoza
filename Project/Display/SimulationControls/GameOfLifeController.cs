using Display.Utilities;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Display
{
    public partial class GameOfLifeController : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Life _simulation;
        private System.Windows.Forms.Timer _timer;
        private int _cellSize = 15;

        public Life Simulation
        {
            get => _simulation;
            set
            {
                _simulation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Simulation)));
                Invalidate();
            }
        }

        public GameOfLifeController()
        {
            InitializeComponent();
            DoubleBuffered = true;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 250;
            _timer.Tick += (s, e) => Advance();
        }

        public void InitializeGrid(int cols, int rows, int seedCells = 100)
        {
            Simulation = new Life(cols, rows, seedCells);
            Width = cols * _cellSize + 1;
            Height = rows * _cellSize + 1;
        }

        public void Advance()
        {
            if (Simulation == null) return;
            Simulation.NextStep();
            Invalidate();
        }

        public void Back()
        {
            if (Simulation == null) return;
            Simulation.BackStep();
            Invalidate();
        }

        public void Start() => _timer.Start();
        public void Pause() => _timer.Stop();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Simulation == null) return;

            var g = e.Graphics;
            var state = Simulation.CurrentState();

            for (int y = 0; y < state.GetLength(1); y++)
            {
                for (int x = 0; x < state.GetLength(0); x++)
                {
                    var rect = new Rectangle(x * _cellSize, y * _cellSize, _cellSize, _cellSize);
                    g.FillRectangle(state[x, y] == 1 ? Brushes.Black : Brushes.White, rect);
                    g.DrawRectangle(Pens.LightGray, rect);
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (Simulation == null) return;

            int x = e.X / _cellSize;
            int y = e.Y / _cellSize;

            var current = Simulation.CurrentState();

            if (x < current.GetLength(0) && y < current.GetLength(1))
            {
                var newModel = new Life(current.GetLength(0), current.GetLength(1), 0);
                var newGrid = Simulation.CurrentState();

                for (int j = 0; j < newGrid.GetLength(1); j++)
                    for (int i = 0; i < newGrid.GetLength(0); i++)
                        if (i != x || j != y)
                            newModel.NextStep(); // or assign manually if needed

                newModel = new Life(current.GetLength(0), current.GetLength(1), 0);
                for (int i = 0; i < current.GetLength(0); i++)
                    for (int j = 0; j < current.GetLength(1); j++)
                        newModel.NextStep();

                Invalidate();
            }
        }
    }
}
