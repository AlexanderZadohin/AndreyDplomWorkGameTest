//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AndreyDplomWorkGameTest.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class IndiGameCatalog
    {
        public IndiGameCatalog()
        {
            this.TestGame = new HashSet<TestGame>();
            this.UserGameBibliary = new HashSet<UserGameBibliary>();
        }
    
        public int id { get; set; }
        public string GameName { get; set; }
        public string CoverGame { get; set; }
        public string LinkLaunch { get; set; }
        public string LinkDownload { get; set; }
        public Nullable<int> idJanre { get; set; }
        public string Description { get; set; }
    
        public virtual JanreGame JanreGame { get; set; }
        public virtual ICollection<TestGame> TestGame { get; set; }
        public virtual ICollection<UserGameBibliary> UserGameBibliary { get; set; }
    }
}
