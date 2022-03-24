namespace StatePattern.Logic
{
    public class CompletedState : OrderState
    {
        public override void ApproveStep(OrderContext order)
        {
            Console.WriteLine("This is the final step!");
        }

        public override void Cancel(OrderContext order, string CancelReason)
        {
            order.TransitionToState(new FailedState("Refunded"));
        }

        public override void EnterState(OrderContext order)
        {
            order.ShowState("Order completed");
        }
    }
}
