using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum ForestStatus { Empty, Tree, Burning}

    internal class TreeCell : Cell
    {
        private ForestStatus _previousStatus;
        private ForestStatus _status;
        private ForestStatus _nextStatus;
        private int _p;
        private int _f;
        private Random _random = new();

        public TreeCell(int p, int f)
        {
            _status = ForestStatus.Tree;
            _nextStatus = _status;
            _p = p;
            _f = f;

        }
        //calculates next status
        public override void Update()
        {
            _previousStatus = _status;
            _status = _nextStatus;
            if (_status == ForestStatus.Burning)
                _nextStatus = ForestStatus.Empty;
            if (_status == ForestStatus.Empty && ProbabilityCalculation(_p))
                _nextStatus = ForestStatus.Tree;
            if (_status == ForestStatus.Tree && ProbabilityCalculation(_f))
                _nextStatus = ForestStatus.Burning;
        }

        //probably needs adjusting
        //calculates previous status
        public override void Undo()
        {
            _nextStatus = _status ;
            _status = _previousStatus;
            if (_status == ForestStatus.Burning)
                _previousStatus = ForestStatus.Tree;
            if (_status == ForestStatus.Tree && ProbabilityCalculation(_p))
                _previousStatus = ForestStatus.Empty;
            if (_status == ForestStatus.Empty && ProbabilityCalculation(_f))
                _previousStatus = ForestStatus.Burning;
        }

        //check if cell next to is burning
        public void Compare(TreeCell other)
        {
            if (_status == ForestStatus.Tree && other._status == ForestStatus.Burning)
                _nextStatus = ForestStatus.Burning;
        }

        //reusable within cell
        private bool ProbabilityCalculation(int n)
        {
            if (_random.Next(1, 101) <= n)
                return true;
            return false;
        }

        //returns the value of the status
        public override int Print()
        {
            return (int)_status;
        }
    }


    public class Forest : Grid
    {
        private TreeCell[,] _table;
        private int _rows;
        private int _columns;
        
        //intialises row and columns and saves probability to cells
        public Forest(int xAxis, int yAxis, int p, int f)
        {
            _columns = xAxis;
            _rows = yAxis;
            _table = new TreeCell[_columns, _rows];
            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    _table[x, y] = new TreeCell(p, f);
                }
            }
        }

        //definately needs adjusting
        public override Cell[,] BackStep()
        {
            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    _table[x, y].Update();
                }
            }
            return _table;
        }

        //returns next state of all cells
        public override Cell[,] NextStep()
        {
            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    if (x != 0)
                        _table[x, y].Compare(_table[x - 1, y]);
                    if (x != _columns - 1)
                        _table[x, y].Compare(_table[x + 1, y]);
                    if (y != _rows - 1)
                        _table[x, y].Compare(_table[x, y + 1]);
                    if (y != 0)
                        _table[x, y].Compare(_table[x, y - 1]);
                    
                }
            }
            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _columns; x++)
                {
                    _table[x, y].Update();
                }
            }
            return _table;
        }
    }

}
