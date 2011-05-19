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
using System.Windows.Forms;

using ICSharpCode.Core;
using ICSharpCode.SharpDevelop;
using ICSharpCode.SharpDevelop.Editor;
using ICSharpCode.SharpDevelop.Gui;

namespace Lextm.AStyle
{
    public class FormatCodeCommand : AbstractMenuCommand
    {
        public override void Run()
        {
            IWorkbenchWindow window = WorkbenchSingleton.Workbench.ActiveWorkbenchWindow;
            if (window == null || window.ActiveViewContent.PrimaryFileName == null || window.ActiveViewContent.IsViewOnly) {
                // active content is not a text editor control
                return;
            }

            // 1. Get the file name and make a temp copy.
            string currentFileName = window.ActiveViewContent.PrimaryFileName;//tecp.TextEditorControl.FileName;
            if (System.IO.Path.GetExtension(currentFileName) != ".cs") {
                // not C# file
                return;
            }
            string tempFileName = Path.GetTempPath() + Path.DirectorySeparatorChar +
                                  Path.GetFileName(currentFileName);
            StreamWriter writer = new StreamWriter(tempFileName);
            writer.AutoFlush = true;
            writer.Write((window.ActiveViewContent as IEditable).Text);
            writer.Close();
            // 2. Call AStyle.
            // 2.1 Get current folder and others.
            string currentFolder =
                System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location);
            string astyleExe = "\"" + currentFolder +
                               System.IO.Path.DirectorySeparatorChar +
                               "astyle.exe" + "\"";
            string param = OptionsProxy.Options.AStyleParams + " \"" + tempFileName + "\"";
            // 2.2 Call AStyle.
            ICSharpCode.SharpDevelop.Util.ProcessRunner runner =
                new ICSharpCode.SharpDevelop.Util.ProcessRunner();
            runner.WorkingDirectory = System.IO.Path.GetDirectoryName(currentFileName);
            runner.Start(astyleExe, param);
            runner.WaitForExit();
            // 3. Reload the file.
            StreamReader reader = new StreamReader(tempFileName);
            IDocument doc = (window.ActiveViewContent.GetService(typeof(ITextEditorProvider)) as ITextEditorProvider).TextEditor.Document;

            doc.Replace(0, doc.TextLength, reader.ReadToEnd());
            reader.Close();

            File.Delete(tempFileName);
            File.Delete(tempFileName + ".orig");
        }
    }
}
