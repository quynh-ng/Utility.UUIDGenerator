using System;
using System.Windows.Forms;

namespace net.vieapps.Utility.UUIDGenerator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			this.InitializeComponent();
			this.DoGenerate();
		}

		private void Generate_Click(object sender, EventArgs e)
		{
			this.DoGenerate();
		}

		void DoGenerate()
		{
			var uuid = Guid.NewGuid().ToString(this.WithHyphens.Checked ? "D" : "N");
			this.UUID.Text = this.UpperCase.Checked ? uuid.ToUpper() : uuid.ToLower();
		}
	}
}
