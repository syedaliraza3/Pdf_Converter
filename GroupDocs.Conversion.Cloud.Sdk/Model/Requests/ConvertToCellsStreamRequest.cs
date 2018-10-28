// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConvertToCellsStreamRequest.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
  using GroupDocs.Conversion.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.ConversionApi.ConvertToCellsStream" /> operation.
  /// </summary>  
  public class ConvertToCellsStreamRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToCellsStreamRequest"/> class.
        /// </summary>        
        public ConvertToCellsStreamRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToCellsStreamRequest"/> class.
        /// </summary>
        /// <param name="request">The settings</param>
        public ConvertToCellsStreamRequest(CellsConversionRequest request = null)             
        {
            this.Request = request;
        }

        /// <summary>
        /// The settings
        /// </summary>  
        public CellsConversionRequest Request { get; set; }
  }
}
