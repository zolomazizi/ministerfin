
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
    
public partial class Agenda_Activites
{

    public int Id { get; set; }

    public int AgendaID { get; set; }

    public int ActivitesID { get; set; }



    public virtual Activites Activites { get; set; }

    public virtual Agenda Agenda { get; set; }

}

}
