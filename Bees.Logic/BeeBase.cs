using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bees.Logic.Annotations;

namespace Bees.Logic
{
    public class BeeBase : IBee, INotifyPropertyChanged
    {
        private float _health;

        public BeeBase(int healthThreshold)
        {
            Health = 100;
            HealthThreshold = healthThreshold;
        }

        public float Health
        {
            get => _health;
            set
            {
                _health = value;
                OnPropertyChanged(nameof(Health));
                OnPropertyChanged(nameof(IsDead));
            }
        }

        public int HealthThreshold { get; set; }

        public bool IsDead => Health < HealthThreshold;

        public void Damage(int damagePercentage)
        {
            if (damagePercentage < 0 || damagePercentage > 100)
                // Could throw a custom error here to warn the user
                return;

            if (IsDead) return;

            var damageValue = damagePercentage * Health / 100;
            Health -= damageValue;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}