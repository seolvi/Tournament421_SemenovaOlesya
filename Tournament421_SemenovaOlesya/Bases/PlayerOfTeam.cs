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
    
    public partial class PlayerOfTeam
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int IdRole { get; set; }
        public string ContactInfo { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual TeamRole TeamRole { get; set; }
    }
}
