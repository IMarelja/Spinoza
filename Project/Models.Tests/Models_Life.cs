using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Xunit;

namespace Models.Tests
{
    public class Models_Life
    {
        private Life _life;

        private int[,] blinker1 =
        {
            { 0, 0, 0 },
            { 1, 1, 1 },
            { 0, 0, 0 }
        };

        private int[,] blinker2 =
        {
            { 0, 1, 0 },
            { 0, 1, 0 },
            { 0, 1, 0 }
        };

        private int[,] block =
        {
            { 0, 0, 0, 0 },
            { 0, 1, 1, 0 },
            { 0, 1, 1, 0 },
            { 0, 0, 0, 0 }
        };

        private int[,] beacon1 =
        {
            { 1, 1, 0, 0 },
            { 1, 1, 0, 0 },
            { 0, 0, 1, 1 },
            { 0, 0, 1, 1 }
        };

        private int[,] beacon2 =
        {
            { 1, 1, 0, 0 },
            { 1, 0, 0, 0 },
            { 0, 0, 0, 1 },
            { 0, 0, 1, 1 }
        };

        [Fact]
        public void Test_BlinkerOscillator()
        {
            _life = new Life(3, 3, 0);
            _life.SetCells(blinker1);

            var next = _life.NextStep();
            Assert.Equal(blinker2, next);

            var back = _life.NextStep();
            Assert.Equal(blinker1, back);
        }

        [Fact]
        public void Test_BlockStillLife()
        {
            _life = new Life(4, 4, 0);
            _life.SetCells(block);

            var next = _life.NextStep();
            Assert.Equal(block, next);
        }

        
        [Fact]
        public void Test_BeaconOscillator()
        {
            _life = new Life(4, 4, 0);
            _life.SetCells(beacon1);

            var next = _life.NextStep();
            Assert.Equal(beacon2, next);

            var next2 = _life.NextStep();
            Assert.Equal(beacon1, next2);
        }

        [Fact]
        public void Test_UndoBackStep()
        {
            _life = new Life(3, 3, 0);
            _life.SetCells(blinker1);
            _life.NextStep(); 

            var back = _life.BackStep(); 
            Assert.Equal(blinker1, back);
        }

        [Fact]
        public void Test_BlinkerCycleFull()
        {
            _life = new Life(3, 3, 0);
            _life.SetCells(blinker1);

            _life.NextStep(); 
            _life.NextStep();
            var result = _life.CurrentState();

            Assert.Equal(blinker1, result);
        }
    }

}
