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



        //get status, change direction, 

        public override int[,] BackStep()
        {
            throw new NotImplementedException();
        }

        public override int[,] NextStep()
        {
            throw new NotImplementedException();
        }
    }
}
