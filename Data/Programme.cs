//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Programme
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public string Nom_prog { get; set; }
        public string Objectif_prog { get; set; }
        public Nullable<System.DateTime> Date_debut { get; set; }
        public Nullable<System.DateTime> Date_fin { get; set; }
        public string Donateur { get; set; }
        public Nullable<double> budget { get; set; }
    
        public virtual Utilisateur Utilisateur { get; set; }
    }
}