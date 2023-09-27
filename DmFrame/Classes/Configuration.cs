using System.Diagnostics;
using System.Text.Json;

namespace DmFrame.Classes
{
    public class Configuration : IDisposable
    {
        #region 變數宣告及定義
        private readonly string mDefaultFileName = "configuration.json";
        private bool disposedValue;
        private string? mSavefileName;
        private ConfigurationStruct? mConfigrationData = new();
        #endregion

        #region IDisposable 實作介面
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue) {
                if (disposing) {
                    // TODO: 處置受控狀態 (受控物件)
                }

                // TODO: 釋出非受控資源 (非受控物件) 並覆寫完成項
                // TODO: 將大型欄位設為 Null
                disposedValue = true;
            }
        }

        // // TODO: 僅有當 'Dispose(bool disposing)' 具有會釋出非受控資源的程式碼時，才覆寫完成項
        // ~JcConfigure()
        // {
        //     // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region 建構與初始化
        public Configuration()
        {
            mSavefileName = null;
            this.InitRoom();
        }

        public Configuration(string fileName)
        {
            mSavefileName = fileName;
            this.InitRoom();
        }

        private void InitRoom()
        {
            // 初始化 Log 檔案名稱
            mSavefileName = mSavefileName ?? mDefaultFileName;
        }
        #endregion

        #region 資料讀取與設定
        public string? ConfigureFilename
        {
            get { return mSavefileName; }
            set { mSavefileName = $"{value}"; }
        }

        public ConfigurationStruct? ConfigureData
        {
            get { return mConfigrationData; }
            private set { mConfigrationData = value; }
        }
        #endregion

        #region 保存組態檔資料
        public void SaveConfiguration()
        {
            var data = mConfigrationData;
            var fileName = mSavefileName ?? mDefaultFileName;

            if (data != null) {

                // 紀錄最後修改時間
                data.LastUpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // 進行 Json 格式轉換
                Demo.Tracer("將配置資料轉化為 JSON 序列");
                try {
                    // 將 list 內容轉為 Json 序列
                    var options = new JsonSerializerOptions {
                        WriteIndented = true,
                        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    };

                    var json = JsonSerializer.Serialize(data, options);
                    System.IO.File.WriteAllText(fileName, json);
                }
                catch (Exception ex) {
                    Demo.Tracer("進行 JSON 序列化時，引發例外!!!");
                    Demo.Tracer(ex.Message);
                }
            }
        }
        #endregion

        #region 讀取組態檔資料
        public ConfigurationStruct? LoadConfiguration()
        {
            var data = mConfigrationData;
            var fileName = mSavefileName ?? mDefaultFileName;
            string? json;

            // 組態檔資料結構異常!!!
            if (data == null) {
                Demo.Tracer("配置資料異常，無法進行資料操作!!!");
                return null;
            }

            // 取得配置文件
            try {
                Demo.Tracer("載入配置檔案");
                json = System.IO.File.ReadAllText(fileName);
            }
            catch (Exception ex) {
                json = null;
                Demo.Tracer($"配置檔案載入失敗!!!");
                Demo.Tracer($"{ex.Message}");
            }

            // 沒有設定檔狀況處理
            if (json == null) {
                Demo.Tracer("沒有配置文件，採用預設配置資料");
                return data;
            }

            // 進行 Json 格式轉化為可程式化結構 
            var item = JsonSerializer.Deserialize<ConfigurationStruct>(json);
            if (item != null) {
                data.ProgramName = item.ProgramName;
                data.Description = item.Description;
                data.LastUpdateDate = item.LastUpdateDate;
                data.WinPosx = item.WinPosx;
                data.WinPosy = item.WinPosy;
                data.WinWidth = item.WinWidth;
                data.WinHeight = item.WinHeight;
                data.TraceType = item.TraceType;
            }
            Demo.Tracer("配置資料初始化成功");
            return data;
        }
        #endregion

        #region 結構定義
        public class ConfigurationStruct
        {
            public string? ProgramName { get; set; } = null;            // 程式名稱
            public string? Description { get; set; } = null;            // 描述內容
            public string? LastUpdateDate { get; set; } = null;         // 最後更改時間
            public int? WinPosx { get; set; } = null;                   // 視窗寬度 (若該程式有視窗的話)
            public int? WinPosy { get; set; } = null;                   // 視窗高度 (若該程式有視窗的話)
            public int? WinWidth { get; set; } = null;                  // 視窗起始位置 X (若該程式有視窗的話)
            public int? WinHeight { get; set; } = null;                 // 視窗起始位置 Y (若該程式有視窗的話)
            public Demo.EmTraceType? TraceType { get; set; } = null;    // 追蹤除錯訊息輸出方式

            /// <summary>
            /// 建構式
            /// </summary>
            public ConfigurationStruct()
            {
                ProgramName = Process.GetCurrentProcess()?.MainModule?.ModuleName;
                Description = string.Empty;
                TraceType = Demo.EmTraceType.Console;
                LastUpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                WinPosx = 0;
                WinPosy = 0;
                WinWidth = 0;
                WinHeight = 0;
            }
        }
        #endregion

    }
}
