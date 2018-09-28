namespace DBFileViewer
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lblFile = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Source Sans Pro", 14F);
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 41);
			this.button1.TabIndex = 0;
			this.button1.Text = "Select File...";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConvert.Font = new System.Drawing.Font("Source Sans Pro", 14F);
			this.btnConvert.Location = new System.Drawing.Point(295, 12);
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
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(12, 139);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Help";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Location = new System.Drawing.Point(12, 71);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(85, 13);
			this.lblFile.TabIndex = 3;
			this.lblFile.Text = "No File Selected";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 174);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Paradox to CSV Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblFile;
	}
}

