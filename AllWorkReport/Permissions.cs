using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllWorkReport
{
     public static class Permissions
     {
        public static string 轉學報表列印 { get { return "EC924F9D-B278-42F2-A6D3-608816272478"; } }
        //public static string 轉學報表列印 { get { return "K12.Student.TheCadre.Detail00040"; } }

        public static bool 轉學報表列印權限
        {
            get
            {
                bool check1 = FISCA.Permission.UserAcl.Current[轉學報表列印].Executable;
                return check1;
            }
        }
     }
}
