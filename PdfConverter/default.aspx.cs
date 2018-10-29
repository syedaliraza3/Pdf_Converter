using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    /// <summary>
    /// This function is executed when the page is loaded on browser
    /// </summary>
    protected void Page_Load(object sender, EventArgs e)
    {
        //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
        Common.MyAppSid = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
        Common.MyAppKey = "xxxxxxxxxxxxxxxxxxx";

        // Uploading sample test files from local to default storage under folder 'conversions'
        Common.UploadSampleTestFiles();

        //Getting all the file paths from the input directory
        string[] fileArray = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../Data/input_dir"));
        List<ListItem> sourceFiles = new List<ListItem>();
        foreach (string filePath in fileArray)
        {
            sourceFiles.Add(new ListItem(Path.GetFileName(filePath), filePath));
        }

        //populating the Panel A list with source file names.
        sourceList.DataSource = sourceFiles;
        sourceList.DataBind();
        GetDestinationList();
    }

    /// <summary>
    /// This function is executed when the convert button is clicked.
    /// </summary>
    protected void ConvertToPDF_Click(object sender, EventArgs e)
    {
        //Getting all the file paths from input directory
        string[] sourceFileArray = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../Data/input_dir"));
        foreach (var filePath in sourceFileArray)
        {
            //Executing the conversion function for each file path in the array.
            var fileName = Path.GetFileName(filePath);
            //Common.inputGUIDFile = q;
            Conversion.ConvertToPdfStream(fileName);
        }

        //population the Panel B with destination file names.
        GetDestinationList();

        //To prevent execution of function on refreshing the page.
        Response.Redirect(Request.Url.AbsoluteUri);
    }

    /// <summary>
    /// This function populates the Panel B List.
    /// </summary>
    protected void GetDestinationList()
    {
        //Getting all the file paths from input directory.
        string[] destinationFileArray = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../Data/output_dir"));
        List<ListItem> destinationFiles = new List<ListItem>();
        foreach (string filePath in destinationFileArray)
        {
            destinationFiles.Add(new ListItem(Path.GetFileName(filePath), filePath));
        }

        //populating the Panel B list with destination file names.
        destinationList.DataSource = destinationFiles;
        destinationList.DataBind();
    }
}