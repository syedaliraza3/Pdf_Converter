using GroupDocs.Conversion.Cloud.Sdk.Api;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common
/// </summary>
public static class Common
{
    public static string MyAppSid = Common.MyAppSid;
    public static string MyAppKey = Common.MyAppKey;

    public static void UploadSampleTestFiles()
    {
        var storageConfig = new Configuration
        {
            AppSid = MyAppSid,
            AppKey = MyAppKey,
        };

        StorageApi storageApi = new StorageApi(storageConfig);
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../Data");

        var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        try
        {
            foreach (var dir in dirs)
            {
                var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = storageApi.IsExist(relativeDirPath);
                if (!response.FileExist.IsExist)
                    storageApi.CreateFolder(relativeDirPath);
            }
        }
        catch (Exception e)
        {

            throw;
        }

        var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

            var response = storageApi.IsExist(relativeFilePath);
            if (!response.FileExist.IsExist)
            {
                var fileName = Path.GetFileName(file);
                var relativeDirPath = relativeFilePath.Replace(fileName, string.Empty).Trim(Path.DirectorySeparatorChar);
                var bytes = File.ReadAllBytes(file);

                storageApi.CreateFile(fileName, relativeDirPath, bytes);
            }
        }
    }
}