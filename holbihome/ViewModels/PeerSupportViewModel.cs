using holbihome.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace holbihome.ViewModels
{
    public partial class PeerSupportViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Review> Reviews { get; private set; } = new ObservableCollection<Review>();

        public PeerSupportViewModel()
        {
            Reviews = new ObservableCollection<Review>()
            {
                new Review() { Title = "Unity Concepts", StudentName = "Elmo Humphrey" },
                new Review() { Title = "Unity Concepts", StudentName = "Cassandra Vargas" },
                new Review() { Title = "Unity Concepts", StudentName = "Cristina Cabrera" },
                new Review() { Title = "Unity Concepts", StudentName = "Gavin Salinas" },
                new Review() { Title = "Object-relational mapping", StudentName = "Elmo Humphrey" },
                new Review() { Title = "Hidden Markov Models", StudentName = "Elmo Humphrey" },
                new Review() { Title = "Networking", StudentName = "Elmo Humphrey" },
                new Review() { Title = "Resume - Second Draft", StudentName = "Elmo Humphrey" },
                new Review() { Title = "Red-Black trees", StudentName = "Elmo Humphrey" },
                new Review() { Title = "Developer tools", StudentName = "Elmo Humphrey" },
            };
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
