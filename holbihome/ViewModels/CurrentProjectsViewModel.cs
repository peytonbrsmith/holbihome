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
    public partial class CurrentProjectsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Project> Projects { get; private set; } = new ObservableCollection<Project>();
        public ObservableCollection<Project> Finished { get; private set; } = new ObservableCollection<Project>();

        public CurrentProjectsViewModel()
        {
            Projects = new ObservableCollection<Project>()
            {
                new Project() { Title = "Unity Concepts", DueDate = "2 Days Left", ProjectGlyph="\ue049", Id=399 },
                new Project() { Title = "Object-relational mapping", DueDate = "1 Day Left", ProjectGlyph="\uf3e2", Id=1161 },
            };
            Finished = new ObservableCollection<Project>()
            {
                new Project() { Title = "React props", DueDate = "4 Day Left", ProjectGlyph="\uf41b", Id=923 },
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
