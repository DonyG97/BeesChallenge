using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bees.Logic;
using Bees.UI.Annotations;

namespace Bees.UI
{
    public class BeeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<IBee> _bees;
        private readonly Random _random;

        public BeeViewModel()
        {
            _random = new Random();
            Bees = CreateDemoBees();
        }

        public ObservableCollection<IBee> Bees
        {
            get => _bees;
            set
            {
                _bees = value;
                OnPropertyChanged(nameof(Bees));
            }
        }

        public RelayCommand DamageAllBeesCommand => new RelayCommand(OnDamageAllBees);

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnDamageAllBees(object obj)
        {
            foreach (var bee in Bees) bee.Damage(_random.Next(0, 80));
        }

        private ObservableCollection<IBee> CreateDemoBees()
        {
            // This method should probably be moved into an BeeDemoData class and injected into this class
            var bees = new List<IBee>();
            // While the code in each of the create methods could be merge, I'm keeping it separate as I feel its cleaner.
            bees.AddRange(CreateWorkerBees());
            bees.AddRange(CreateDroneBees());
            bees.AddRange(CreateQueenBees());

            return new ObservableCollection<IBee>(bees);
        }

        private IEnumerable<IBee> CreateWorkerBees(int numberOfBeesToCreate = 10)
        {
            var workerBees = new List<IBee>();
            for (var i = 0; i < numberOfBeesToCreate; i++) workerBees.Add(new WorkerBee());

            return workerBees;
        }

        private IEnumerable<IBee> CreateDroneBees(int numberOfBeesToCreate = 10)
        {
            var droneBees = new List<IBee>();
            for (var i = 0; i < numberOfBeesToCreate; i++) droneBees.Add(new DroneBee());

            return droneBees;
        }

        private IEnumerable<IBee> CreateQueenBees(int numberOfBeesToCreate = 10)
        {
            var queenBees = new List<IBee>();
            for (var i = 0; i < numberOfBeesToCreate; i++) queenBees.Add(new QueenBee());

            return queenBees;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}