using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace DmFrame.Classes
{
    public static class Demo
    {
        #region 列舉 TraceType
        public enum EmTraceType
        {
            None = 0,
            Console,        // 輸出至控制台
            LogNormal,      // 輸出至 Log 檔, 僅輸出時間、訊息
            LogShort,       // 輸出至 Log 檔, 僅輸出時間、訊息、調用者
            LogDetail,      // 輸出至 Log 檔, 時間、訊息、調用者、原始檔案名稱、原始檔案行號
            BothNormal,     // 輸出至控制台，輸出至 Log 檔, 僅輸出時間、訊息
            BothShort,      // 輸出至控制台，輸出至 Log 檔, 僅輸出時間、訊息、調用者
            BothDetail,     // 輸出至控制台，輸出至 Log 檔, 時間、訊息、調用者、原始檔案名稱、原始檔案行號
        }
        #endregion

        #region 變數宣告及定義
        private static readonly string mFmtTrace = "HH:mm:ss.ffff";
        private static readonly string mFmtDaily = "yyyyMMdd";

        private static Configuration? mConfigure = new();
        private static EmTraceType mTraceType = EmTraceType.Console;
        private static string mLogfileName = string.Empty;
        private static string mLogfileBoot = string.Empty;
        #endregion

        #region 取得與修改變數內容
        public static EmTraceType TraceType
        {
            get { return mTraceType; }
            set { mTraceType = value; }
        }

        public static string? LogfileName
        {
            get { return mLogfileName; }
            set { mLogfileName = $"{value}"; }
        }

        public static Configuration? ConfigureMethod
        {
            get { return mConfigure; }
            private set { mConfigure = value; }
        }
        #endregion

        #region 訊息輸出函數 (私有函數)
        /// <summary>
        /// 向 Console 或 Debug screen 輸出訊息
        /// </summary>
        /// <param name="message">要輸出的訊息字串</param>
        private static void OutputToConsole(string? message)
        {
            // 導入訊息字串為空 ?
            if (string.IsNullOrEmpty(message)) {
                message = $"[{DateTime.Now.ToString(mFmtTrace)}] : *** The message parameter is empty ***";
            }
            Trace.WriteLine(message);
        }

        /// <summary>
        /// 向 Log file 輸出訊息
        /// </summary>
        /// <param name="message">要輸出的訊息字串</param>
        private static void OutputToLogfile(string? message)
        {
            // 取得當前程式執行目錄路徑
            var dirsName = Directory.GetCurrentDirectory();
            var fileName = string.Empty;
            var traceTime = DateTime.Now.ToString(mFmtTrace);

            FileInfo? fileInfo = null;
            DirectoryInfo? dirsInfo = null;

            if (string.IsNullOrEmpty(message)) {
                message = $"[{traceTime}] : *** The message parameter is empty ***";
            }

            var allPass = false;
            for (; ; ) {
                // 建立 logfile 完整路徑與名稱
                if (string.IsNullOrEmpty(dirsName)) break;
                fileName = @$"{dirsName}\{DateTime.Now.ToString(mFmtDaily)}.txt";

                // 建立 FileInfo 物件 (檔案操作)
                if (string.IsNullOrEmpty(fileName)) break;
                fileInfo = new FileInfo(fileName);

                // 建立 DirectoryInfo 物件 (目錄操作)
                if (fileInfo == null || string.IsNullOrEmpty(fileInfo.DirectoryName)) break;
                dirsInfo = new DirectoryInfo(fileInfo.DirectoryName);

                if (dirsInfo == null) break;
                allPass = true;
                break;
            }

            if (!allPass) {
                var text = $"[{traceTime}] : Can not open {fileName} log file !!!";
                Debug.Write(text);
                return;
            }

            if (!dirsInfo!.Exists) {
                dirsInfo.Create();
            }

            if (string.IsNullOrEmpty(mLogfileBoot)) {
                message = $"\n{message}";
                mLogfileBoot = "Pass";
            }

            // 寫入資料至 log file
            using (FileStream fileStream = new FileStream(fileName, FileMode.Append)) {
                using (StreamWriter log = new StreamWriter(fileStream)) {
                    log.WriteLine(message);
                }
            }
        }

        /// <summary>
        /// 中英文混和對齊，對其文字排版用 (網路上抄來的)
        /// 會引發不能有負數的例外
        /// 已修正引發例外 2023.09.27
        /// </summary>
        /// <param name="str">來源字串</param>
        /// <param name="totalByteCount">要 PadRight 的總長度</param>
        /// <returns>異動後的新字串</returns>
        private static string PadRightEx(string str, int totalByteCount)
        {
            var coding = Encoding.GetEncoding("UTF-8");
            var dcount = 0;
            foreach (char ch in str.ToCharArray()) {
                if (coding.GetByteCount(ch.ToString()) > 1) {
                    dcount++;
                }
            }

            // 問題:
            // 經計算後, 若 dcount > totalByteCount 會引發例外。
            // System.ArgumentOutOfRangeException : Non-negative number required. (需要非負數)
            // return str.PadRight(totalByteCount - dcount);

            // 修正:
            return dcount > totalByteCount ? str.PadLeft(totalByteCount) : str.PadRight(totalByteCount - dcount);
        }
        #endregion

        #region 訊息輸出函數 [編譯條件識別符 : MineTrace]
        [Conditional("MineTrace")]
        public static void Tracer(string? message,
            [CallerMemberName] string? caller = null,
            [CallerFilePath] string? sourceFilePath = null,
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            var dtime = DateTime.Now.ToString(mFmtTrace);
            var text = string.Empty;
            var callerWide = 30;
            var messageWide = 40;

            if (string.IsNullOrEmpty(message)) {
                message = $"!!! The message parameter is empty !!!";
            }

            caller = $"{caller?.PadLeft(callerWide, '-')}()";
            switch (mTraceType) {
                case EmTraceType.None:
                    break;
                case EmTraceType.Console:
                    text = $"[{dtime}] {caller} : {message}";
                    OutputToConsole(text);
                    return;
                case EmTraceType.LogNormal:
                case EmTraceType.BothNormal:
                    text = $"[{dtime}] : {message}";
                    break;
                case EmTraceType.LogShort:
                case EmTraceType.BothShort:
                    text = $"[{dtime}] {caller} : {message}";
                    break;
                case EmTraceType.LogDetail:
                case EmTraceType.BothDetail:
                    message = $"{PadRightEx(message!, messageWide)}";
                    text = $"[{dtime}] {caller} : {message} | {sourceFilePath} (line {sourceLineNumber})";
                    break;
                default: break;
            }

            // 輸出字串內容，前提!!! 字串不是空白也不是 null
            if (!string.IsNullOrEmpty(text)) {
                switch (mTraceType) {
                    case EmTraceType.Console:
                        OutputToConsole(text);
                        break;
                    case EmTraceType.LogNormal:
                    case EmTraceType.LogShort:
                    case EmTraceType.LogDetail:
                        OutputToLogfile(text);
                        break;
                    case EmTraceType.BothNormal:
                    case EmTraceType.BothShort:
                    case EmTraceType.BothDetail:
                        OutputToConsole(text);
                        OutputToLogfile(text);
                        break;
                    default: break;
                }
            }
        }
        #endregion
    }
}
