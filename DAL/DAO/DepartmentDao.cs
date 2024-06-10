using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDao : EmployeeContext
    {
        public static void AddDepartment(DEPARTMENT department)
        {
            try{
                db.DEPARTMENTs.InsertOnSubmit(department);
                db.SubmitChanges();

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<DEPARTMENT> GetDepartment()
        {
            return db.DEPARTMENTs.ToList();
        }
    }
}
