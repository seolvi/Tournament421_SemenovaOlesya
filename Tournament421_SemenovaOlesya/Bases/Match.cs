//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament421_SemenovaOlesya.Bases
{
    using System;
    using System.Collections.Generic;
    
    public partial class Match
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Match()
        {
            this.RequestMatch = new HashSet<RequestMatch>();
        }
    
        public int Id { get; set; }
        public int IdTournament { get; set; }
        public Nullable<System.DateTime> StartTimestamp { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Results { get; set; }
    
        public virtual Tournament Tournament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestMatch> RequestMatch { get; set; }
    }
}
