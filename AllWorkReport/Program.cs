using FISCA;
using FISCA.Permission;
using FISCA.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllWorkReport
{
     public static class Program
     {
          [MainMethod]
          public static void Main()
          {
               //透過代碼呼叫相關功能

               RibbonBarItem rbItem7 = FISCA.Presentation.MotherForm.RibbonBarItems["學生", "教務"];
               rbItem7["轉學作業"].Image = Properties.Resources.web_stats_refresh_64;
               rbItem7["轉學作業"].Size = RibbonBarButton.MenuButtonSize.Large;
               rbItem7["轉學作業"]["轉學報表列印"].Enable = false;
               rbItem7["轉學作業"]["轉學報表列印"].Click += delegate
               {
                    OperationForm of = new OperationForm();
                    of.ShowDialog();
               };

               K12.Presentation.NLDPanels.Student.SelectedSourceChanged += delegate
               {
                    bool check = (K12.Presentation.NLDPanels.Student.SelectedSource.Count > 0) && Permissions.轉學報表列印權限;

                    rbItem7["轉學作業"]["轉學報表列印"].Enable = check;

               };


               Catalog detail2;

               detail2 = RoleAclSource.Instance["學生"]["功能按鈕"];
               detail2.Add(new RibbonFeature(Permissions.轉學報表列印, "轉學報表列印"));


          }
     }
}
