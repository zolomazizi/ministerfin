
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
    
public partial class groue_detail
{

    public int ID { get; set; }

    public int Groupe_thematiqeID { get; set; }

    public int MembreId { get; set; }

    public string Fichier { get; set; }

    public string Text { get; set; }

    public Nullable<System.DateTime> datecreation { get; set; }



    public virtual Groupe_thematiqe Groupe_thematiqe { get; set; }

    public virtual Utilisateur Utilisateur { get; set; }

}

}
