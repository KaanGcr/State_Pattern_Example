namespace StatePattern.Logic
{
    public class FailedState : OrderState
    {
        private string FailReason;

        public FailedState(string FailReason)
        {
            this.FailReason = FailReason;
        }

        public override void ApproveStep(OrderContext order)
        {
            Console.WriteLine("Invalid action for this state.");
        }

        public override void Cancel(OrderContext order, string CancelReason)
        {
            Console.WriteLine("Invalid action for this state.");
        }

        public override void EnterState(OrderContext order)
        {
            order.ShowState("Failed");
        }
    }
}
