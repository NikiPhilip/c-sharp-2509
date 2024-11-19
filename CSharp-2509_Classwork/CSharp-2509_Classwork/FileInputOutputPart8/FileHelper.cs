using System.IO;

namespace FileValidationExample
{
    public class FileHelper
    {
        public bool IsValidFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Exists && fileInfo.Length < 1024 * 1024; // 1 MB 
        }
    }
}