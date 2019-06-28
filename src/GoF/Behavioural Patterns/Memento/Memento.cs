namespace GoF.Behavioural_Patterns.Memento
{
    public class Memento
    {
        public readonly string SavedState;

        public Memento(string savedState)
        {
            SavedState = savedState;
        }
    }
}