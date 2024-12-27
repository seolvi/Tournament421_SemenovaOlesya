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
    
    public partial class Tournaments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tournaments()
        {
            this.MatchSchedule = new HashSet<MatchSchedule>();
            this.Rankings = new HashSet<Rankings>();
            this.Records = new HashSet<Records>();
            this.TournamentApplications = new HashSet<TournamentApplications>();
            this.Players = new HashSet<Players>();
            this.Teams = new HashSet<Teams>();
        }
    
        public int TournamentID { get; set; }
        public string TournamentName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Game { get; set; }
        public string FormatT { get; set; }
        public Nullable<int> MaxParticipants { get; set; }
        public Nullable<decimal> PrizePool { get; set; }
        public Nullable<int> MinRank { get; set; }
        public string Region { get; set; }
        public string BannedCharacters { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchSchedule> MatchSchedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rankings> Rankings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Records> Records { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentApplications> TournamentApplications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Players> Players { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teams> Teams { get; set; }
    }
}
