namespace Bees.Logic
{
	public interface IBee
	{
		float Health { get; }

		bool Dead { get; }

		int HealthThreshold { get; }
		void Damage();
	}
}