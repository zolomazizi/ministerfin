
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
    
public partial class Activites
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Activites()
    {

        this.compte_rendu = new HashSet<compte_rendu>();

        this.Agenda_Activites = new HashSet<Agenda_Activites>();

    }


    public int ID { get; set; }

    public int Type_ActiviteID { get; set; }

    public string Nom_activ { get; set; }

    public Nullable<int> AgendaID { get; set; }

    public string Objectif_activ { get; set; }

    public Nullable<System.DateTime> Date { get; set; }

    public Nullable<bool> statu { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<compte_rendu> compte_rendu { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Agenda_Activites> Agenda_Activites { get; set; }

    public virtual Agenda Agenda { get; set; }

    public virtual Type_Activite Type_Activite { get; set; }

}

}
