using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    class DataViewModels
    {
    }

    public class RegisterNewUserViewModel
    {
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
