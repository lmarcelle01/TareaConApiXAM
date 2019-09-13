using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PracticaAPI.Models
{
    public class Location
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class Northeast
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class Southwest
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class Viewport
    {
        public Northeast Northeast { get; set; }
        public Southwest Southwest { get; set; }
    }

    public class Geometry
    {
        public Location Location { get; set; }
        public Viewport Viewport { get; set; }
    }

    public class Candidate : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string formatted_address { get; set; }
        public Geometry Geometry { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }

    public class Place
    {
        public IList<Candidate> Candidates { get; set; }
        public string Status { get; set; }
    }
}
