using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ViewModels;



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
                Sl_No=x.Sl_No,
                UserID=x.UserID,
                UserPassword=x.UserPassword,
                IsActive=x.IsActive,
                LastLogin=x.LastLogin,
                IsLocked=x.IsLocked }).ToList();
            return (loginListForDisplay);
        }

        public void saveNewRegisterationData(RegisterNewUserViewModel registerNewUserViewModel)
        {
            tbl_Login saveNewRegistrationDataToDB = new tbl_Login();
            saveNewRegistrationDataToDB.UserID = registerNewUserViewModel.UserEmail;
            saveNewRegistrationDataToDB.UserEmail = registerNewUserViewModel.UserEmail;
            saveNewRegistrationDataToDB.UserPassword = registerNewUserViewModel.UserPassword;
            saveNewRegistrationDataToDB.IsActive=false;
            saveNewRegistrationDataToDB.LoginAttempts=0;
            saveNewRegistrationDataToDB.IsLocked=false;
            context.tbl_Login.Add(saveNewRegistrationDataToDB);
            context.SaveChanges();
        }

        public bool EditUserRegistrationData(fetchingSpecificLoginData userUpdatedData)
        {
            bool flag=true;
            tbl_Login newUpdatedData = context.tbl_Login.Where(x=>x.Sl_No==userUpdatedData.Sl_No).FirstOrDefault();
            newUpdatedData.UserPassword = userUpdatedData.UserPassword;
            context.SaveChanges();
            return flag;
        }
    }


    public class fetchingSpecificLoginData
    {
        public int Sl_No { get; set; }
        public string UserID { get; set; }
        public string UserPassword { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public bool IsLocked { get; set; }
    }

    
}
