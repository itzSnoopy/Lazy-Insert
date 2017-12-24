namespace Lazy_Insert {
	partial class Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && ( components != null )) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.cboConnections = new System.Windows.Forms.ComboBox();
			this.lblConnectionTest = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPreferences = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAboutUs = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Connect to Database:";
			// 
			// cboConnections
			// 
			this.cboConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboConnections.FormattingEnabled = true;
			this.cboConnections.Location = new System.Drawing.Point(12, 84);
			this.cboConnections.Name = "cboConnections";
			this.cboConnections.Size = new System.Drawing.Size(149, 21);
			this.cboConnections.TabIndex = 1;
			// 
			// lblConnectionTest
			// 
			this.lblConnectionTest.AutoSize = true;
			this.lblConnectionTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnectionTest.Location = new System.Drawing.Point(13, 108);
			this.lblConnectionTest.Name = "lblConnectionTest";
			this.lblConnectionTest.Size = new System.Drawing.Size(80, 9);
			this.lblConnectionTest.TabIndex = 2;
			this.lblConnectionTest.Text = "Connection Test Label";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(167, 84);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 3;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.mnuAbout});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(563, 24);
			this.mnuMain.TabIndex = 4;
			this.mnuMain.Text = "menuStrip1";
			// 
			// mnuAbout
			// 
			this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutUs,
            this.mnuHelp});
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(52, 20);
			this.mnuAbout.Text = "About";
			// 
			// mnuSettings
			// 
			this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPreferences});
			this.mnuSettings.Name = "mnuSettings";
			this.mnuSettings.Size = new System.Drawing.Size(61, 20);
			this.mnuSettings.Text = "Settings";
			// 
			// mnuPreferences
			// 
			this.mnuPreferences.Name = "mnuPreferences";
			this.mnuPreferences.Size = new System.Drawing.Size(152, 22);
			this.mnuPreferences.Text = "Preferences";
			// 
			// mnuAboutUs
			// 
			this.mnuAboutUs.Name = "mnuAboutUs";
			this.mnuAboutUs.Size = new System.Drawing.Size(152, 22);
			this.mnuAboutUs.Text = "Lazy Insert";
			// 
			// mnuHelp
			// 
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(152, 22);
			this.mnuHelp.Text = "Help";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 261);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.lblConnectionTest);
			this.Controls.Add(this.cboConnections);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.Name = "Main";
			this.Text = "Lazy Insert - Main";
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboConnections;
		private System.Windows.Forms.Label lblConnectionTest;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuSettings;
		private System.Windows.Forms.ToolStripMenuItem mnuPreferences;
		private System.Windows.Forms.ToolStripMenuItem mnuAboutUs;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
	}
}