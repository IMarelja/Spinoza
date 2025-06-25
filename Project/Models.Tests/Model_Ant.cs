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
        public void NextStep_AntFlipsCell_And_Moves_Right_When_OnWhite() //error
        {
            var grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up); // Centered

            var before = grid.CurrentState();
            Assert.Equal(0, before[1, 1]); // Cell is white

            grid.NextStep();

            var after = grid.CurrentState();

            // (1,1) should now be black: 1
            Assert.Equal(1, after[1, 1]);

            // Ant should now be at (2,1) since it turns right and moves right from Up
            Assert.Equal(2, after[2, 1]);
        }

        [Fact]
        public void NextStep_AntFlipsCell_And_Moves_Left_When_OnBlack() //failed Test
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
        public void Ant_Does_Not_Move_Outside_Bounds() //failed Test
        {
            // Ant start at top-left corner facing Up
            _grid = new LangtonsGrid(3, 3, 0, 0, Direction.Up);

            var after = _grid.NextStep();

            // Ant tries to move up from (0,0) but clamped to (0,0)
            Assert.Equal(2, after[0, 0]);
        }
    }
}
