namespace DBFileViewer
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtSelectedFile = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Source Sans Pro", 10F);
			this.button1.Location = new System.Drawing.Point(401, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(61, 21);
			this.button1.TabIndex = 0;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.BackColor = System.Drawing.Color.Gainsboro;
			this.btnConvert.Font = new System.Drawing.Font("Source Sans Pro", 14F);
			this.btnConvert.Location = new System.Drawing.Point(341, 66);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(121, 41);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = false;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Gainsboro;
			this.button2.Location = new System.Drawing.Point(12, 77);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Help";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtSelectedFile
			// 
			this.txtSelectedFile.Location = new System.Drawing.Point(12, 12);
			this.txtSelectedFile.Name = "txtSelectedFile";
			this.txtSelectedFile.ReadOnly = true;
			this.txtSelectedFile.Size = new System.Drawing.Size(383, 20);
			this.txtSelectedFile.TabIndex = 4;
			this.txtSelectedFile.Text = "No File Selected";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 115);
			this.Controls.Add(this.txtSelectedFile);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Paradox to CSV Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtSelectedFile;
	}
}

