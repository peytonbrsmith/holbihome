using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace holbihome.Models
{
    internal class CalendarDay
    {
        public int Day { get; set; }
        public ObservableCollection<Project> Projects { get; set; }
        public ObservableCollection<CalendarEvent> Events { get; set; }
    }
}
