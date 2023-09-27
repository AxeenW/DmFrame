namespace DmFrame.Forms
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            dPanel_2_Status = new Panel();
            dLabelStatusMessage = new Label();
            dLabelStatusBlock = new Label();
            dLabelStatusClock = new Label();
            dLabelStatusRight = new Label();
            dLabelStatusLeft = new Label();
            dPanel_1_Caption = new Panel();
            dLabelCaption = new Label();
            dPanel_1_2_System = new Panel();
            dButtonSystemMinimize = new Button();
            dSystemIconList = new ImageList(components);
            dButtonSystemMaximize = new Button();
            dButtonSystemClose = new Button();
            dPanel_1_1_Left = new Panel();
            dPanel_3_Menu = new Panel();
            dButtonMenuAbount = new Button();
            dMenuIconList = new ImageList(components);
            dButtonMenuExit = new Button();
            dButtonMenuTest = new Button();
            dButtonMenuEdit = new Button();
            dButtonMenuSetting = new Button();
            dButtonMenuHome = new Button();
            panel1 = new Panel();
            dButtonMenuBar = new Button();
            dPanel_5_Client = new Panel();
            dPanel_2_Status.SuspendLayout();
            dPanel_1_Caption.SuspendLayout();
            dPanel_1_2_System.SuspendLayout();
            dPanel_3_Menu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dPanel_2_Status
            // 
            dPanel_2_Status.BackColor = Color.FromArgb(134, 27, 45);
            dPanel_2_Status.Controls.Add(dLabelStatusMessage);
            dPanel_2_Status.Controls.Add(dLabelStatusBlock);
            dPanel_2_Status.Controls.Add(dLabelStatusClock);
            dPanel_2_Status.Controls.Add(dLabelStatusRight);
            dPanel_2_Status.Controls.Add(dLabelStatusLeft);
            dPanel_2_Status.Dock = DockStyle.Bottom;
            dPanel_2_Status.Location = new Point(0, 533);
            dPanel_2_Status.Name = "dPanel_2_Status";
            dPanel_2_Status.Size = new Size(784, 28);
            dPanel_2_Status.TabIndex = 0;
            // 
            // dLabelStatusMessage
            // 
            dLabelStatusMessage.Dock = DockStyle.Fill;
            dLabelStatusMessage.Location = new Point(12, 0);
            dLabelStatusMessage.Name = "dLabelStatusMessage";
            dLabelStatusMessage.Size = new Size(600, 28);
            dLabelStatusMessage.TabIndex = 4;
            dLabelStatusMessage.Text = "Message";
            dLabelStatusMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dLabelStatusBlock
            // 
            dLabelStatusBlock.Dock = DockStyle.Right;
            dLabelStatusBlock.Location = new Point(612, 0);
            dLabelStatusBlock.Name = "dLabelStatusBlock";
            dLabelStatusBlock.Size = new Size(60, 28);
            dLabelStatusBlock.TabIndex = 3;
            dLabelStatusBlock.Text = "Block";
            dLabelStatusBlock.TextAlign = ContentAlignment.MiddleCenter;
            dLabelStatusBlock.DoubleClick += StatusBlock_DoubleClick;
            // 
            // dLabelStatusClock
            // 
            dLabelStatusClock.Dock = DockStyle.Right;
            dLabelStatusClock.Location = new Point(672, 0);
            dLabelStatusClock.Name = "dLabelStatusClock";
            dLabelStatusClock.Size = new Size(100, 28);
            dLabelStatusClock.TabIndex = 2;
            dLabelStatusClock.Text = "15:08:30 PM";
            dLabelStatusClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dLabelStatusRight
            // 
            dLabelStatusRight.Dock = DockStyle.Right;
            dLabelStatusRight.Location = new Point(772, 0);
            dLabelStatusRight.Name = "dLabelStatusRight";
            dLabelStatusRight.Size = new Size(12, 28);
            dLabelStatusRight.TabIndex = 1;
            dLabelStatusRight.Text = "R";
            dLabelStatusRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dLabelStatusLeft
            // 
            dLabelStatusLeft.Dock = DockStyle.Left;
            dLabelStatusLeft.Location = new Point(0, 0);
            dLabelStatusLeft.Name = "dLabelStatusLeft";
            dLabelStatusLeft.Size = new Size(12, 28);
            dLabelStatusLeft.TabIndex = 0;
            dLabelStatusLeft.Text = "L";
            dLabelStatusLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dPanel_1_Caption
            // 
            dPanel_1_Caption.Controls.Add(dLabelCaption);
            dPanel_1_Caption.Controls.Add(dPanel_1_2_System);
            dPanel_1_Caption.Controls.Add(dPanel_1_1_Left);
            dPanel_1_Caption.Dock = DockStyle.Top;
            dPanel_1_Caption.Location = new Point(0, 0);
            dPanel_1_Caption.Name = "dPanel_1_Caption";
            dPanel_1_Caption.Size = new Size(784, 32);
            dPanel_1_Caption.TabIndex = 1;
            // 
            // dLabelCaption
            // 
            dLabelCaption.Dock = DockStyle.Fill;
            dLabelCaption.FlatStyle = FlatStyle.Flat;
            dLabelCaption.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dLabelCaption.Location = new Point(168, 0);
            dLabelCaption.Name = "dLabelCaption";
            dLabelCaption.Size = new Size(448, 32);
            dLabelCaption.TabIndex = 4;
            dLabelCaption.Text = "label1";
            dLabelCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dPanel_1_2_System
            // 
            dPanel_1_2_System.Controls.Add(dButtonSystemMinimize);
            dPanel_1_2_System.Controls.Add(dButtonSystemMaximize);
            dPanel_1_2_System.Controls.Add(dButtonSystemClose);
            dPanel_1_2_System.Dock = DockStyle.Right;
            dPanel_1_2_System.Location = new Point(616, 0);
            dPanel_1_2_System.Name = "dPanel_1_2_System";
            dPanel_1_2_System.Size = new Size(168, 32);
            dPanel_1_2_System.TabIndex = 6;
            // 
            // dButtonSystemMinimize
            // 
            dButtonSystemMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dButtonSystemMinimize.FlatAppearance.BorderSize = 0;
            dButtonSystemMinimize.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonSystemMinimize.FlatAppearance.MouseOverBackColor = Color.DimGray;
            dButtonSystemMinimize.FlatStyle = FlatStyle.Flat;
            dButtonSystemMinimize.ImageIndex = 2;
            dButtonSystemMinimize.ImageList = dSystemIconList;
            dButtonSystemMinimize.Location = new Point(72, 4);
            dButtonSystemMinimize.Margin = new Padding(0);
            dButtonSystemMinimize.Name = "dButtonSystemMinimize";
            dButtonSystemMinimize.Size = new Size(32, 28);
            dButtonSystemMinimize.TabIndex = 3;
            dButtonSystemMinimize.UseVisualStyleBackColor = true;
            dButtonSystemMinimize.Click += SystemMinimize_Click;
            // 
            // dSystemIconList
            // 
            dSystemIconList.ColorDepth = ColorDepth.Depth32Bit;
            dSystemIconList.ImageStream = (ImageListStreamer)resources.GetObject("dSystemIconList.ImageStream");
            dSystemIconList.TransparentColor = Color.Transparent;
            dSystemIconList.Images.SetKeyName(0, "icons8-color-close-window-48-red.png");
            dSystemIconList.Images.SetKeyName(1, "icons8-color-maximize-window-48.png");
            dSystemIconList.Images.SetKeyName(2, "icons8-color-minimize-window-48.png");
            dSystemIconList.Images.SetKeyName(3, "icons8-color-restore-window-48.png");
            // 
            // dButtonSystemMaximize
            // 
            dButtonSystemMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dButtonSystemMaximize.FlatAppearance.BorderSize = 0;
            dButtonSystemMaximize.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonSystemMaximize.FlatAppearance.MouseOverBackColor = Color.DimGray;
            dButtonSystemMaximize.FlatStyle = FlatStyle.Flat;
            dButtonSystemMaximize.ImageIndex = 1;
            dButtonSystemMaximize.ImageList = dSystemIconList;
            dButtonSystemMaximize.Location = new Point(104, 4);
            dButtonSystemMaximize.Margin = new Padding(0);
            dButtonSystemMaximize.Name = "dButtonSystemMaximize";
            dButtonSystemMaximize.Size = new Size(32, 28);
            dButtonSystemMaximize.TabIndex = 2;
            dButtonSystemMaximize.UseVisualStyleBackColor = true;
            dButtonSystemMaximize.Click += SystemMaximize_Click;
            // 
            // dButtonSystemClose
            // 
            dButtonSystemClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dButtonSystemClose.FlatAppearance.BorderSize = 0;
            dButtonSystemClose.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonSystemClose.FlatAppearance.MouseOverBackColor = Color.DimGray;
            dButtonSystemClose.FlatStyle = FlatStyle.Flat;
            dButtonSystemClose.ImageIndex = 0;
            dButtonSystemClose.ImageList = dSystemIconList;
            dButtonSystemClose.Location = new Point(136, 4);
            dButtonSystemClose.Margin = new Padding(0);
            dButtonSystemClose.Name = "dButtonSystemClose";
            dButtonSystemClose.Size = new Size(32, 28);
            dButtonSystemClose.TabIndex = 1;
            dButtonSystemClose.UseVisualStyleBackColor = true;
            dButtonSystemClose.Click += SystemClose_Click;
            // 
            // dPanel_1_1_Left
            // 
            dPanel_1_1_Left.Dock = DockStyle.Left;
            dPanel_1_1_Left.Location = new Point(0, 0);
            dPanel_1_1_Left.Name = "dPanel_1_1_Left";
            dPanel_1_1_Left.Size = new Size(168, 32);
            dPanel_1_1_Left.TabIndex = 5;
            // 
            // dPanel_3_Menu
            // 
            dPanel_3_Menu.Controls.Add(dButtonMenuAbount);
            dPanel_3_Menu.Controls.Add(dButtonMenuExit);
            dPanel_3_Menu.Controls.Add(dButtonMenuTest);
            dPanel_3_Menu.Controls.Add(dButtonMenuEdit);
            dPanel_3_Menu.Controls.Add(dButtonMenuSetting);
            dPanel_3_Menu.Controls.Add(dButtonMenuHome);
            dPanel_3_Menu.Controls.Add(panel1);
            dPanel_3_Menu.Dock = DockStyle.Left;
            dPanel_3_Menu.Location = new Point(0, 32);
            dPanel_3_Menu.Name = "dPanel_3_Menu";
            dPanel_3_Menu.Size = new Size(168, 501);
            dPanel_3_Menu.TabIndex = 2;
            // 
            // dButtonMenuAbount
            // 
            dButtonMenuAbount.Dock = DockStyle.Top;
            dButtonMenuAbount.FlatAppearance.BorderSize = 0;
            dButtonMenuAbount.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonMenuAbount.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            dButtonMenuAbount.FlatStyle = FlatStyle.Flat;
            dButtonMenuAbount.ImageAlign = ContentAlignment.MiddleLeft;
            dButtonMenuAbount.ImageIndex = 0;
            dButtonMenuAbount.ImageList = dMenuIconList;
            dButtonMenuAbount.Location = new Point(0, 250);
            dButtonMenuAbount.Name = "dButtonMenuAbount";
            dButtonMenuAbount.Size = new Size(168, 46);
            dButtonMenuAbount.TabIndex = 4;
            dButtonMenuAbount.TextAlign = ContentAlignment.MiddleLeft;
            dButtonMenuAbount.UseVisualStyleBackColor = true;
            // 
            // dMenuIconList
            // 
            dMenuIconList.ColorDepth = ColorDepth.Depth32Bit;
            dMenuIconList.ImageStream = (ImageListStreamer)resources.GetObject("dMenuIconList.ImageStream");
            dMenuIconList.TransparentColor = Color.Transparent;
            dMenuIconList.Images.SetKeyName(0, "icons8-about-48.png");
            dMenuIconList.Images.SetKeyName(1, "icons8-edit-48.png");
            dMenuIconList.Images.SetKeyName(2, "icons8-exit-48.png");
            dMenuIconList.Images.SetKeyName(3, "icons8-file-48.png");
            dMenuIconList.Images.SetKeyName(4, "icons8-gear-48.png");
            dMenuIconList.Images.SetKeyName(5, "icons8-help-48.png");
            dMenuIconList.Images.SetKeyName(6, "icons8-home-48.png");
            dMenuIconList.Images.SetKeyName(7, "icons8-image-48.png");
            dMenuIconList.Images.SetKeyName(8, "icons8-menu-48.png");
            dMenuIconList.Images.SetKeyName(9, "icons8-photo-48.png");
            dMenuIconList.Images.SetKeyName(10, "icons8-setting-48.png");
            dMenuIconList.Images.SetKeyName(11, "icons8-test-48.png");
            dMenuIconList.Images.SetKeyName(12, "icons8-toolbox-48.png");
            dMenuIconList.Images.SetKeyName(13, "icons8-tools-48.png");
            dMenuIconList.Images.SetKeyName(14, "icons8-wifi-empty-48.png");
            dMenuIconList.Images.SetKeyName(15, "icons8-wifi-full-48.png");
            // 
            // dButtonMenuExit
            // 
            dButtonMenuExit.Dock = DockStyle.Bottom;
            dButtonMenuExit.FlatAppearance.BorderSize = 0;
            dButtonMenuExit.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonMenuExit.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            dButtonMenuExit.FlatStyle = FlatStyle.Flat;
            dButtonMenuExit.ImageAlign = ContentAlignment.MiddleLeft;
            dButtonMenuExit.ImageIndex = 2;
            dButtonMenuExit.ImageList = dMenuIconList;
            dButtonMenuExit.Location = new Point(0, 455);
            dButtonMenuExit.Name = "dButtonMenuExit";
            dButtonMenuExit.Size = new Size(168, 46);
            dButtonMenuExit.TabIndex = 6;
            dButtonMenuExit.TextAlign = ContentAlignment.MiddleLeft;
            dButtonMenuExit.UseVisualStyleBackColor = true;
            dButtonMenuExit.Click += SystemClose_Click;
            // 
            // dButtonMenuTest
            // 
            dButtonMenuTest.Dock = DockStyle.Top;
            dButtonMenuTest.FlatAppearance.BorderSize = 0;
            dButtonMenuTest.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonMenuTest.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            dButtonMenuTest.FlatStyle = FlatStyle.Flat;
            dButtonMenuTest.ImageAlign = ContentAlignment.MiddleLeft;
            dButtonMenuTest.ImageIndex = 11;
            dButtonMenuTest.ImageList = dMenuIconList;
            dButtonMenuTest.Location = new Point(0, 204);
            dButtonMenuTest.Name = "dButtonMenuTest";
            dButtonMenuTest.Size = new Size(168, 46);
            dButtonMenuTest.TabIndex = 5;
            dButtonMenuTest.TextAlign = ContentAlignment.MiddleLeft;
            dButtonMenuTest.UseVisualStyleBackColor = true;
            // 
            // dButtonMenuEdit
            // 
            dButtonMenuEdit.Dock = DockStyle.Top;
            dButtonMenuEdit.FlatAppearance.BorderSize = 0;
            dButtonMenuEdit.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonMenuEdit.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            dButtonMenuEdit.FlatStyle = FlatStyle.Flat;
            dButtonMenuEdit.ImageAlign = ContentAlignment.MiddleLeft;
            dButtonMenuEdit.ImageIndex = 1;
            dButtonMenuEdit.ImageList = dMenuIconList;
            dButtonMenuEdit.Location = new Point(0, 158);
            dButtonMenuEdit.Name = "dButtonMenuEdit";
            dButtonMenuEdit.Size = new Size(168, 46);
            dButtonMenuEdit.TabIndex = 3;
            dButtonMenuEdit.TextAlign = ContentAlignment.MiddleLeft;
            dButtonMenuEdit.UseVisualStyleBackColor = true;
            // 
            // dButtonMenuSetting
            // 
            dButtonMenuSetting.Dock = DockStyle.Top;
            dButtonMenuSetting.FlatAppearance.BorderSize = 0;
            dButtonMenuSetting.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonMenuSetting.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            dButtonMenuSetting.FlatStyle = FlatStyle.Flat;
            dButtonMenuSetting.ImageAlign = ContentAlignment.MiddleLeft;
            dButtonMenuSetting.ImageIndex = 4;
            dButtonMenuSetting.ImageList = dMenuIconList;
            dButtonMenuSetting.Location = new Point(0, 112);
            dButtonMenuSetting.Name = "dButtonMenuSetting";
            dButtonMenuSetting.Size = new Size(168, 46);
            dButtonMenuSetting.TabIndex = 2;
            dButtonMenuSetting.TextAlign = ContentAlignment.MiddleLeft;
            dButtonMenuSetting.UseVisualStyleBackColor = true;
            // 
            // dButtonMenuHome
            // 
            dButtonMenuHome.Dock = DockStyle.Top;
            dButtonMenuHome.FlatAppearance.BorderSize = 0;
            dButtonMenuHome.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonMenuHome.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            dButtonMenuHome.FlatStyle = FlatStyle.Flat;
            dButtonMenuHome.ImageAlign = ContentAlignment.MiddleLeft;
            dButtonMenuHome.ImageIndex = 6;
            dButtonMenuHome.ImageList = dMenuIconList;
            dButtonMenuHome.Location = new Point(0, 66);
            dButtonMenuHome.Name = "dButtonMenuHome";
            dButtonMenuHome.Size = new Size(168, 46);
            dButtonMenuHome.TabIndex = 1;
            dButtonMenuHome.TextAlign = ContentAlignment.MiddleLeft;
            dButtonMenuHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dButtonMenuBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 66);
            panel1.TabIndex = 7;
            // 
            // dButtonMenuBar
            // 
            dButtonMenuBar.Dock = DockStyle.Left;
            dButtonMenuBar.FlatAppearance.BorderSize = 0;
            dButtonMenuBar.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonMenuBar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            dButtonMenuBar.FlatStyle = FlatStyle.Flat;
            dButtonMenuBar.ImageAlign = ContentAlignment.MiddleLeft;
            dButtonMenuBar.ImageIndex = 8;
            dButtonMenuBar.ImageList = dMenuIconList;
            dButtonMenuBar.Location = new Point(0, 0);
            dButtonMenuBar.Name = "dButtonMenuBar";
            dButtonMenuBar.Size = new Size(40, 66);
            dButtonMenuBar.TabIndex = 0;
            dButtonMenuBar.TextAlign = ContentAlignment.MiddleLeft;
            dButtonMenuBar.UseVisualStyleBackColor = true;
            dButtonMenuBar.Click += MenuBar_Click;
            // 
            // dPanel_5_Client
            // 
            dPanel_5_Client.BackColor = Color.FromArgb(31, 31, 31);
            dPanel_5_Client.Dock = DockStyle.Fill;
            dPanel_5_Client.Location = new Point(168, 32);
            dPanel_5_Client.Name = "dPanel_5_Client";
            dPanel_5_Client.Size = new Size(616, 501);
            dPanel_5_Client.TabIndex = 3;
            // 
            // Desktop
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(784, 561);
            Controls.Add(dPanel_5_Client);
            Controls.Add(dPanel_3_Menu);
            Controls.Add(dPanel_2_Status);
            Controls.Add(dPanel_1_Caption);
            Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(250, 250, 250);
            Name = "Desktop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desktop";
            FormClosing += Desktop_FormClosing;
            FormClosed += Desktop_FormClosed;
            Load += Desktop_Load;
            Resize += Desktop_Resize;
            dPanel_2_Status.ResumeLayout(false);
            dPanel_1_Caption.ResumeLayout(false);
            dPanel_1_2_System.ResumeLayout(false);
            dPanel_3_Menu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel dPanel_2_Status;
        private Label dLabelStatusLeft;
        private Label dLabelStatusRight;
        private Label dLabelStatusClock;
        private Label dLabelStatusMessage;
        private Label dLabelStatusBlock;
        private Panel dPanel_1_Caption;
        private Panel dPanel_3_Menu;
        private Panel dPanel_5_Client;
        private Button dButtonSystemMinimize;
        private Button dButtonSystemMaximize;
        private Button dButtonSystemClose;
        private ImageList dSystemIconList;
        private Label dLabelCaption;
        private ImageList dMenuIconList;
        private Button dButtonMenuBar;
        private Button dButtonMenuExit;
        private Button dButtonMenuTest;
        private Button dButtonMenuAbount;
        private Button dButtonMenuEdit;
        private Button dButtonMenuSetting;
        private Button dButtonMenuHome;
        private Panel panel1;
        private Panel dPanel_1_2_System;
        private Panel dPanel_1_1_Left;
    }
}
