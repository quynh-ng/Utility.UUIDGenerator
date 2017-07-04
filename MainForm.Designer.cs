namespace net.vieapps.Utility.UUIDGenerator
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
			this.UUID = new System.Windows.Forms.TextBox();
			this.Generate = new System.Windows.Forms.Button();
			this.UpperCase = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// UUID
			// 
			this.UUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UUID.Location = new System.Drawing.Point(34, 30);
			this.UUID.Name = "UUID";
			this.UUID.Size = new System.Drawing.Size(779, 38);
			this.UUID.TabIndex = 0;
			// 
			// Generate
			// 
			this.Generate.Location = new System.Drawing.Point(838, 30);
			this.Generate.Name = "Generate";
			this.Generate.Size = new System.Drawing.Size(140, 40);
			this.Generate.TabIndex = 1;
			this.Generate.Text = "Generate";
			this.Generate.UseVisualStyleBackColor = true;
			this.Generate.Click += new System.EventHandler(this.Generate_Click);
			// 
			// UpperCase
			// 
			this.UpperCase.AutoSize = true;
			this.UpperCase.Location = new System.Drawing.Point(34, 84);
			this.UpperCase.Name = "UpperCase";
			this.UpperCase.Size = new System.Drawing.Size(154, 29);
			this.UpperCase.TabIndex = 2;
			this.UpperCase.Text = "Upper case";
			this.UpperCase.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 138);
			this.Controls.Add(this.UpperCase);
			this.Controls.Add(this.Generate);
			this.Controls.Add(this.UUID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UUID Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UUID;
		private System.Windows.Forms.Button Generate;
		private System.Windows.Forms.CheckBox UpperCase;
	}
}

