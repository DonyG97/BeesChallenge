namespace Bees.Logic
{
    public class WorkerBee : BeeBase
    {
        public WorkerBee() : base(70)
        {
            HealthThreshold = 70;
            Health = 100;
        }
    }
}