/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2006-10-14
 * Time: 9:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Lextm.AStyle
{
	/// <summary>
	/// Description of AboutForm.
	/// </summary>
	public partial class AboutForm
	{
		public AboutForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AboutFormLoad(object sender, System.EventArgs e)
		{
			string fileName = Path.Combine(
				Path.GetDirectoryName(
					Assembly.GetExecutingAssembly().Location),
				"about.rtf"
			);
			richTextBox1.LoadFile(fileName);
		}
	}
}
