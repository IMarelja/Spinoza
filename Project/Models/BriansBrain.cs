using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public enum BrainsStatus { On, Dying, Off }
    internal class BrainCell : Cell
    {
        private BrainsStatus _status;
        private int _onNeighbors;
        private Random _random = new();
        public BrainCell(BrainsStatus brainsStatus)
        {
            _status = brainsStatus;
        }
        public override int Print()
        {
            return (int)_status;
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            if (_status == BrainsStatus.On)
            {
                _status = BrainsStatus.Dying;
            }
            else if (_status == BrainsStatus.Dying)
            {
                _status = BrainsStatus.Off;
            }
            else if (_status == BrainsStatus.Off && _onNeighbors == 2)
            {
                _status = BrainsStatus.On;
            }

            _onNeighbors = 0;
        }

        public void setNeighborCount(int onNeighbor)
        {
            _onNeighbors = onNeighbor;
        }

        public BrainsStatus getStatus() => _status;

    }

    public class Brain : Grid
    {
        public override string Name => "Brian's Brain";
        public override string Description => "A cellular automaton simulation where cells cycle through On, Dying, and Off states.";

        private Stack<BrainCell[,]> _history = new Stack<BrainCell[,]>();
        private Stack<BrainCell[,]> _future = new Stack<BrainCell[,]>();
        private BrainCell[,] _currentBrainsInTable;
        private int _rows;
        private int _columns;

        public Brain() { }
        public Brain(int xAxis, int yAxis, int squareDimensions, int numberOfCell)
        {
            _columns = xAxis;
            _rows = yAxis;
            int squareCenterXTopLeft = (_columns / 2) - (squareDimensions / 2);
            int squareCenterYTopLeft = (_rows / 2) - (squareDimensions / 2);
            _currentBrainsInTable = new BrainCell[_columns, _rows];
            Random rand = new Random();

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    _currentBrainsInTable[x, y] = new BrainCell(BrainsStatus.Off);
                }
            }

            while (numberOfCell > 0)
            {
                int x = rand.Next(squareCenterXTopLeft, squareCenterXTopLeft + squareDimensions);
                int y = rand.Next(squareCenterYTopLeft, squareCenterYTopLeft + squareDimensions);
                if (_currentBrainsInTable[x, y].getStatus() != BrainsStatus.On)
                {
                    _currentBrainsInTable[x, y] = new BrainCell(BrainsStatus.On);
                    numberOfCell--;
                }
            }
        }
        public override int[,] BackStep()
        {
            int[,] data = new int[_columns, _rows];

            if (_history.Count() > 0)
            {
                _future.Push(CopyOfBrainCell(_currentBrainsInTable));
                _currentBrainsInTable = _history.Pop();
            }

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    data[x, y] = _currentBrainsInTable[x, y].Print();
                }
            }
            return data;

        }

        public override int[,] NextStep()
        {
            int[,] data = new int[_columns, _rows];

            _history.Push(CopyOfBrainCell(_currentBrainsInTable));

            if (_future.Count() > 0)
            {
                _currentBrainsInTable = _future.Pop();

                for (int y = 0; y < _rows; y++)
                {
                    for (int x = 0; x < _columns; x++)
                    {
                        data[x, y] = _currentBrainsInTable[x, y].Print();
                    }
                }

                return data;
            }
            else
            {
                for (int y = 0; y < _rows; y++)
                {
                    for (int x = 0; x < _columns; x++)
                    {
                        if (_currentBrainsInTable[x,y].getStatus() == BrainsStatus.Off) {
                            // Counting neighbors of Cell
                            int neighborCount = 0;
                            for (int brainY = y - 1; brainY <= y + 1; brainY++)
                            {
                                for (int brainX = x - 1; brainX <= x + 1; brainX++)
                                {
                                    if (brainX == x && brainY == y) continue;
                                    if (brainX < 0 || brainY < 0 || brainX >= _columns || brainY >= _rows) continue;
                                    if (_currentBrainsInTable[brainX, brainY].getStatus() == BrainsStatus.On)
                                    {
                                        neighborCount++;
                                    }
                                }
                            }
                            _currentBrainsInTable[x, y].setNeighborCount(neighborCount);
                        }
                    }
                }

                for (int y = 0; y < _rows; y++)
                {
                    for (int x = 0; x < _columns; x++)
                    {
                        _currentBrainsInTable[x, y].Update();
                    }
                }

                for (int y = 0; y < _rows; y++)
                {
                    for (int x = 0; x < _columns; x++)
                    {
                        data[x, y] = _currentBrainsInTable[x, y].Print();
                    }
                }
                return data;
            }

                
        }

        public void SetCells(int[,] data)
        {
            _rows = data.GetLength(0);
            _columns = data.GetLength(1);
            _history.Clear();
            _future.Clear();
            _currentBrainsInTable = new BrainCell[_columns, _rows];
            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    _currentBrainsInTable[x, y] = new BrainCell((BrainsStatus)data[x,y]);
                }
            }
            
        }

        private BrainCell[,] CopyOfBrainCell(BrainCell[,] original)
        {
            if (original == null)
                return null;

            int rows = original.GetLength(0);
            int cols = original.GetLength(1);

            BrainCell[,] copy = new BrainCell[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (original[i, j] != null)
                    {
                        copy[i, j] = new BrainCell((BrainsStatus)original[i, j].Print());
                    }
                }
            }

            return copy;
        }

        public override int[,] CurrentState()
        {
            int[,] data = new int[_columns, _rows];

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    data[x, y] = _currentBrainsInTable[x, y].Print();
                }
            }

            return data;
        }

        public override string ToString()
        => Name;



        public override string SaveGridToJsonFile()
        {
            int[,] grid = new int[_columns, _rows];

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    grid[y, x] = (int)_currentBrainsInTable[y, x].getStatus();
                }
            }

            var export = new
            {
                GridType = this.GetType().Name,
                Cells = grid
            };

            return JsonConvert.SerializeObject(export, Formatting.Indented);
        }

        public override void ImportGridFromJsonFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var parsed = JsonConvert.DeserializeObject<dynamic>(json);

            string gridType = parsed.GridType;
            if (gridType != this.GetType().Name)
            {
                throw new InvalidOperationException($"GridType mismatch: expected '{this.GetType().Name}', but found '{gridType}'.");
            }

            // Read the cell array
            JArray cellsArray = parsed.Cells;
            _rows = cellsArray.Count();
            _columns = cellsArray[0].Count();

            _currentBrainsInTable = new BrainCell[_rows, _columns];

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    int status = (int)cellsArray[y][x];
                    _currentBrainsInTable[y, x] = new BrainCell((BrainsStatus)status); // Adjust if BrainCell constructor is different
                }
            }

            //var field = typeof(Brain).GetField("_currentBrainsInTable", BindingFlags.NonPublic | BindingFlags.Instance);
            //field.SetValue(this, _currentBrainsInTable);
        }
    }
}
