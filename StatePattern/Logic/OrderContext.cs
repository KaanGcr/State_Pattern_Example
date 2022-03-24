namespace StatePattern.Logic
{
    public class OrderContext
    {
        private OrderState currentState;

        public void TransitionToState(OrderState OrderState)
        {
            this.currentState = OrderState;
            currentState.EnterState(this);
        }

        public OrderContext()
        {
            TransitionToState(new NewState());
        }

        public void ShowState(string StateInfo)
        {
            Console.WriteLine(StateInfo);
        }

        public void Cancel(string CancelReason)
        {
            currentState.Cancel(this, CancelReason);
        }
    }
}
