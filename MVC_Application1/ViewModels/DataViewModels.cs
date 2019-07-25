using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application1.ViewModels
{
    public class DataViewModels
    {
    }

    public class RegisterNewUserViewModel
    {
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}