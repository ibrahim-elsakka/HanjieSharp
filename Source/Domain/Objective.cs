namespace HanjieSharp.Domain
{
    internal sealed class Objective
    {
        public int Number { get; }
        
        public bool Completed { get; private set; }

        public Objective(int number)
        {
            Number = number;
            Completed = false;
        }

        public void MarkCompleted()
        {
            Completed = true;
        }
    }
}