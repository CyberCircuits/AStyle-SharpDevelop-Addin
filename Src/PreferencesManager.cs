// lextm: this is preferences manager class.
// Copyright (C) 2006  Lex Mark
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Xml;

namespace Lextm.AStyle
{
    /// <summary>
    /// Description of PreferencesManager.
    /// </summary>
    public class PreferencesManager
    {
        private PreferencesManager() {}
        /// <summary>
        /// Saves preferences.
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <param name="preferences">Preferences</param>
        public static void SavePreferences(string fileName, object preferences)
        {
            SavePreferences(fileName, preferences, preferences.GetType());
        }
        /// <summary>
        /// Saves preferences.
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <param name="preferences">Preferences</param>
        /// <param name="type">Type of preferences object</param>
        public static void SavePreferences(string fileName, object preferences, Type type)
        {
            Debug.Assert(fileName != null);

            XmlSerializer _Serializer = new XmlSerializer(type);
            Stream _FileStream = null;
            string folder = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(folder)) {
                Directory.CreateDirectory(folder);
            }

            try {
                _FileStream = new FileStream(fileName, FileMode.Create);

            } catch (DirectoryNotFoundException) {
                // no such directory
                Debug.WriteLine("no such directory");
                //OTAUtils.AddMessage("No such directory");
            } catch (ArgumentException) {}
            finally {
                if (_FileStream != null) {
                    XmlTextWriter _Writer = null;
                    _Writer = new XmlTextWriter(_FileStream, new UTF8Encoding());
                    _Writer.Formatting  = Formatting.Indented;

                    // Serialize using the XmlTextWriter.
                    _Serializer.Serialize(_Writer, preferences);
                    _Writer.Close();
                } else {
                    Debug.WriteLine("null file stream");
                }
            }
        }
        /// <summary>
        /// Loads preferences.
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="type">Type of preferences object</param>
        public static object LoadPreferences(string fileName, Type type)
        {
            Debug.Assert(fileName != null);

            object result = null;

            XmlSerializer _Serializer = new XmlSerializer(type);
            FileStream _FileStream = null;

            try {
                _FileStream = File.OpenRead(fileName);
            } catch (DirectoryNotFoundException) {
                // no such directory
                Debug.WriteLine("no such diretory");
                //OTAUtils.AddMessage("No such directory");
            } catch (FileNotFoundException) {
                // cannot find the file
                Debug.WriteLine("no file");
                //OTAUtils.AddMessage("Cannot find the file");
            } catch (ArgumentException) {}

            XmlReader _Reader = null;

            try {

                if (_FileStream != null) {
                    _Reader = new XmlTextReader(_FileStream);
                    result = _Serializer.Deserialize(_Reader);
                } else {
                    Debug.WriteLine("null file stream");
                }
            } catch (XmlException) {
                //OTAUtils.AddMessage("Cannot read the preferences file.");
            } catch (InvalidOperationException) {
            } finally {
                if (_Reader != null) {
                    _Reader.Close();
                } else {
                    Debug.WriteLine("null reader");
                }
            }
            return result;
        }
    }
}

