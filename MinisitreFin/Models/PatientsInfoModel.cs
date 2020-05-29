﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinisitreFin.Models
{
    public class PatientsInfoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? DateTest { get; set; }
        public DateTime? DateLocalisation_ { get; set; }
        public double Latitude { get; set; }
        public double Longitude_ { get; set; }
    }

}