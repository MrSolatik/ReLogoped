//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logoped1
{
    using System;
    using System.Collections.Generic;
    
    public partial class RechevayKarta
    {
        public int ID { get; set; }
        public int IDTeacher { get; set; }
        public string Zabolevanie { get; set; }
        public string RabProgramm_1_4_ { get; set; }
        public string FIO { get; set; }
        public string Class { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Age { get; set; }
        public string DateIncoming { get; set; }
        public string Sluh { get; set; }
        public string Zrenie { get; set; }
        public string SocSreda { get; set; }
    
        public virtual Teacher Teacher { get; set; }
    }
}
