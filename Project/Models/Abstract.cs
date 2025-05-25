namespace Models
{
    public abstract class Cell
    {
        public abstract void Update();
        public abstract void Undo();
        public abstract int Print();

    }

    public abstract class Grid
    {
        public abstract Cell[,] NextStep();
        public abstract Cell[,] BackStep();

    }
}
