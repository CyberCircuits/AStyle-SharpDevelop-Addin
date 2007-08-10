/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2006-10-13
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lextm.AStyle
{
	partial class OptionsForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.tbCommandline = new System.Windows.Forms.TextBox();
			this.cmbStyles = new System.Windows.Forms.ComboBox();
			this.cbUseTab = new System.Windows.Forms.CheckBox();
			this.cbIndent = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.btHelp = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Command line:";
			// 
			// tbCommandline
			// 
			this.tbCommandline.Location = new System.Drawing.Point(110, 166);
			this.tbCommandline.Name = "tbCommandline";
			this.tbCommandline.Size = new System.Drawing.Size(287, 21);
			this.tbCommandline.TabIndex = 10;
			// 
			// cmbStyles
			// 
			this.cmbStyles.FormattingEnabled = true;
			this.cmbStyles.Items.AddRange(new object[] {
									"CommandLine",
									"Gnu",
									"Ansi",
									"Java",
									"Linux",
									"KernighanRitchie"});
			this.cmbStyles.Location = new System.Drawing.Point(19, 20);
			this.cmbStyles.Name = "cmbStyles";
			this.cmbStyles.Size = new System.Drawing.Size(141, 21);
			this.cmbStyles.TabIndex = 8;
			this.cmbStyles.SelectedIndexChanged += new System.EventHandler(this.CmbStylesSelectedIndexChanged);
			// 
			// cbUseTab
			// 
			this.cbUseTab.AutoSize = true;
			this.cbUseTab.Location = new System.Drawing.Point(20, 51);
			this.cbUseTab.Name = "cbUseTab";
			this.cbUseTab.Size = new System.Drawing.Size(87, 17);
			this.cbUseTab.TabIndex = 7;
			this.cbUseTab.Text = "Use tab char";
			this.cbUseTab.UseVisualStyleBackColor = true;
			// 
			// cbIndent
			// 
			this.cbIndent.AutoSize = true;
			this.cbIndent.Location = new System.Drawing.Point(20, 20);
			this.cbIndent.Name = "cbIndent";
			this.cbIndent.Size = new System.Drawing.Size(120, 17);
			this.cbIndent.TabIndex = 6;
			this.cbIndent.Text = "Indent namespaces";
			this.cbIndent.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbIndent);
			this.groupBox1.Controls.Add(this.cbUseTab);
			this.groupBox1.Location = new System.Drawing.Point(12, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(178, 83);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Others options";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbStyles);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(178, 55);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Coding styles";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Location = new System.Drawing.Point(197, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 143);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Preview";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 20);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(188, 116);
			this.textBox1.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(-1, 198);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(420, 12);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			// 
			// btOK
			// 
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Location = new System.Drawing.Point(244, 219);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 23);
			this.btOK.TabIndex = 16;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.BtOKClick);
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(326, 218);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 23);
			this.btCancel.TabIndex = 17;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// btHelp
			// 
			this.btHelp.Location = new System.Drawing.Point(22, 219);
			this.btHelp.Name = "btHelp";
			this.btHelp.Size = new System.Drawing.Size(75, 23);
			this.btHelp.TabIndex = 18;
			this.btHelp.Text = "About";
			this.btHelp.UseVisualStyleBackColor = true;
			this.btHelp.Click += new System.EventHandler(this.BtHelpClick);
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(419, 250);
			this.Controls.Add(this.btHelp);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbCommandline);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "OptionsForm";
			this.Text = "Options Dialog";
			this.Load += new System.EventHandler(this.OptionsFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btHelp;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.CheckBox cbIndent;
		internal System.Windows.Forms.CheckBox cbUseTab;
		internal System.Windows.Forms.ComboBox cmbStyles;
		internal System.Windows.Forms.TextBox tbCommandline;
		private System.Windows.Forms.Label label2;
	}
}
