using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL.Repository
{
    public class ItemRepository
    {
        DbForLearningEntities context = new DbForLearningEntities();
        public List<tbl_Login> getLoginTableData()
        {
            
            List<tbl_Login> loginList = context.tbl_Login.ToList();
            return (loginList);
        }

        public List<fetchingSpecificLoginData> getLoginTableDataForDisplay()
        {
            
            List<fetchingSpecificLoginData> loginListForDisplay = new List<fetchingSpecificLoginData>();
            loginListForDisplay = context.tbl_Login.Select(x => new fetchingSpecificLoginData {
                UserID=x.UserID,
                UserPassword=x.UserPassword,
                IsActive=x.IsActive,
                LastLogin=x.LastLogin,
                IsLocked=x.IsLocked }).ToList();
            return (loginListForDisplay);
        }

        public void saveNewRegisterationData(RegisterNewUserViewModel registerNewUserViewModel)
        {
             
        }


    }
    public class fetchingSpecificLoginData
    {
        public string UserID { get; set; }
        public string UserPassword { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public bool IsLocked { get; set; }
    }

    public class RegisterNewUserModel
    {
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }

    }

}
