using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ItemRepository
    {
        public List<tbl_Login> getLoginTableData()
        {
            DbForLearningEntities context = new DbForLearningEntities();
            List<tbl_Login> loginList = context.tbl_Login.ToList();
            return (loginList);
        }
    }
}
