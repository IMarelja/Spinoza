using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum AntStatus { White, Black }
    public class LangtonsCell : Cell
    {
        private AntStatus _status;
        private AntStatus _previousStatus;

        public LangtonsCell()
        {
            _status = AntStatus.White;
            _previousStatus = _status;
        }

        public override void Update()
        {
            _previousStatus = _status;
            _status = _status == AntStatus.White ? AntStatus.Black : AntStatus.White;
        }

        public override void Undo()
        {
            _status = _previousStatus;
        }

        public override int Print()
        {
            return _status == AntStatus.White ? 0 : 1;
        }

        internal AntStatus GetStatus()
        {
            return _status;
        }

        internal void SetStatus(AntStatus status)
        {
            _status = status;
        }
    }

    enum Direction { Up, Right, Down, Left }

    public class LangtonsGrid : Grid
    {
        private LangtonsCell[,] _grid;
        private int _rows;
        private int _cols;

        private int _antX; //possition of ant 
        private int _antY;
        private Direction _antDirection;


        // To save what happened
        private Stack<(int, int, Direction, AntStatus)> _history = new();

        public LangtonsGrid(int width, int height) //Initialise the grid
        {
            _cols = width;
            _rows = height;
            _grid = new LangtonsCell[_cols, _rows];

            for (int y = 0; y < _rows; y++)
                for (int x = 0; x < _cols; x++)
                    _grid[x, y] = new LangtonsCell();

            // Ant set in center facing up
            _antX = _cols / 2;
            _antY = _rows / 2;
            _antDirection = Direction.Up;

        }


        public override int[,] NextStep()
        {
            int[,] output = new int[_cols, _rows];

            var currentCell = _grid[_antX, _antY];
            AntStatus currentStatus = currentCell.GetStatus();

            // Save before step
            _history.Push((_antX, _antY, _antDirection, currentStatus));

            // Turn
            _antDirection = currentStatus == AntStatus.White
                ? TurnRight(_antDirection)
                : TurnLeft(_antDirection);

            // Flip color
            currentCell.Update();

            // Move ant
            (_antX, _antY) = MoveForward(_antX, _antY, _antDirection);

            // Clamp ant inside bounds
            _antX = Math.Max(0, Math.Min(_antX, _cols - 1));
            _antY = Math.Max(0, Math.Min(_antY, _rows - 1));

            return RenderGrid();
        }

        public override int[,] BackStep()
        {
            if (_history.Count == 0) return RenderGrid();

            var (prevX, prevY, prevDir, prevStatus) = _history.Pop();

            _grid[prevX, prevY].SetStatus(prevStatus);
            _antX = prevX;
            _antY = prevY;
            _antDirection = prevDir;

            return RenderGrid();
        }

        private int[,] RenderGrid()
        {
            int[,] data = new int[_cols, _rows];
            for (int y = 0; y < _rows; y++)
                for (int x = 0; x < _cols; x++)
                    data[x, y] = _grid[x, y].Print();

            // Optional: mark ant position (-1)
            data[_antX, _antY] = -1;
            return data;
        }

        private Direction TurnRight(Direction direction)
        {
            return (Direction)(((int)direction + 1) % 4);
        }

        private Direction TurnLeft(Direction direction)
        {
            return (Direction)(((int)direction + 3) % 4);
        }

        private (int x, int y) MoveForward(int x, int y, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    y = y - 1;
                    break;
                case Direction.Down:
                    y = y + 1;
                    break;
                case Direction.Left:
                    x = x - 1;
                    break;
                case Direction.Right:
                    x = x + 1;
                    break;
            }
            return (x, y);
        }
    }
}
