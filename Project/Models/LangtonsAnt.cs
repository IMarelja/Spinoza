using System;
using System.Collections.Generic;

namespace Models
{
    public enum AntStatus { White, Black }

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
            _previousStatus = _status;
            _status = status;
        }
    }

    public enum Direction { Up, Right, Down, Left }


    public class LangtonsGrid : Grid
    {
        public override string Name => "Langtons Ant";
        public override string Description => "Description here";

        private LangtonsCell[,] _grid;
        private int _rows;
        private int _cols;

        private int _antX;
        private int _antY;
        private Direction _antDirection;

        private Stack<(int, int, Direction, AntStatus)> _history = new();

        public LangtonsGrid() { }

        // Updated constructor with optional parameters for ant position and direction
        public LangtonsGrid(int width, int height, int? antStartX = null, int? antStartY = null, Direction? antStartDirection = null)
        {
            _cols = width;
            _rows = height;
            _grid = new LangtonsCell[_cols, _rows];

            for (int y = 0; y < _rows; y++)
                for (int x = 0; x < _cols; x++)
                    _grid[x, y] = new LangtonsCell();

            // Set ant initial position or default to center
            _antX = antStartX ?? (_cols / 2);
            _antY = antStartY ?? (_rows / 2);

            // Clamp position to grid bounds just in case
            _antX = Math.Max(0, Math.Min(_antX, _cols - 1));
            _antY = Math.Max(0, Math.Min(_antY, _rows - 1));

            // Set initial direction or default to Up
            _antDirection = antStartDirection ?? Direction.Up;
        }

        public override int[,] NextStep()
        {
            var currentCell = _grid[_antX, _antY];
            AntStatus currentStatus = currentCell.GetStatus();

            _history.Push((_antX, _antY, _antDirection, currentStatus));

            _antDirection = currentStatus == AntStatus.White
                ? TurnRight(_antDirection)
                : TurnLeft(_antDirection);

            currentCell.Update();

            (_antX, _antY) = MoveForward(_antX, _antY, _antDirection);

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
            {
                for (int x = 0; x < _cols; x++)
                {
                    data[x, y] = _grid[x, y].Print(); // 0 = white, 1 = black
                }
            }

            // Mark ant's cell with 2 (for example, can be rendered as red)
            data[_antX, _antY] = 2;
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
                case Direction.Up: y--; break;
                case Direction.Down: y++; break;
                case Direction.Left: x--; break;
                case Direction.Right: x++; break;
            }
            return (x, y);
        }

        public override int[,] CurrentState()
        {
            return RenderGrid();
        }

        public override string ToString()
        => Name;
    }
}
