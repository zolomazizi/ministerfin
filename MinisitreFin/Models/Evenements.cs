
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MinisitreFin.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Evenements
{

    public int ID { get; set; }

    public string Titre_even { get; set; }

    public string Description { get; set; }

    public string Image { get; set; }

    public Nullable<System.DateTime> Date_debut { get; set; }

    public Nullable<System.DateTime> Date_fin { get; set; }

    public Nullable<bool> Statut { get; set; }

}

}