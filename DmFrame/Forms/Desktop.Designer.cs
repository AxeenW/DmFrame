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
            dButtonSystemMinimize = new Button();
            dSystemIconList = new ImageList(components);
            dButtonSystemMaximize = new Button();
            dButtonSystemClose = new Button();
            dPicboxCaptionIcon = new PictureBox();
            dPanel_3_Menu = new Panel();
            dPanel_5_Client = new Panel();
            dPanel_2_Status.SuspendLayout();
            dPanel_1_Caption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dPicboxCaptionIcon).BeginInit();
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
            dPanel_1_Caption.Controls.Add(dButtonSystemMinimize);
            dPanel_1_Caption.Controls.Add(dButtonSystemMaximize);
            dPanel_1_Caption.Controls.Add(dButtonSystemClose);
            dPanel_1_Caption.Controls.Add(dPicboxCaptionIcon);
            dPanel_1_Caption.Dock = DockStyle.Top;
            dPanel_1_Caption.Location = new Point(0, 0);
            dPanel_1_Caption.Name = "dPanel_1_Caption";
            dPanel_1_Caption.Size = new Size(784, 28);
            dPanel_1_Caption.TabIndex = 1;
            // 
            // dLabelCaption
            // 
            dLabelCaption.Dock = DockStyle.Fill;
            dLabelCaption.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dLabelCaption.Location = new Point(28, 0);
            dLabelCaption.Name = "dLabelCaption";
            dLabelCaption.Size = new Size(672, 28);
            dLabelCaption.TabIndex = 4;
            dLabelCaption.Text = "label1";
            dLabelCaption.TextAlign = ContentAlignment.MiddleLeft;
            dLabelCaption.MouseDown += Dashboard_MouseDown;
            // 
            // dButtonSystemMinimize
            // 
            dButtonSystemMinimize.Dock = DockStyle.Right;
            dButtonSystemMinimize.FlatAppearance.BorderSize = 0;
            dButtonSystemMinimize.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonSystemMinimize.FlatAppearance.MouseOverBackColor = Color.DimGray;
            dButtonSystemMinimize.FlatStyle = FlatStyle.Flat;
            dButtonSystemMinimize.ImageIndex = 2;
            dButtonSystemMinimize.ImageList = dSystemIconList;
            dButtonSystemMinimize.Location = new Point(700, 0);
            dButtonSystemMinimize.Name = "dButtonSystemMinimize";
            dButtonSystemMinimize.Size = new Size(28, 28);
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
            dButtonSystemMaximize.Dock = DockStyle.Right;
            dButtonSystemMaximize.FlatAppearance.BorderSize = 0;
            dButtonSystemMaximize.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonSystemMaximize.FlatAppearance.MouseOverBackColor = Color.DimGray;
            dButtonSystemMaximize.FlatStyle = FlatStyle.Flat;
            dButtonSystemMaximize.ImageIndex = 1;
            dButtonSystemMaximize.ImageList = dSystemIconList;
            dButtonSystemMaximize.Location = new Point(728, 0);
            dButtonSystemMaximize.Name = "dButtonSystemMaximize";
            dButtonSystemMaximize.Size = new Size(28, 28);
            dButtonSystemMaximize.TabIndex = 2;
            dButtonSystemMaximize.UseVisualStyleBackColor = true;
            dButtonSystemMaximize.Click += SystemMaximize_Click;
            // 
            // dButtonSystemClose
            // 
            dButtonSystemClose.Dock = DockStyle.Right;
            dButtonSystemClose.FlatAppearance.BorderSize = 0;
            dButtonSystemClose.FlatAppearance.MouseDownBackColor = Color.Silver;
            dButtonSystemClose.FlatAppearance.MouseOverBackColor = Color.DimGray;
            dButtonSystemClose.FlatStyle = FlatStyle.Flat;
            dButtonSystemClose.ImageIndex = 0;
            dButtonSystemClose.ImageList = dSystemIconList;
            dButtonSystemClose.Location = new Point(756, 0);
            dButtonSystemClose.Name = "dButtonSystemClose";
            dButtonSystemClose.Size = new Size(28, 28);
            dButtonSystemClose.TabIndex = 1;
            dButtonSystemClose.UseVisualStyleBackColor = true;
            dButtonSystemClose.Click += SystemClose_Click;
            // 
            // dPicboxCaptionIcon
            // 
            dPicboxCaptionIcon.Dock = DockStyle.Left;
            dPicboxCaptionIcon.Location = new Point(0, 0);
            dPicboxCaptionIcon.Name = "dPicboxCaptionIcon";
            dPicboxCaptionIcon.Size = new Size(28, 28);
            dPicboxCaptionIcon.TabIndex = 0;
            dPicboxCaptionIcon.TabStop = false;
            // 
            // dPanel_3_Menu
            // 
            dPanel_3_Menu.Dock = DockStyle.Left;
            dPanel_3_Menu.Location = new Point(0, 28);
            dPanel_3_Menu.Name = "dPanel_3_Menu";
            dPanel_3_Menu.Size = new Size(168, 505);
            dPanel_3_Menu.TabIndex = 2;
            // 
            // dPanel_5_Client
            // 
            dPanel_5_Client.BackColor = Color.FromArgb(31, 31, 31);
            dPanel_5_Client.Dock = DockStyle.Fill;
            dPanel_5_Client.Location = new Point(168, 28);
            dPanel_5_Client.Name = "dPanel_5_Client";
            dPanel_5_Client.Size = new Size(616, 505);
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
            ((System.ComponentModel.ISupportInitialize)dPicboxCaptionIcon).EndInit();
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
        private PictureBox dPicboxCaptionIcon;
        private Button dButtonSystemMinimize;
        private Button dButtonSystemMaximize;
        private Button dButtonSystemClose;
        private ImageList dSystemIconList;
        private Label dLabelCaption;
    }
}
