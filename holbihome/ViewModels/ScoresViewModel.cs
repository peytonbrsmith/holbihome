using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using holbihome.Models;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace holbihome.ViewModels
{
    public partial class ScoresViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Score> FoundScores { get; private set; } = new ObservableCollection<Score>();
        public ObservableCollection<Score> SpecScores { get; private set; } = new ObservableCollection<Score>();

        public ScoresViewModel()
        {
            FoundScores = new ObservableCollection<Score>()
            {
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
            };
            SpecScores = new ObservableCollection<Score>()
            {
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
                new Score() { Title = "Category Name", Trimester1="100", Trimester2="100", Trimester3="100", Trimester4="100", Trimester5="100"},
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
