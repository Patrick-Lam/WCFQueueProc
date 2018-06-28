using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int debug = 0;

            string excelSetting = "some setting ...";

            ExcelExportStateServiceReference.ExcelExportStateClient eClient = new ExcelExportStateServiceReference.ExcelExportStateClient();

            eClient.SetSessionData(new ExcelExportStateServiceReference.ExportParam()
            {
                CreateDateTime = DateTime.Now,
                ExportState = ExcelExportStateServiceReference.ExportState.Wait,
                Guid = Guid.NewGuid(),
                JsonSettingData = excelSetting,
                TemplateFileName = "a.xls",
                FolderRootPath = @"C:\Code\"
            });

            ExcelExportStateServiceReference.ExportParam ep = eClient.Pop();

            int debug1 = 0;
        }
    }
}
