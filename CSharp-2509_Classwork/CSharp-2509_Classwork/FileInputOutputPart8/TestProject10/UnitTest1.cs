using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestProject10
{
    
    [TestFixture]
    public class FileHelperTests
    {
        private FileHelper _fileHelper;
        private string smallFile = "smallFile.txt";
        private string largeFile = "largeFile.txt";
        private string nonExistentFile = "nonExistentFile.txt";

        [SetUp]
        public void SetUp()
        {
            _fileHelper = new FileHelper();
            if (!File.Exists(smallFile))
            {
                File.WriteAllText(smallFile, "This is a smallFile");
            }
            //Creates small file.
            if (!File.Exists(largeFile))
            {
                using (FileStream fileStream = new FileStream(largeFile, FileMode.Create))
                {
                    fileStream.SetLength(1024 * 1024 + 1);
                }
            }
            //Creates large file.
        }
        [Test]
        public void IsValidFile_FileUnder1MB_ReturnsTrue()
        {
            ClassicAssert.IsTrue(_fileHelper.IsValidFile(smallFile));
        }
        //If file size under 1 MB.
        [Test]
        public void IsValidFile_FileDoesNotExist_ReturnsFalse()
        {
            ClassicAssert.IsFalse(_fileHelper.IsValidFile(nonExistentFile));
        }
        //If file doesn't exist.
        [Test]
        public void IsValidFile_FileOver1MB_ReturnsFalse()
        {
            ClassicAssert.IsFalse(_fileHelper.IsValidFile(largeFile));
        }
        //If file size greater than 1 MB.
        [TearDown]
        public void TearDown()
        {
            if(File.Exists(smallFile))
            {
                File.Delete(smallFile);
            }
            if(File.Exists(largeFile))
            {
                File.Delete(largeFile);
            }
        }
        //Clears files.
    }
}