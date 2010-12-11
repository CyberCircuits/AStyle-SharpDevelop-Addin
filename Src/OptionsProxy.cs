/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2006-10-13
 * Time: 20:47
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Reflection;

namespace Lextm.AStyle
{
    /// <summary>
    /// Description of OptionsProxy.
    /// </summary>
    public class OptionsProxy
    {
        public OptionsProxy()
        {
        }

        private readonly static string fileName =
            Path.Combine(Path.GetDirectoryName(
                             Assembly.GetExecutingAssembly().Location),
                         "settings.xml");

        public static void SaveOptions()
        {
            PreferencesManager.SavePreferences(fileName, options);
        }

        private static Preferences options;

        public static Preferences Options
        {
            get {
                if (options == null) {

                    options = (Preferences)PreferencesManager.LoadPreferences(fileName,
                              typeof(Preferences));
                    if (options == null) {
                        options = new Preferences();
                        options.AStyleParams = Preferences.DefaultAStyleParams;
                        options.AStyleConfiguration = new AStyleSettings();
                        options.AStyleConfiguration.ConvertTabs = true;
                        options.AStyleConfiguration.IndentNamespace = true;
                        options.AStyleConfiguration.Style = AStyleStyle.KernighanRitchie;
                    }
                }
                return options;
            }
        }
    }
}
