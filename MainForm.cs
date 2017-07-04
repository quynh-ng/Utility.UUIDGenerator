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
			this.UUID.Text = this.UpperCase.Checked
				? Guid.NewGuid().ToString("N").ToUpper()
				: Guid.NewGuid().ToString("N").ToLower();
		}
	}
}
