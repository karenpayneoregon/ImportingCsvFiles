using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FileDirOperationsUnitTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileDirOperationsUnitTest
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class FileTest : TestBase
    {
        /// <summary>
        /// Remove illegal chars from a file name
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.FileOperation)]
        public void RemoveIllegalCharsFromFileName()
        {
            string illegal = "\"M\"\\a/ry/ h**ad:>> a\\/:*?\"| li*tt|le|| la\"mb.?";
            Console.WriteLine(illegal);

            string regexSearch = $"{new string(Path.GetInvalidFileNameChars())}{new string(Path.GetInvalidPathChars())}";
            Regex regex = new Regex($"[{Regex.Escape(regexSearch)}]");
            illegal = regex.Replace(illegal, "");

            Console.WriteLine(illegal);
        }

    }

}