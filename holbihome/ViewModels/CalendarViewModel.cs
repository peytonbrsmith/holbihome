using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using holbihome.Models;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace holbihome.ViewModels
{

    public partial class CalendarViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<CalendarEvent> Events { get; private set; } = new ObservableCollection<CalendarEvent>();
        public ObservableCollection<CalendarEvent> Events2 { get; private set; } = new ObservableCollection<CalendarEvent>();
        public ObservableCollection<CalendarEvent> Events3 { get; private set; } = new ObservableCollection<CalendarEvent>();
        public ObservableCollection<CalendarEvent> Events4 { get; private set; } = new ObservableCollection<CalendarEvent>();
        public ObservableCollection<CalendarEvent> Events5 { get; private set; } = new ObservableCollection<CalendarEvent>();
        public ObservableCollection<CalendarEvent> Events6 { get; private set; } = new ObservableCollection<CalendarEvent>();

        public CalendarViewModel()
        {
            try
            {
                Events = new ObservableCollection<CalendarEvent>() {
                        new CalendarEvent() { Title = "Fireside Chat", Date = "10/7/22", Description = "Company Name" },
                        new CalendarEvent() { Title = "PLD", Date = "10/10/22", Description = "Group 3 - Pod 2" },
                    };
                Events2 = new ObservableCollection<CalendarEvent>() {
                        new CalendarEvent() { Title = "Mock Interview", Date = "10/11/22", Description = "with Derek Webb" },
                        new CalendarEvent() { Title = "Evaluation Quiz", Date = "10/14/22", Description = "Bash, C, Python" }
                    };
                Events3 = new ObservableCollection<CalendarEvent>() {
                        new CalendarEvent() { Title = "Hack Sprint", Date = "10/11/22", Description = "2" },
                        new CalendarEvent() { Title = "Alumni Panel", Date = "10/14/22", Description = "Bash, C, Python" }
                    };
                Events4 = new ObservableCollection<CalendarEvent>() {
                        new CalendarEvent() { Title = "Fireside Chat", Date = "10/7/22", Description = "Company Name" },
                        new CalendarEvent() { Title = "PLD", Date = "10/10/22", Description = "Group 3 - Pod 2" },
                        new CalendarEvent() { Title = "Mock Interview", Date = "10/11/22", Description = "with Derek Webb" },
                        new CalendarEvent() { Title = "Evaluation Quiz", Date = "10/14/22", Description = "Bash, C, Python" }
                    };
                Events5 = new ObservableCollection<CalendarEvent>() {
                        new CalendarEvent() { Title = "PLD", Date = "10/10/22", Description = "Group 3 - Pod 2" },
                        new CalendarEvent() { Title = "Mock Interview", Date = "10/11/22", Description = "with Derek Webb" },
                        new CalendarEvent() { Title = "Evaluation Quiz", Date = "10/14/22", Description = "Bash, C, Python" }
                    };
                Events6 = new ObservableCollection<CalendarEvent>() {
                        new CalendarEvent() { Title = "Fireside Chat", Date = "10/7/22", Description = "Company Name" },
                    };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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
