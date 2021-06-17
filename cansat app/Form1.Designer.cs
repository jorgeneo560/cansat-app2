
namespace cansat_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.VerticalMenu = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnResolution = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.PictureBox();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.VerticalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.DarkOrchid;
            this.TitleBar.Controls.Add(this.btnRestore);
            this.TitleBar.Controls.Add(this.btnMinimize);
            this.TitleBar.Controls.Add(this.btnMaximize);
            this.TitleBar.Controls.Add(this.btnClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1080, 18);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(1039, 2);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(15, 13);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestore.TabIndex = 3;
            this.btnRestore.TabStop = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1021, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 13);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1039, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(15, 13);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1058, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 13);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VerticalMenu
            // 
            this.VerticalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.VerticalMenu.Controls.Add(this.comboBox1);
            this.VerticalMenu.Controls.Add(this.label1);
            this.VerticalMenu.Controls.Add(this.btnSendData);
            this.VerticalMenu.Controls.Add(this.btnConnect);
            this.VerticalMenu.Controls.Add(this.btnResolution);
            this.VerticalMenu.Controls.Add(this.btnMain);
            this.VerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerticalMenu.Location = new System.Drawing.Point(0, 18);
            this.VerticalMenu.Margin = new System.Windows.Forms.Padding(2);
            this.VerticalMenu.Name = "VerticalMenu";
            this.VerticalMenu.Size = new System.Drawing.Size(132, 460);
            this.VerticalMenu.TabIndex = 1;
            this.VerticalMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.VerticalMenu_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Team Id = 1231";
            // 
            // btnSendData
            // 
            this.btnSendData.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnSendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendData.Font = new System.Drawing.Font("Impact", 12F);
            this.btnSendData.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnSendData.Location = new System.Drawing.Point(18, 435);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(96, 31);
            this.btnSendData.TabIndex = 6;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Impact", 12F);
            this.btnConnect.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnConnect.Location = new System.Drawing.Point(18, 372);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 31);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnResolution
            // 
            this.btnResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnResolution.FlatAppearance.BorderSize = 0;
            this.btnResolution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolution.Font = new System.Drawing.Font("Impact", 12F);
            this.btnResolution.ForeColor = System.Drawing.Color.White;
            this.btnResolution.Image = ((System.Drawing.Image)(resources.GetObject("btnResolution.Image")));
            this.btnResolution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResolution.Location = new System.Drawing.Point(0, 176);
            this.btnResolution.Margin = new System.Windows.Forms.Padding(2);
            this.btnResolution.Name = "btnResolution";
            this.btnResolution.Size = new System.Drawing.Size(132, 29);
            this.btnResolution.TabIndex = 1;
            this.btnResolution.Text = "Resolution";
            this.btnResolution.UseVisualStyleBackColor = false;
            this.btnResolution.Click += new System.EventHandler(this.btnResolution_Click);
            // 
            // btnMain
            // 
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.Location = new System.Drawing.Point(0, 22);
            this.btnMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(129, 85);
            this.btnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMain.TabIndex = 0;
            this.btnMain.TabStop = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Font = new System.Drawing.Font("Impact", 12F);
            this.PanelContainer.Location = new System.Drawing.Point(132, 18);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(948, 460);
            this.PanelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 478);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.VerticalMenu);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnMain_Click);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.VerticalMenu.ResumeLayout(false);
            this.VerticalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel VerticalMenu;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.PictureBox btnMain;
        private System.Windows.Forms.Button btnResolution;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

