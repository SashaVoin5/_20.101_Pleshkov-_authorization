//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ПР_20._101_Плешков_authorization.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public int RoleID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
