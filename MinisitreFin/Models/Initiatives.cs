
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
    
public partial class Initiatives
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Initiatives()
    {

        this.Projet = new HashSet<Projet>();

    }


    public int ID { get; set; }

    public int UtilisateurID { get; set; }

    public string Nom_init { get; set; }

    public Nullable<bool> Statu_init { get; set; }

    public Nullable<System.DateTime> Date_debu { get; set; }

    public Nullable<System.DateTime> Date_fin { get; set; }

    public string Objectifs_generaux { get; set; }

    public string Obgectifs_specifiques { get; set; }

    public string Description_court { get; set; }

    public string Description_detaillee { get; set; }

    public Nullable<float> Budget { get; set; }

    public string Approbateur { get; set; }

    public string Cofinancement { get; set; }

    public string Regions { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Projet> Projet { get; set; }

    public virtual Utilisateur Utilisateur { get; set; }

}

}
