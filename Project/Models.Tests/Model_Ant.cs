global using Xunit;
using Moq;
namespace Models.Tests
{
    public class Model_Ant
    {
        private LangtonsGrid _grid;

        [Fact]
        public void Initial_Grid_Has_Ant_At_Center()
        {
            _grid = new LangtonsGrid(3, 3);
            var state = _grid.CurrentState();
            Assert.Equal(2, state[1, 1]); // Center cell should be marked with 2 (ant)
        }

        [Fact]
        public void Ant_Turns_Right_On_White_And_Flips_Cell()
        {
            _grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up); // Ant starts at (1,1)

            var result = _grid.NextStep();

            // The center cell should now be BLACK (1)
            Assert.Equal(1, result[1, 1]); // (x=1, y=1)

            // Ant should move UP and RIGHT turn = RIGHT direction → (x+1, y)
            Assert.Equal(2, result[2, 1]); // Ant now at (2,1)
        }

        [Fact]
        public void Ant_Turns_Left_On_Black_And_Flips_Cell()
        {
            // Arrange: ant starts at center, facing Up
            var grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up);

            // Manually set the cell to BLACK
            var cell = typeof(LangtonsGrid)
                .GetField("_grid", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.GetValue(grid) as LangtonsCell[,];
            cell[1, 1].SetStatus(AntStatus.Black);

            // Act
            var result = grid.NextStep();

            // Assert: cell (1,1) should now be white (0)
            Assert.Equal(0, result[1, 1]);

            // Ant was facing Up, turned LEFT (black cell), moved to (0,1)
            Assert.Equal(2, result[0, 1]);
        }

        [Fact]
        public void Undo_BackStep_Reverses_Ant_Move_And_Cell_Flip()
        {
            _grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up);

            var initial = _grid.CurrentState();
            var afterStep = _grid.NextStep();
            var afterUndo = _grid.BackStep();

            Assert.Equal(initial, afterUndo); // Should be same as start
        }

        [Fact]
        public void Full_Cycle_Of_Steps_And_BackSteps_Match()
        {
            _grid = new LangtonsGrid(3, 3, 1, 1, Direction.Up);
            var initial = _grid.CurrentState();

            _grid.NextStep();
            _grid.NextStep();
            _grid.NextStep();

            _grid.BackStep();
            _grid.BackStep();
            _grid.BackStep();

            var final = _grid.CurrentState();

            Assert.Equal(initial, final); // Grid should match original
        }
        
    }
}

