using Azure.Storage.Blobs;
using System.ComponentModel;

namespace Ecomm.Helper
{
    public static class FileHelper
    {
        public static async Task<string> UploadImage(IFormFile formFile)
        {
            string fileName = Guid.NewGuid().ToString();
            string constring = @"DefaultEndPointsProtocol=https;";
            string containerName = "bookphotos";
            BlobContainerClient containerClient= new BlobContainerClient(constring, containerName);
            BlobClient blobClient = containerClient.GetBlobClient(fileName + formFile.FileName);
            MemoryStream ms = new MemoryStream();
            await formFile.CopyToAsync(ms);
            ms.Position = 0;
            await blobClient.UploadAsync(ms);
            return blobClient.Uri.AbsoluteUri;
        }

        public static async Task<string> UploadUrl(IFormFile formFile)
        {
            string constring = @"DefaultEndPointsProtocol=https;";
            string containerName = "bookurl";
            BlobContainerClient containerClient = new BlobContainerClient(constring, containerName);
            BlobClient blobClient = containerClient.GetBlobClient(formFile.FileName);
            MemoryStream ms = new MemoryStream();
            await formFile.CopyToAsync(ms);
            ms.Position = 0;
            await blobClient.UploadAsync(ms);
            return blobClient.Uri.AbsoluteUri;
        }
    }
}
