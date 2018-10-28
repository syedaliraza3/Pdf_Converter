// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CellsSaveOptionsDto.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Conversion.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Cells save options
  /// </summary>  
  public class CellsSaveOptionsDto : SaveOptionsBaseDto 
  {                       
        /// <summary>
        /// Get or set the desired cells format 
        /// </summary>
        /// <value>Get or set the desired cells format </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConvertFileTypeEnum
        { 
            /// <summary>
            /// Enum Xls for "Xls"
            /// </summary>            
            Xls,
            
            /// <summary>
            /// Enum Xlsx for "Xlsx"
            /// </summary>            
            Xlsx,
            
            /// <summary>
            /// Enum Xls2003 for "Xls2003"
            /// </summary>            
            Xls2003,
            
            /// <summary>
            /// Enum Xlsm for "Xlsm"
            /// </summary>            
            Xlsm,
            
            /// <summary>
            /// Enum Xlsb for "Xlsb"
            /// </summary>            
            Xlsb,
            
            /// <summary>
            /// Enum Ods for "Ods"
            /// </summary>            
            Ods,
            
            /// <summary>
            /// Enum Csv for "Csv"
            /// </summary>            
            Csv,
            
            /// <summary>
            /// Enum Xltx for "Xltx"
            /// </summary>            
            Xltx,
            
            /// <summary>
            /// Enum Xltm for "Xltm"
            /// </summary>            
            Xltm            
        }

        /// <summary>
        /// Get or set the desired cells format 
        /// </summary>
        public ConvertFileTypeEnum? ConvertFileType { get; set; }

        /// <summary>
        /// Set this property if you want to protect the converted document with a password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Specifies the zoom level in percentage. Default is 100.
        /// </summary>  
        public int? Zoom { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsSaveOptionsDto {\n");
          sb.Append("  ConvertFileType: ").Append(this.ConvertFileType).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
