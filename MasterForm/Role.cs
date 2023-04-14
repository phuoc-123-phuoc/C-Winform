
namespace MasterForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {

        }
        public Role(int value, string display)
        {
            this.value = value;
            this.display = display;
        }

        public int value { get; set; }
        public string display { get; set; }

        public string manv { get; set; }    
        public string role { get; set; }
       
    }
}
