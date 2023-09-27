using DmFrame.Classes;
using System.Runtime.InteropServices;

namespace DmFrame.Forms
{
    public partial class Desktop : Form
    {
        #region 變數成員宣告
        // 非同步鎖定法 (async... await...)
        private readonly SemaphoreSlim mAsyncLocker = new(1, 1);
        private Size mFormSize;
        private int mBoarderSize;

        private bool mStopingCloseFlag; // 關閉程式時，判定程序是否真的要關閉
        private bool mReleaseAllFinish; // 全部資源皆已釋放
        private bool mClockRunsFlag;    // 顯示時間控制閥
        private Task? mClockRunsTask;   // 顯示時間 Task
        #endregion

        #region 建構及初始化
        public Desktop()
        {
            this.InitializeComponent();
            this.InitRoom();
        }

        private void InitRoom()
        {
            // 變數成員初始化
            mStopingCloseFlag = false;
            mReleaseAllFinish = false;
            mClockRunsFlag = false;
            mClockRunsTask = null;

            // 主視窗初始設定
            mBoarderSize = Defaults.Sized.BoarderSize;
            this.ClientSize = new Size(Defaults.Sized.DesktopWidth, Defaults.Sized.DesktopHeight);
            this.Padding = new Padding(mBoarderSize);
            this.BackColor = Color.FromArgb(96, 100, 232);
            mFormSize = this.ClientSize;

            // 各 Panel設定初始值
            this.dPanel_1_Caption.BackColor = Color.FromArgb(26, 26, 26);
            this.dPanel_2_Status.BackColor = Color.FromArgb(134, 27, 45);
            this.dPanel_3_Menu.BackColor = Color.FromArgb(26, 26, 26);
            this.dPanel_5_Client.BackColor = Color.FromArgb(31, 31, 31);

            // 設定標題列可移動式窗
            dPanel_1_Caption.MouseDown += Dashboard_MouseDown!;
            dPanel_1_1_Left.MouseDown += Dashboard_MouseDown!;
            dPanel_1_2_System.MouseDown += Dashboard_MouseDown!;
            dLabelCaption.MouseDown += Dashboard_MouseDown!;

            Demo.Tracer("主視窗初始化使用者物件完畢。");
        }
        #endregion

        #region WndProc
        /// <summary>
        /// 視窗 Callback
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int resizeAreaSize = 10;

            if (m.Msg == Win32.WM_NCHITTEST) {
                base.WndProc(ref m);

                if (this.WindowState == FormWindowState.Normal) {
                    // If the result of the m (mouse pointer) is in the client area of the window
                    if ((int)m.Result == Win32.HTCLIENT) {
                        // Gets screen point coordinates(X and Y coordinate of the pointer)
                        Point screenPoint = new Point(m.LParam.ToInt32());

                        // Computes the location of the screen point into client coordinates
                        Point clientPoint = this.PointToClient(screenPoint);

                        // If the pointer is at the top of the form (within the resize area- X coordinate)
                        if (clientPoint.Y <= resizeAreaSize) {
                            // If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                            if (clientPoint.X <= resizeAreaSize) {
                                // Resize diagonally to the left
                                m.Result = (IntPtr)Win32.HTTOPLEFT;
                            }
                            // If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) {
                                // Resize vertically up
                                m.Result = (IntPtr)Win32.HTTOP;
                            }
                            else {
                                // Resize diagonally to the right
                                m.Result = (IntPtr)Win32.HTTOPRIGHT;
                            }
                        }

                        // If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) {
                            // Resize horizontally to the left
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)Win32.HTLEFT;
                            // Resize horizontally to the right
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                                m.Result = (IntPtr)Win32.HTRIGHT;
                        }
                        else {
                            // Resize diagonally to the left
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)Win32.HTBOTTOMLEFT;
                            // Resize vertically down
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)Win32.HTBOTTOM;
                            // Resize diagonally to the right
                            else
                                m.Result = (IntPtr)Win32.HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }

            // Remove border and keep snap window
            if (m.Msg == Win32.WM_NCCALCSIZE && m.WParam.ToInt32() != 0) {
                return;
            }

            // Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == Win32.WM_SYSCOMMAND) {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == Win32.SC_MINIMIZE) {
                    mFormSize = this.ClientSize;
                }

                if (wParam == Win32.SC_RESTORE) {
                    this.Size = mFormSize;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        #region 視窗事件處理
        /// <summary>
        /// 視窗大小變更通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Desktop_Resize(object sender, EventArgs e)
        {
            this.AdjustForm();
        }

        /// <summary>
        /// Dashboard 滑鼠事件通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        /// <summary>
        /// 系統關閉紐觸發事件通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemClose_Click(object sender, EventArgs e)
        {
            // this.Close();
            const int SC_CLOSE = 0xF060;
            Win32.PostMessage(this.Handle, Win32.WM_SYSCOMMAND, SC_CLOSE, 0);
        }

        /// <summary>
        /// 視窗最小化按鈕觸發通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemMinimize_Click(object sender, EventArgs e)
        {
            // const int SC_MINIMIZE = 0xF020;
            // Win32.PostMessage(this.Handle, Win32.WM_SYSCOMMAND, SC_MINIMIZE, 0);

            this.WindowState = FormWindowState.Minimized;
            Win32.AnimateWindow(this.Handle, 2000, Win32.AW_BLEND);
            // Win32.AnimateWindow(this.Handle, 2000, Win32.AW_BLEND);

        }

        /// <summary>
        /// 視窗最大化按鈕觸發通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemMaximize_Click(object sender, EventArgs e)
        {
            // const int SC_MAXIMIZE = 0xF030;
            // Win32.PostMessage(this.Handle, Win32.WM_SYSCOMMAND, SC_MAXIMIZE, 0);

            if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// DoubleClick 事件通知 (dLabelStatusBlock)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusBlock_DoubleClick(object sender, EventArgs e)
        {
            this.LoadFormDefault();
        }

        /// <summary>
        /// 選單按鈕 Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBar_Click(object sender, EventArgs e)
        {
            dPanel_3_Menu.Width = dPanel_3_Menu.Width >= Defaults.Sized.DesktopMenuMaxWidth
                ? Defaults.Sized.DesktopMenuMinWidth
                : Defaults.Sized.DesktopMenuMaxWidth;
        }

        /// <summary>
        /// 視窗正在關閉事件通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Desktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.Cancel = false 維持視窗關閉作業 (預設值)
            // e.Cancel = true  取消視窗關閉作業

            if (!mStopingCloseFlag) {
                var notice = "正在關閉視窗...";
                this.StateMessage(notice);
                Demo.Tracer(notice);

                // 確定要關閉視窗 MessageBox 提問
                if (!this.AreYouSureClosesWindow()) {
                    notice = "使用者中斷關閉視窗作業";
                    e.Cancel = true;
                    this.StateMessage(notice);
                    Demo.Tracer(notice);
                    return;
                }

                // 設定停止關閉視窗旗標，已釋放全部資源旗標
                mStopingCloseFlag = true;
                mReleaseAllFinish = false;

                // 關閉時鐘
                this.DestroyClocksTask();
            }
            Demo.Tracer($"視窗正在關閉...進行關閉 = ({mReleaseAllFinish})");

            // 進行物件釋放及保存資料至組態檔
            if (mReleaseAllFinish) {
                // 保存主視窗資訊到配置檔
                var method = Demo.ConfigureMethod;
                if (method != null) {
                    var eData = method.ConfigureData;
                    if (eData != null) {
                        var eSize = this.Size;
                        var ePosn = this.Location;

                        eData.WinPosx = ePosn.X;
                        eData.WinPosy = ePosn.Y;
                        eData.WinWidth = eSize.Width;
                        eData.WinHeight = eSize.Height;
                    }
                    method.SaveConfiguration();
                }
                mStopingCloseFlag = false;
            }

            // 是否執行關閉視窗?
            e.Cancel = mStopingCloseFlag;
        }

        /// <summary>
        /// 視窗已經關閉通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Desktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Demo.Tracer("視窗已被關閉!!!");
        }

        /// <summary>
        /// 視窗載入事件通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Desktop_Load(object sender, EventArgs e)
        {
            // 初始化視窗基本資訊
            this.LoadFormInfo();
            // 讀取配置檔案
            this.LoadFormConfiguration();

            // 建立時鐘顯示 Task (mClockRunsTask)
            mClockRunsTask = Task.Run(() => this.UpdateClocksAsync());

            var notice = "就緒";
            this.StateMessage($"{notice} 配置檔案最更更新於 {this.dLabelStatusMessage.Text}");
            Demo.Tracer($"視窗載入工作{notice}");
        }
        #endregion

        #region 視窗關閉 Callback
        private async void MineCloseCallback()
        {
            await mAsyncLocker.WaitAsync();
            mReleaseAllFinish = false;
            for (; ; ) {
                // 時鐘顯示 Task mClockRunsTask 是否被關閉 ?
                if (mClockRunsTask != null) break;

                // 繼續檢查 xx 是否被關閉
                // ...

                // 所有項目皆已關閉，發出再次關閉視窗請求
                mReleaseAllFinish = true;
                this.BeginInvoke(this.Close);
                break;
            }

            Demo.Tracer($"關閉視窗 Callback，查驗值 = ({mReleaseAllFinish})");
            mAsyncLocker.Release();
        }
        #endregion

        #region 顯示時鐘 Task 處理
        /// <summary>
        /// 銷毀時鐘 (mClockRunsTask) Task 
        /// </summary> 
        private async void DestroyClocksTask()
        {
            mClockRunsFlag = false;
            if (mClockRunsTask != null) {
                await mClockRunsTask;
                mClockRunsTask.Dispose();
                mClockRunsTask = null;
            }
            this.MineCloseCallback();
        }

        /// <summary>
        /// 更新時鐘 (mClockRunsTask) Task 主體
        /// </summary>
        private void UpdateClocksAsync()
        {
            // 取得時間更新頻率 (單位 ms)
            var delay = 333;

            mClockRunsFlag = true;
            while (mClockRunsFlag) {
                // 取得當前電腦系統時間
                var currentTime = DateTime.Now.ToString("HH:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);

                // 顯示當前時間
                this.StateClock(currentTime);
                Thread.Sleep(delay);
            }
        }
        #endregion

        #region 跨執行序 UI 操作
        private void StateClock(string text)
        {
            var label = dLabelStatusClock;
            if (label.InvokeRequired) {
                label.BeginInvoke(delegate { label.Text = text; });
            }
            else label.Text = text;
        }

        private void StateMessage(string message)
        {
            var label = dLabelStatusMessage;
            if (label.InvokeRequired) {
                label.BeginInvoke(delegate { label.Text = message; });
            }
            else label.Text = message;
        }
        #endregion

        #region 操作函數
        /// <summary>
        /// 調整視窗狀態
        /// </summary>
        private void AdjustForm()
        {
            switch (this.WindowState) {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    dButtonSystemMaximize.ImageIndex = 3;
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != mBoarderSize)
                        this.Padding = new Padding(mBoarderSize);
                    dButtonSystemMaximize.ImageIndex = 1;
                    break;
                default: break;
            }

        }

        /// <summary>
        /// 關閉視窗-詢問對話框
        /// </summary>
        /// <returns></returns>
        private bool AreYouSureClosesWindow()
        {
            var text = "你確定要關閉視窗嗎? \r\nAre you sure closes the window?";
            var bars = "DmFrame Notice";
            var result = MessageBox.Show(text, bars, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        /// <summary>
        /// 讀取配置檔並配置視窗內容
        /// </summary>
        private void LoadFormConfiguration()
        {
            // 讀取配置檔案
            var method = Demo.ConfigureMethod;
            if (method != null) {
                var eData = method.LoadConfiguration();
                if (eData != null) {
                    if (eData.WinWidth <= 0 || eData.WinHeight <= 0) {
                        eData.WinWidth = this.Size.Width;
                        eData.WinHeight = this.Size.Height;
                        eData.WinPosx = this.Location.X;
                        eData.WinPosy = this.Location.Y;
                        Demo.Tracer("使用預設內容設定");
                    }
                    else {
                        this.Size = new Size((int)eData.WinWidth!, (int)eData.WinHeight!);
                        this.Location = new Point((int)eData.WinPosx!, (int)eData.WinPosy!);
                        Demo.Tracer("使用配置檔內容設定");
                    }
                    this.StateMessage(eData.LastUpdateDate!);
                }
            }
        }

        /// <summary>
        /// 讀取(設定)視窗初始資訊
        /// </summary>
        private void LoadFormInfo()
        {
            // 設定主視窗內容
            this.MinimumSize = new Size(Defaults.Sized.DesktopMenuMaxWidth + mBoarderSize * 2, 0);
            this.Text = "Side Menu Frame Sample";
            this.dLabelCaption.Text = this.Text;

            // 設定 Status 區域內容
            dLabelStatusLeft.Width = Defaults.Sized.LeftRightWidth;
            dLabelStatusLeft.Text = string.Empty;
            dLabelStatusRight.Width = Defaults.Sized.LeftRightWidth;
            dLabelStatusRight.Text = string.Empty;
            dLabelStatusBlock.Text = string.Empty;
            dLabelStatusMessage.Text = string.Empty;
            dLabelStatusClock.Text = string.Empty;

            // 設定 Menu 區域內容
            dPanel_3_Menu.Width = Defaults.Sized.DesktopMenuMaxWidth;
            dButtonMenuBar.Width = Defaults.Sized.DesktopMenuMinWidth;

            Demo.Tracer("設定視窗初始資訊完成");
        }

        /// <summary>
        /// 讀取(設定)視窗初始狀態
        /// </summary>
        private void LoadFormDefault()
        {
            this.Size = new Size(Defaults.Sized.DesktopWidth, Defaults.Sized.DesktopHeight);
            this.CenterToScreen();
            Demo.Tracer("恢復初始視窗預設大小及位置");
        }
        #endregion

    }
}
