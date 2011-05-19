// lextm: this is preferences class.
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

namespace Lextm.AStyle
{
    ///<summary>
    ///All beautifiers configuration.
    ///</summary>
    /// <remarks>
    /// It should be a Serializable class with public constructor so as to be serialized and deserialized.
    /// </remarks>
    [Serializable]
    public sealed class Preferences
    {

        private AStyleSettings aStyleConfiguration;

        ///<summary>
        ///AStyle configuration.
        ///</summary>
        public AStyleSettings AStyleConfiguration
        {
            get {
                return aStyleConfiguration;
            } set {
                aStyleConfiguration = value;
            }
        }
        /// <summary>
        /// Default AStyle runtime parameters.
        /// </summary>
        public const string DefaultAStyleParams = "--style=kr --indent-namespaces --convert-tabs --indent-preprocessor";

        private string aStyleParams;
        ///<summary>
        ///Runtime AStyle parameters.
        ///</summary>
        public string AStyleParams
        {
            get {
                return aStyleParams;
            } set {
                aStyleParams = value;
            }
        }
    }
    ///<summary>
    ///AStyle configuration.
    ///</summary>
    [System.Serializable]
    public sealed class AStyleSettings
    {


        private string commandLineParams;
        ///<summary>
        ///Command-line parameters.
        ///</summary>
        public string CommandLineParams
        {
            get {
                return commandLineParams;
            } set {
                commandLineParams = value;
            }
        }

        private AStyleStyle style;

        ///<summary>
        ///AStyle style.
        ///</summary>
        public AStyleStyle Style
        {
            get {
                return style;
            } set {
                style = value;
            }
        }

        private bool indentNamespace;
        ///<summary>
        ///Whether to indent namespace.
        ///</summary>
        public bool IndentNamespace
        {
            get {
                return indentNamespace;
            } set {
                indentNamespace = value;
            }
        }

        private bool indentPreprocessor;
        /// <summary>
        /// Whether to indent preprocessor.
        /// </summary>
        public bool IndentPreprocessor
        {
            get {
                return indentPreprocessor;
            } set {
                indentPreprocessor = value;
            }
        }

        private bool convertTabs;
        /// <summary>
        /// Whether to convert tabs to spaces.
        /// </summary>
        public bool ConvertTabs
        {
            get {
                return convertTabs;
            } set {
                convertTabs = value;
            }
        }
    }
}

