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
        public Grid() { }
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

        /*
         * Save to and Load from a file
         */
        public abstract string SaveGridToJsonFile();
        public abstract void ImportGridFromJsonFile(string filePath);

    }
}
