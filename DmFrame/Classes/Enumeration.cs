using System.ComponentModel;

namespace DmFrame.Classes
{
    /// <summary>
    /// 主視窗選單內容
    /// </summary>
    public enum EmSideMenu
    {
        [Description("　　　")]    // 內含三個全型空白
        Space,
        [Description("控制")]
        Menu,
        [Description("首頁")]
        Home,
        [Description("設定")]
        Setting,
        [Description("編輯")]
        Edit,
        [Description("測試文字長度")]
        Testing,
        [Description("關於")]
        About,
        [Description("離開")]
        Exit,
    }
}
