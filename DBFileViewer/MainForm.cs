using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using ParadoxReader;

namespace DBFileViewer
{
	public partial class MainForm : Form
	{
		string filepath;

		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Title = "Select the Paradox database file to convert";
				ofd.Filter = "DB files (*.db)|*.db";
				ofd.FilterIndex = 0;
				ofd.RestoreDirectory = true;
				DialogResult result = ofd.ShowDialog(); // Show the dialog

				// On file selection
				if (result == DialogResult.OK)
				{
					filepath = ofd.FileName;
					txtSelectedFile.Text = filepath;
				}
			}	
		}

		public void WriteCSV(string filepath)
		{
			DataTable dt = new DataTable();
			string filename = Path.GetFileName(filepath);
			string tablename = GetTableName(filename);
			var table = new ParadoxTable(Directory.GetParent(filepath).ToString(), tablename);
			using (StreamWriter sw = new StreamWriter(Directory.GetParent(filepath).ToString() + "\\" + tablename + ".csv"))
			{
				string line = "";
				// Write headers
				for (int i = 0; i < table.FieldCount; i++)
				{
					line += table.FieldNames[i];
					if (i < table.FieldCount - 1)
					{
						line += ",";
					}
				}
				sw.WriteLine(line);

				// Write data
				foreach (var rec in table.Enumerate())
				{
					line = "";
					for (int i = 0; i < table.FieldCount; i++)
					{
						line += rec.DataValues[i];
						if (i < table.FieldCount - 1)
						{
							line += ",";
						}
					}
					sw.WriteLine(line);
				}
			}
			
			DialogResult dialogResult = MessageBox.Show("CSV conversion complete.\n\nView output file?", "Conversion Status", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Process.Start("explorer.exe", Directory.GetParent(filepath).ToString());
			}
		}

		public string GetTableName(string filename)
		{
			return filename.Split('.')[0];
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Click the select file button to pick your .db file. This program is designed to convert Paradox 7.0 files, and probably won't work with SQLite databases, Access files, etc.\n\nWhen Convert is clicked, it will dump the contents of the table into a CSV file in the same directory as its source, with the same filename and a different extension. It will overwrite whatever is in that directory with the same name.\n\nWritten by Cody Hunsberger for TS Partners, Inc.\nLast modified in September 2018", "More Info");
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			if(filepath != null)
			{
				WriteCSV(filepath);
			}
			else
			{
				MessageBox.Show("Pick a file first.");
			}
		}
	}
}
