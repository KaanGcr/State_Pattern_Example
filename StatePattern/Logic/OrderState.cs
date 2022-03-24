namespace StatePattern.Logic
{
    public abstract class OrderState
    {
        public abstract void EnterState(OrderContext order);
        public abstract void ApproveStep(OrderContext order);
        public abstract void Cancel(OrderContext order, string CancelReason);
    }
}
