global using Xunit;
using Moq;
namespace Models.Tests
{
    public class Model_Ant
    {
        private LangtonsGrid _grid;


        [Fact]
        public void Initial_State_Is_White_Cell_And_Ant_In_Center()
        {
            _grid = new LangtonsGrid(3, 3);
            var state = _grid.CurrentState();

            // All cells white = 0, ant marked as 2
            // Ant should be in center at (1,1)
            Assert.Equal(0, state[0, 0]);
            Assert.Equal(0, state[2, 2]);
            Assert.Equal(2, state[1, 1]);
        }

        [Fact]
        public void NextStep_AntFlipsCell_And_Moves_Right_When_OnWhite()
        {
            _grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up);

            // The cell at (1,1) initially white = 0
            var before = _grid.CurrentState();
            Assert.Equal(0, before[1, 1]);

            var after = _grid.NextStep();

            // After step:
            // The cell at (1,1) flips to black (1)
            Assert.Equal(1, after[1, 1]);

            // Ant should have turned right (Up -> Right) and moved one cell right to (2,1)
            Assert.Equal(2, after[2, 1]); // Ant cell marked with 2
            Assert.NotEqual(2, after[1, 1]); // Ant no longer here
        }

        [Fact]
        public void NextStep_AntFlipsCell_And_Moves_Left_When_OnBlack()
        {
            _grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up);

            // Manually set cell (1,1) to black so ant is on black cell
            _grid.BackStep(); // to clear history if any
            var cellField = typeof(LangtonsGrid).GetField("_grid", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var gridArray = (LangtonsCell[,])cellField.GetValue(_grid);
            gridArray[1, 1].SetStatus(AntStatus.Black);

            var before = _grid.CurrentState();
            Assert.Equal(1, before[1, 1]);

            var after = _grid.NextStep();

            // On black, ant turns left (Up -> Left) and flips cell to white (0)
            Assert.Equal(0, after[1, 1]);

            // Ant moved left to (0,1)
            Assert.Equal(2, after[0, 1]);
        }

        [Fact]
        public void BackStep_Reverts_Last_Step()
        {
            _grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up);

            var state1 = _grid.CurrentState();
            var state2 = _grid.NextStep();

            // Ensure states are different
            Assert.NotEqual(state1[1, 1], state2[1, 1]);

            var backState = _grid.BackStep();

            // BackStep returns to original state
            Assert.Equal(state1[1, 1], backState[1, 1]);
            Assert.Equal(state1[1, 1], backState[1, 1]);
            Assert.Equal(state1[1, 1], backState[1, 1]);
        }

        [Fact]
        public void BackStep_With_No_History_Returns_CurrentState()
        {
            _grid = new LangtonsGrid(3, 3);

            var before = _grid.CurrentState();
            var back = _grid.BackStep();

            // With no history BackStep should return same grid state
            Assert.Equal(before, back);
        }

        [Fact]
        public void Ant_Does_Not_Move_Outside_Bounds()
        {
            // Ant start at top-left corner facing Up
            _grid = new LangtonsGrid(3, 3, 0, 0, Direction.Up);

            var after = _grid.NextStep();

            // Ant tries to move up from (0,0) but clamped to (0,0)
            Assert.Equal(2, after[0, 0]);
        }
    }
}
