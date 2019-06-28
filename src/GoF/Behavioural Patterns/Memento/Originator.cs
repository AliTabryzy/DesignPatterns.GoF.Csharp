namespace GoF.Behavioural_Patterns.Memento
{
    public class Originator
    {
        public string State;

        public void SetState(string state)
        {
            this.State = state;
        }


        public Memento SaveState()
        {
            return new Memento(State);
        }

        public void ReStoreState(Memento memento)
        {
            State = memento.SavedState;
        }
    }
}