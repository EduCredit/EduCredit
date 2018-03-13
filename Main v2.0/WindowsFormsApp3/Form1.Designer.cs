namespace WindowsFormsApp3
{
    partial class EduCredit
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EduCredit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindow = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noSpace = new System.Windows.Forms.NotifyIcon(this.components);
            this.noInternet = new System.Windows.Forms.NotifyIcon(this.components);
            this.netLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MainWindow, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 561F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.MainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindow.IsWebBrowserContextMenuEnabled = false;
            this.MainWindow.Location = new System.Drawing.Point(3, 3);
            this.MainWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.ScriptErrorsSuppressed = true;
            this.MainWindow.Size = new System.Drawing.Size(778, 555);
            this.MainWindow.TabIndex = 1;
            this.MainWindow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.MainWindow_DocumentCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // noSpace
            // 
            this.noSpace.Text = "notifyIcon1";
            this.noSpace.Visible = true;
            this.noSpace.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // noInternet
            // 
            this.noInternet.Text = "notifyIcon1";
            this.noInternet.Visible = true;
            this.noInternet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // netLabel
            // 
            this.netLabel.AutoEllipsis = true;
            this.netLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.netLabel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.netLabel.Location = new System.Drawing.Point(184, 219);
            this.netLabel.Name = "netLabel";
            this.netLabel.Size = new System.Drawing.Size(364, 129);
            this.netLabel.TabIndex = 2;
            this.netLabel.Text = "Няма връзка с интернет!";
            this.netLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.netLabel.Visible = false;
            this.netLabel.Click += new System.EventHandler(this.netLabel_Click);
            // 
            // EduCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.netLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EduCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EduCredit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser MainWindow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon noSpace;
        private System.Windows.Forms.NotifyIcon noInternet;
        private System.Windows.Forms.Label netLabel;
    }
}

