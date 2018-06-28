using System;
using System.Timers;

namespace ExcelConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerBegin();

            Console.WriteLine("按回车键结束程序");
            Console.WriteLine("...");
            Console.ReadLine();
        }

        private static void TimerBegin()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimeEvent);

            aTimer.Interval = 2000;
            aTimer.Enabled = true;

            aTimer.AutoReset = false;
        }

        private static void TimeEvent(object source, ElapsedEventArgs e)
        {
            string templateExcelPath = @"{0}Template\{1}";
            string tmpExcelSavePath = @"{0}{1}.xlsx";
            string tmpPDFSavePath = @"{0}{1}.pdf";

            ExcelExportStateServiceReference.ExcelExportStateClient eClient = null;
            ExcelExportStateServiceReference.ExportParam ep = null;

            Console.WriteLine("TimeEvent Start At: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            try
            {
                eClient = new ExcelExportStateServiceReference.ExcelExportStateClient();
                ep = eClient.Pop();

                if (ep != null)
                {
                    if (!ep.FolderRootPath.EndsWith("\\")) ep.FolderRootPath += "\\";

                    templateExcelPath = string.Format(templateExcelPath, ep.FolderRootPath, ep.TemplateFileName);
                    tmpExcelSavePath = string.Format(tmpExcelSavePath, ep.FolderRootPath, ep.Guid.ToString());
                    tmpPDFSavePath = string.Format(tmpPDFSavePath, ep.FolderRootPath, ep.Guid.ToString());

                    Exception exportE = null;

                    if (!Demo.ExcelModelHelper.ExportPDFFile(templateExcelPath, tmpExcelSavePath, tmpPDFSavePath, ep.JsonSettingData, ref exportE))
                    {
                        Console.WriteLine("Exception: [{0}]", exportE.Message);
                    }
                    else
                    {
                        eClient.ChangeExportState(ep.Guid, ExcelExportStateServiceReference.ExportState.Completed);

                        Console.WriteLine("ExportCompleted: [{0}] [{1}]", ep.Guid.ToString(), ep.CreateDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        Console.WriteLine("\t\t [{0}]", ep.FolderRootPath);
                    }
                }
            }
            catch (Exception voidE)
            {
                if (ep != null)
                {
                    eClient.ChangeExportState(ep.Guid, ExcelExportStateServiceReference.ExportState.Failed);
                }

                Console.WriteLine("Exception: [{0}]", voidE.Message);
            }
            finally
            {
                eClient.Close();
            }

            System.Timers.Timer t = (System.Timers.Timer)source;

            t.Dispose();

            TimerBegin();
        }
    }
}

namespace Demo
{
    public class ExcelModelHelper
    {
        public static bool ExportPDFFile(string _templateExcelPath, string _tmpExcelSavePath, string _tmpPDFSavePath, string _jsonData, ref Exception _e)
        {
            // Convert Format ...

            return false;
        }
    }
}