using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tests
{
    public class Models_Brain
    {
        private Brain _brain;

        private int[,] emptyCellTable =
        { 
            { (int)BrainsStatus.Off , (int)BrainsStatus.Off, (int)BrainsStatus.Off, (int)BrainsStatus.Off },
            { (int)BrainsStatus.Off , (int)BrainsStatus.Off, (int)BrainsStatus.Off, (int)BrainsStatus.Off },
            { (int)BrainsStatus.Off , (int)BrainsStatus.Off, (int)BrainsStatus.Off, (int)BrainsStatus.Off },
            { (int)BrainsStatus.Off , (int)BrainsStatus.Off, (int)BrainsStatus.Off, (int)BrainsStatus.Off }
        };


        /*
         * - Brians Brain wiki test -
         * https://en.wikipedia.org/wiki/Brian%27s_Brain
         * On = 🔳
         * Dying = 💀
         * Off = ❎
         */

        /*
        ❎🔳💀❎
        💀❎❎🔳
        🔳❎❎💀
        ❎💀🔳❎
         */
        private int[,] brainstateCellTable_CircleTest0_1 =
        {
            { (int)BrainsStatus.Off , (int)BrainsStatus.On, (int)BrainsStatus.Dying, (int)BrainsStatus.Off },
            { (int)BrainsStatus.Dying , (int)BrainsStatus.Off, (int)BrainsStatus.Off, (int)BrainsStatus.On },
            { (int)BrainsStatus.On , (int)BrainsStatus.Off, (int)BrainsStatus.Off, (int)BrainsStatus.Dying },
            { (int)BrainsStatus.Off , (int)BrainsStatus.Dying, (int)BrainsStatus.On, (int)BrainsStatus.Off }
        };
        /*
        ❎💀❎❎
        ❎🔳🔳💀
        💀🔳🔳❎
        ❎❎💀❎
         */
        private int[,] brainstateCellTable_CircleTest0_2 =
        {
            { (int)BrainsStatus.Off , (int)BrainsStatus.Dying, (int)BrainsStatus.Off, (int)BrainsStatus.Off },
            { (int)BrainsStatus.Off , (int)BrainsStatus.On, (int)BrainsStatus.On, (int)BrainsStatus.Dying },
            { (int)BrainsStatus.Dying , (int)BrainsStatus.On, (int)BrainsStatus.On, (int)BrainsStatus.Off },
            { (int)BrainsStatus.Off , (int)BrainsStatus.Off, (int)BrainsStatus.Dying, (int)BrainsStatus.Off }
        };
        /*
        ❎❎🔳❎
        🔳💀💀❎
        ❎💀💀🔳
        ❎🔳❎❎
         */
        private int[,] brainstateCellTable_CircleTest0_3 =
        {
            { (int)BrainsStatus.Off , (int)BrainsStatus.Off, (int)BrainsStatus.On, (int)BrainsStatus.Off },
            { (int)BrainsStatus.On , (int)BrainsStatus.Dying, (int)BrainsStatus.Dying, (int)BrainsStatus.Off },
            { (int)BrainsStatus.Off , (int)BrainsStatus.Dying, (int)BrainsStatus.Dying, (int)BrainsStatus.On },
            { (int)BrainsStatus.Off , (int)BrainsStatus.On, (int)BrainsStatus.Dying, (int)BrainsStatus.Off }
        };

        [Fact]
        public void Update_BrainGeneration_CircleTest0_1to2()
        {
            _brain = new Brain(4, 4, 0, 0);
            _brain.SetCells(brainstateCellTable_CircleTest0_1);
            int[,] result = _brain.NextStep();
            Assert.Equal(brainstateCellTable_CircleTest0_2, result);
        }

        [Fact]
        public void Update_BrainGeneration_CircleTest0_2to3()
        {
            _brain = new Brain(4, 4, 0, 0);
            _brain.SetCells(brainstateCellTable_CircleTest0_2);
            int[,] result = _brain.NextStep();
            Assert.Equal(brainstateCellTable_CircleTest0_3, result);
        }

        [Fact]
        public void Update_BrainGeneration_CircleTest0_3to1()
        {
            _brain = new Brain(4, 4, 0, 0);
            _brain.SetCells(brainstateCellTable_CircleTest0_3);
            int[,] result = _brain.NextStep();
            Assert.Equal(brainstateCellTable_CircleTest0_1, result);
        }

        [Fact]
        public void Update_BrainGeneration_CircleTest0_1BackTo3()
        {
            _brain = new Brain(4, 4, 0, 0);
            _brain.SetCells(brainstateCellTable_CircleTest0_1);
            int[,] result = _brain.BackStep();
            Assert.Equal(brainstateCellTable_CircleTest0_3, result);
        }

        [Fact]
        public void Update_BrainGeneration_CircleTest0_FullCircle()
        {
            _brain = new Brain(4, 4, 0, 0);
            _brain.SetCells(brainstateCellTable_CircleTest0_1);

            int[,] result1 = _brain.NextStep();
            Assert.Equal(brainstateCellTable_CircleTest0_2, result1);

            int[,] result2 = _brain.NextStep();
            Assert.Equal(brainstateCellTable_CircleTest0_3, result2);

            int[,] result3 = _brain.NextStep();
            Assert.Equal(brainstateCellTable_CircleTest0_1, result3);
        }

    }
}
