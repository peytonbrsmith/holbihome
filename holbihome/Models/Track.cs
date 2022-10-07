using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace holbihome.Models
{
    internal class Track
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public bool isCategory { get; set; }
        public ObservableCollection<Project> Projects { get; set; }
    }
}
