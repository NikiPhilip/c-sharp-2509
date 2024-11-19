using NUnit.Framework;
using System.IO;

namespace FileValidationExample
{
    [TestFixture]
    public class FileHelperTests
    {
        private FileHelper _fileHelper;
        private string smallFile = "smallFile.txt";
        private string largeFile = "largeFile.txt";
        private string nonExistentFile = "nonExistentFile.txt";

        [SetUp]
        public void Setup()
        {
            _fileHelper = new FileHelper();

            // Create a small file 
            if (!File.Exists(smallFile))
            {
                File.WriteAllText(smallFile, "This is a small file.");
            }

            // Create a large file over 1 MB 
            if (!File.Exists(largeFile))
            {
                using (FileStream fs = new FileStream(largeFile, FileMode.Create))
                {
                    fs.SetLength(1024 * 1024 + 1); // slightly over 1 MB 
                }
            }
        }

        [Test]
        public void IsValidFile_FileExistsUnder1MB_ReturnsTrue()
        {
            Assert.IsTrue(_fileHelper.IsValidFile(smallFile));
        }

        [Test]
        public void IsValidFile_FileDoesNotExist_ReturnsFalse()
        {
            Assert.IsFalse(_fileHelper.IsValidFile(nonExistentFile));
        }

        [Test]
        public void IsValidFile_FileExistsOver1MB_ReturnsFalse()
        {
            Assert.IsFalse(_fileHelper.IsValidFile(largeFile));
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up test files 
            if (File.Exists(smallFile)) File.Delete(smallFile);
            if (File.Exists(largeFile)) File.Delete(largeFile);
        }
    }
}
