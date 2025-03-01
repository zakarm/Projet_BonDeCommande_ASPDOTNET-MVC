//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Onssa_Web_Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BCSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BCSet()
        {
            this.FESet = new HashSet<FESet>();
        }
    
        public int IdBC { get; set; }
        [Display(Name = "BON DE COMMANDE N°")]
        public string NumBc { get; set; }
        [Display(Name = "Désignation")]
        public string Destination { get; set; }
        [Display(Name = "Delai Execution")]
        public string DelaiExecution { get; set; }
        [Display(Name = "Date BON DE COMMANDE N°")]
        public System.DateTime DateBC { get; set; }
        [Display(Name = "Code Morasse")]
        public int InfoMorasse_CodeMorasse { get; set; }
        [Display(Name = "Id Pvj")]
        public int InfoPVJ_IdPVJ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FESet> FESet { get; set; }
        public virtual MorasseSet InfoMorasse { get; set; }
        public virtual PVJSet InfoPVJ { get; set; }
    }
}
