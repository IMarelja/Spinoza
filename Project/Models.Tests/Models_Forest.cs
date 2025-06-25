global using Xunit;
using Moq;
namespace Models.Tests
{
    public class Models_Forest
    {
        private Forest _forest;

        private int[,] _empty = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        private int[,] _trees = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        private int[,] _fires = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
        private int[,] _fireCenter = { { 1, 1, 1 }, { 1, 2, 1 }, { 1, 1, 1 } };
        private int[,] _fireSpread = { { 1, 2, 1 }, { 2, 0, 2 }, { 1, 2, 1 } };


        [Fact]
        public void Update_FireGeneration_Probability1()
        {
            _forest = new Forest(3, 3, 0, 100);
            _forest.SetCells(_trees);
            _forest.NextStep();
            var result = _forest.CurrentState();
            Assert.Equal(_fires, result);
        }

        [Fact]
        public void Update_FireGeneration_Probability0()
        {
            _forest = new Forest(3, 3, 0, 0);
            _forest.SetCells(_trees);
            var result = _forest.NextStep();
            Assert.Equal(_trees, result);
        }

        [Fact]
        public void Update_TreeGeneration_Probability1()
        {
            _forest = new Forest(3, 3, 100, 0);
            _forest.SetCells(_empty);
            var result = _forest.NextStep();
            Assert.Equal(_trees, result);
        }

        [Fact]
        public void Update_TreeGeneration_Probability0()
        {
            _forest = new Forest(3, 3, 0, 0);
            _forest.SetCells(_empty);
            var result = _forest.NextStep();
            Assert.Equal(_empty, result);
        }

        [Fact]
        public void Update_FireTransfer_()
        {
            _forest = new Forest(3, 3, 0, 0);
            _forest.SetCells(_fireCenter);
            var result = _forest.NextStep();
            Assert.Equal(_fireSpread, result);
        }

    }
}