using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DmFrame.Classes
{
    public class Win32
    {
        //
        public const int WM_CLOSE       = 0x0010;       // 傳送為視窗或應用程式應該終止的訊號。

        // System command
        public const int WM_NCCALCSIZE  = 0x0083;       // Standar Title Bar - Snap Window
        public const int WM_SYSCOMMAND  = 0x0112;
        public const int SC_MINIMIZE    = 0xF020;       // Minimize form (Before)
        public const int SC_RESTORE     = 0xF120;       // Restore form (Before)
        public const int WM_NCHITTEST   = 0x0084;       // Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.

        // 變更視窗大小
        public const int HTCLIENT       = 1;            // Represents the client area of the window
        public const int HTLEFT         = 10;           // Left border of a window, allows resize horizontally to the left
        public const int HTRIGHT        = 11;           // Right border of a window, allows resize horizontally to the right
        public const int HTTOP          = 12;           // Upper-horizontal border of a window, allows resize vertically up
        public const int HTTOPLEFT      = 13;           // Upper-left corner of a window border, allows resize diagonally to the left
        public const int HTTOPRIGHT     = 14;           // Upper-right corner of a window border, allows resize diagonally to the right
        public const int HTBOTTOM       = 15;           // Lower-horizontal border of a window, allows resize vertically down
        public const int HTBOTTOMLEFT   = 16;           // Lower-left corner of a window border, allows resize diagonally to the left
        public const int HTBOTTOMRIGHT  = 17;           // Lower-right corner of a window border, allows resize diagonally to the right

        [DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        public extern static void PostMessage(System.IntPtr hWnd, int msg, int wParam, int lParam);

        // 動畫
        public const int AW_HOR_POSITIVE    = 0x00000001;   // 從左到右打開視窗
        public const int AW_HOR_NEGATIVE    = 0x00000002;   // 從右到左打開視窗
        public const int AW_VER_POSITIVE    = 0x00000004;   // 從上到下打開視窗
        public const int AW_VER_NEGATIVE    = 0x00000008;   // 從下到上打開視窗
        public const int AW_CENTER          = 0x00000010;   // 若使用了AW_HIDE標誌，則使視窗向內重疊；若未使用 AW_HIDE 標誌，則使視窗向外擴充套件。
        public const int AW_HIDE            = 0x00010000;   // 隱藏視窗，預設則顯示視窗。
        public const int AW_ACTIVATE        = 0x00020000;   // 啟用視窗。在使用了AW_HIDE標誌后不要使用這個標誌。
        public const int AW_SLIDE           = 0x00040000;   // 使用滑動型別。預設則為滾動動畫型別。當使用 AW_CENTER 標誌時，這個標誌就被忽略。
        public const int AW_BLEND           = 0x00080000;   // 使用淡出效果。只有當hWnd為頂層視窗的時候才可以使用此標誌。

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(System.IntPtr hwnd, int dwTime, int dwFlags);
    }

}
