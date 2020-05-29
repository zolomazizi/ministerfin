using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinisitreFin.Models
{
    public class CityModel
    {
        public int ID { get; set; }
        public string City1 { get; set; }
        public Nullable<int> diametre { get; set; }
        public Nullable<int> Nombre_Quartier { get; set; }
        public Nullable<double> Max_Scan { get; set; }
        public Nullable<double> Min_Scan { get; set; }
        public Nullable<bool> Status_City { get; set; }
    }
}