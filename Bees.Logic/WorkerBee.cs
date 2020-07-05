using System;

namespace Bees.Logic
{
	public class WorkerBee : IBee
	{
		public WorkerBee()
		{
			HealthThreshold = 70;
			Health = 100;
		}


		public bool Dead => Health < HealthThreshold;

		public float Health { get; set; }

		public int HealthThreshold { get; set; }

		public void Damage()
		{
			throw new NotImplementedException();
		}
	}
}