/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2006-7-26
 * Time: 19:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Text;
using ICSharpCode.Core;
using ICSharpCode.SharpDevelop;
using ICSharpCode.SharpDevelop.Gui;
using ICSharpCode.SharpDevelop.DefaultEditor.Gui.Editor;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;
using System.Windows.Forms;

namespace Lextm.AStyle
{
	public class ShowOptionsCommand : AbstractMenuCommand
	{
		public override void Run()
		{
			OptionsForm form = new OptionsForm();
			form.ShowDialog();
		}
	}
}
