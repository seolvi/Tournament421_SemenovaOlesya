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
    
    public partial class RequestMatch
    {
        public int Id { get; set; }
        public int IdRequest { get; set; }
        public int IdMatch { get; set; }
        public bool isWinner { get; set; }
        public int Score { get; set; }
        public int CountKill { get; set; }
        public int CountDeath { get; set; }
    
        public virtual Match Match { get; set; }
        public virtual Request Request { get; set; }
    }
}
