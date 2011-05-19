/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2006-10-13
 * Time: 20:26
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lextm.AStyle
{
    /// <summary>
    /// Description of OptionsForm.
    /// </summary>
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void OptionsFormLoad(object sender, System.EventArgs e)
        {
            cbIndent.Checked = OptionsProxy.Options.AStyleConfiguration.IndentNamespace;
            cbUseTab.Checked = !OptionsProxy.Options.AStyleConfiguration.ConvertTabs;
            cmbStyles.Text = OptionsProxy.Options.AStyleConfiguration.Style.ToString();
            tbCommandline.Text = OptionsProxy.Options.AStyleParams;
        }

        void BtOKClick(object sender, System.EventArgs e)
        {
            OptionsProxy.Options.AStyleConfiguration.IndentNamespace = cbIndent.Checked;
            OptionsProxy.Options.AStyleConfiguration.ConvertTabs = !cbUseTab.Checked;
            OptionsProxy.Options.AStyleConfiguration.Style = (AStyleStyle)Enum.Parse(typeof(AStyleStyle),
                    cmbStyles.Text);
            OptionsProxy.Options.AStyleParams = GetAStyleParams();
            OptionsProxy.SaveOptions();
        }
        
        private readonly static string[] ArrayAStyleParams = {
            "--style=linux",
            "--style=gnu",
            "--style=java",
            "--style=kr",
            "--style=ansi"
        };
        
        private string GetAStyleParams()
        {
            StringBuilder result = new StringBuilder();

            if (OptionsProxy.Options.AStyleConfiguration.Style
                    != AStyleStyle.CommandLine) {

                string style = null;
                switch (OptionsProxy.Options.AStyleConfiguration.Style) {
                case AStyleStyle.Linux:
                    style = ArrayAStyleParams[0];
                    break;
                case AStyleStyle.Gnu:
                    style = ArrayAStyleParams[1];
                    break;
                case AStyleStyle.Java:
                    style = ArrayAStyleParams[2];
                    break;
                case AStyleStyle.KernighanRitchie:
                    style = ArrayAStyleParams[3];
                    break;
                case AStyleStyle.Ansi:
                    style = ArrayAStyleParams[4];
                    break;
                default:
                    style = ArrayAStyleParams[3];
                    break;
                }

                result.Append(style);

                if (OptionsProxy.Options.AStyleConfiguration.IndentNamespace) {
                    result.Append(" --indent-namespaces");
                }
                if (OptionsProxy.Options.AStyleConfiguration.ConvertTabs) {
                    result.Append(" --convert-tabs");
                }
                if (OptionsProxy.Options.AStyleConfiguration.IndentPreprocessor) {
                    result.Append(" --indent-preprocessor");
                }
            } else {
                result.Append(tbCommandline.Text);
            }
            return result.ToString();
        }

        void CmbStylesSelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbStyles.SelectedIndex == 0) {
                tbCommandline.ReadOnly = false;
            } else {
                tbCommandline.ReadOnly = true;
            }
            switch (cmbStyles.SelectedIndex) {
            case 1:
                textBox1.Text = GnuToolTip;
                break;
            case 2:
                textBox1.Text = AnsiToolTip;
                break;
            case 3:
                textBox1.Text = JavaToolTip;
                break;
            case 4:
                textBox1.Text = LinuxToolTip;
                break;
            case 5:
                textBox1.Text = KRToolTip;
                break;
            default:
                textBox1.Text = null;
                break;
            }
        }


        private readonly static string AnsiToolTip =
            "namespace foospace" + Environment.NewLine +
            "{" + Environment.NewLine +
            "int Foo()" + Environment.NewLine +
            "{" + Environment.NewLine +
            "    if (isBar)" + Environment.NewLine +
            "    {" + Environment.NewLine +
            "        bar();" + Environment.NewLine +
            "        return 1;" + Environment.NewLine +
            "    }" + Environment.NewLine +
            "    else" + Environment.NewLine +
            "        return 0;" + Environment.NewLine +
            "}" + Environment.NewLine +
            "}";
        private readonly static string GnuToolTip =
            "namespace foospace" + Environment.NewLine +
            "  {" + Environment.NewLine +
            "    int Foo()" + Environment.NewLine +
            "      {" + Environment.NewLine +
            "        if (isBar)" + Environment.NewLine +
            "          {" + Environment.NewLine +
            "            bar();" + Environment.NewLine +
            "            return 1;" + Environment.NewLine +
            "          }" + Environment.NewLine +
            "        else" + Environment.NewLine +
            "          return 0;" + Environment.NewLine +
            "      }" + Environment.NewLine +
            "  }";
        private readonly static string KRToolTip =
            "namespace foospace {" + Environment.NewLine +
            "int Foo() {" + Environment.NewLine +
            "    if (isBar) {" + Environment.NewLine +
            "        bar();" + Environment.NewLine +
            "        return 1;" + Environment.NewLine +
            "    } else" + Environment.NewLine +
            "        return 0;" + Environment.NewLine +
            "}" + Environment.NewLine +
            "}";
        private readonly static string LinuxToolTip =
            "namespace foospace" + Environment.NewLine +
            "{" + Environment.NewLine +
            "int Foo()" + Environment.NewLine +
            "{" + Environment.NewLine +
            "        if (isBar) {" + Environment.NewLine +
            "                bar();" + Environment.NewLine +
            "                return 1;" + Environment.NewLine +
            "        } else" + Environment.NewLine +
            "                return 0;" + Environment.NewLine +
            "}" + Environment.NewLine +
            "}";
        private readonly static string JavaToolTip =
            "class foospace {" + Environment.NewLine +
            "    int Foo() {" + Environment.NewLine +
            "        if (isBar) {" + Environment.NewLine +
            "            bar();" + Environment.NewLine +
            "            return 1;" + Environment.NewLine +
            "        } else" + Environment.NewLine +
            "            return 0;" + Environment.NewLine +
            "    }" + Environment.NewLine +
            "}";

        void BtHelpClick(object sender, System.EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }
    }
}
