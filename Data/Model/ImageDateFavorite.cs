//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFUIKitProfessional.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImageDateFavorite
    {
        public int id { get; set; }
        public int idImage { get; set; }
        public int idClient { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ImageGetter ImageGetter { get; set; }
    }
}
