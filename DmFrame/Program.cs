using DmFrame.Classes;

namespace DmFrame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadConfiguration();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.Desktop());
            Demo.Tracer("程式正常結束");
        }

        static void LoadConfiguration()
        {
            // 取得 Tracer 輸出方式
            var exist = false;
            var method = Demo.ConfigureMethod;
            var eData = method?.LoadConfiguration();

            if (method != null && eData != null) {
                if (eData.TraceType != null) {
                    Demo.TraceType = (Demo.EmTraceType)eData.TraceType;
                    exist = true;
                }
            }
            if (!exist) {
                Demo.TraceType = Demo.EmTraceType.Console;
                Demo.Tracer("配置資料異常，採用預設 TraceType 輸出");
            }
        }
    }
}
