namespace StatePattern.Logic
{
    public class NewState : OrderState
    {
        public override void ApproveStep(OrderContext order)
        {
            order.TransitionToState(new PendingState());
        }

        public override void Cancel(OrderContext order, string CancelReason)
        {
            order.TransitionToState(new FailedState("Payment failed."));
        }

        public override void EnterState(OrderContext order)
        {
            order.ShowState("New");
        }
    }
}
