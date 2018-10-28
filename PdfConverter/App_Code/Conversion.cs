using GroupDocs.Conversion.Cloud.Sdk;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Conversion
/// </summary>
public static class Conversion
{
    public static void ConvertToPdfStream(string fileName)
    {
        var configuration = new Configuration
        {
            AppSid = Common.MyAppSid,
            AppKey = Common.MyAppKey
        };

        // Initiate api instance
        var apiInstance = new ConversionApi(configuration);

        try
        {
            // convert to Pdf request
            var request = new ConvertToPdfStreamRequest
            {
                // convert to Pdf Request
                Request = new PdfConversionRequest
                {
                    // source file to convert
                    SourceFile = new ConversionFileInfo() { Folder = "input_dir", Name = fileName, Password = "" },
                    // Pdf save options
                    Options = new PdfSaveOptionsDto()
                }
            };

            // convert to Pdf
            Stream response = apiInstance.ConvertToPdfStream(request);

            using (System.IO.FileStream output = new System.IO.FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../Data/output_dir/") + Path.GetFileNameWithoutExtension(fileName) + ".pdf", FileMode.Create))
            {
                response.CopyTo(output);
            }

            Console.WriteLine(response.Length.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception when calling ConversionApi.ConvertToPdfStream: " + e.Message);
        }
    }
}