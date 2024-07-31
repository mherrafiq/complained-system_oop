using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Complaint_system
{
    public static class myconnection
    {

        public static string path()
        {
            return "workstation id=DBComplaintSystem.mssql.somee.com;packet size=4096;user id=oop2021_SQLLogin_1;pwd=kw4ss42w31;data source=DBComplaintSystem.mssql.somee.com;persist security info=False;initial catalog=DBComplaintSystem";
        }
        
      
       
    }
    
}
