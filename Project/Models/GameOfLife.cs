using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models
{
    public enum LifeStatus
    {
        Dead = 0,
        Alive = 1
    }

    internal class LifeCell : Cell
    {
        // current state
        private LifeStatus _status;
        private int _liveNeighbors;

        public LifeCell(LifeStatus status)
        {
            _status = status;
        }

        public override int Print() => (int)_status;

        public override void Undo()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            if (_status == LifeStatus.Alive)
                // stay alive if it has 2 or 3 neighbors, die otherwise
                _status = (_liveNeighbors == 2 || _liveNeighbors == 3) ? LifeStatus.Alive : LifeStatus.Dead;
            else
                // become alive if it has 3 neighbors
                _status = (_liveNeighbors == 3) ? LifeStatus.Alive : LifeStatus.Dead;
            // reset neighbor count to 0
           _liveNeighbors = 0;
        }

        // store neighbor count before updatinng
        public void SetNeighborCount(int count) => _liveNeighbors = count;

        public LifeStatus Status => _status;  
    }

    // represents simulation and grid
    public class Life : Grid
    {
        public override string Name => "Conway's Game of Life";
        public override string Description => "A cellular automaton where cells live or die based on their neighbors.";

        private LifeCell[,] _grid; // 2d array holding current cells
        private readonly Stack<LifeCell[,]> _history = new(); // stack to be able to undo.
        private readonly Stack<LifeCell[,]> _future = new(); // stack to redo.

        private readonly int _rows;
        private readonly int _columns;

        public Life() { }

        public Life(int width, int height, int seedCells)
        {
            _columns = width;
            _rows = height;
            _grid = new LifeCell[_columns, _rows];
            Random rand = new Random();

            for (int y = 0; y < _rows; y++)
                for (int x = 0; x < _columns; x++)
                    _grid[x, y] = new LifeCell(LifeStatus.Dead);

            while (seedCells > 0)
            {
                int x = rand.Next(_columns);
                int y = rand.Next(_rows);
                if (_grid[x, y].Status != LifeStatus.Alive)
                {
                    _grid[x, y] = new LifeCell(LifeStatus.Alive);
                    seedCells--;
                }
            }
        }

        public override int[,] BackStep()
        {
            // pop the last state from _history and pushes current state to future
            if (_history.Count == 0) return CurrentState();
            _future.Push(CloneGrid(_grid));
            _grid = _history.Pop();
            return CurrentState();
        }

        public override int[,] CurrentState()
        {
            // return a 2D array of the current grid for display or logging
            var state = new int[_columns, _rows];
            for (int y = 0; y < _rows; y++)
                for (int x = 0; x < _columns; x++)
                    state[x, y] = _grid[x, y].Print();
            return state;
        }

        public override int[,] NextStep()
        {
            // saves current grid to history, undo feature
            _history.Push(CloneGrid(_grid));
            _future.Clear();
            var data = new int[_columns, _rows];

            // count neighbors
            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    int count = 0;
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        for (int dx = -1; dx <= 1; dx++)
                        {
                            int nx = x + dx, ny = y + dy;
                            if (dx == 0 && dy == 0) continue;
                            if (nx < 0 || ny < 0 || nx >= _columns || ny >= _rows) continue;

                            if (_grid[nx, ny].Status == LifeStatus.Alive)
                                count++;
                        }
                    }
                    _grid[x, y].SetNeighborCount(count);
                }
            }

            // update cells
            for (int y = 0; y < _rows; y++)
                for (int x = 0; x < _columns; x++)
                {
                    _grid[x, y].Update();
                    data[x, y] = _grid[x, y].Print();
                }

            return data;
        }

        private LifeCell[,] CloneGrid(LifeCell[,] source)
        {
            int w = source.GetLength(0), h = source.GetLength(1);
            var copy = new LifeCell[w, h];
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                    copy[x, y] = new LifeCell(source[x, y].Status);
            return copy;
        }

        // setcells
        public void SetCells(int[,] state)
        {
            for (int y = 0; y < _rows; y++)
                for (int x = 0; x < _columns; x++)
                    _grid[x, y] = new LifeCell((LifeStatus)state[x, y]);
        }


        // name of display in UI
        public override string ToString() => Name;

        public override string SaveGridToJsonFile()
        {
            throw new NotImplementedException();
        }

        public override void ImportGridFromJsonFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
