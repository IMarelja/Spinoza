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
        /*
         * Description and Name of the Simulations 
         * (create a ToString() that will return the Name of the class)
         */
        public abstract string Name { get; }
        public abstract string Description { get; }

        /*
         * Simulation controls
         */
        public abstract int[,] CurrentState();
        public abstract int[,] NextStep();
        public abstract int[,] BackStep();

    }
}
