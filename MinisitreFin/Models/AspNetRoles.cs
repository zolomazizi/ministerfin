
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
    
public partial class AspNetRoles
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AspNetRoles()
    {

        this.AspNetUserRoles = new HashSet<AspNetUserRoles>();

    }


    public string Id { get; set; }

    public string Name { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }

    public virtual AspNetUsers AspNetUsers { get; set; }

}

}