using FC.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _localPeople;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Person> LocalPeople
        {
            get
            {
                return _localPeople;
            }
            set
            {
                _localPeople = value;
                RaisePropertyChangedEvent(nameof(LocalPeople));
            }
        }

        public PeopleViewModel()
        {
            LocalPeople = new ObservableCollection<Person>();
            LocalPeople.Add(new Man("Bill", "Bill"));
            LocalPeople.Add(new Man("Bill", "Bill"));
            LocalPeople.Add(new Man("Bill", "Bill"));
            LocalPeople.Add(new Man("Bill", "Bill"));
        }

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
