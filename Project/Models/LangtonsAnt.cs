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
        public override int Print()
        {
            throw new NotImplementedException();
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class LangtonsGrid : Grid
    {
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
