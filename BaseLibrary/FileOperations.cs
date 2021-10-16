using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary
{
    public class FileOperations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Folder</param>
        /// <param name="originalExtension">File extension to change</param>
        /// <param name="replacementExtension">Replacement extension</param>
        /// <returns>success true or false, if false the exception raised</returns>
        public static (bool Success, Exception Exception) RenameExtensions(string path, string originalExtension, string replacementExtension)
        {
            try
            {
                new DirectoryInfo(path).GetFiles($"*.{originalExtension}")
                    .ToList()
                    .ForEach(currentFile =>
                    {
                        var filename = Path.ChangeExtension(currentFile.Name, $".{replacementExtension}");

                        var tempName = Path.Combine(path, filename);

                        if (File.Exists(tempName))
                        {
                            File.Delete(tempName);
                        }

                        File.Move(currentFile.Name, filename);

                    });

                return (true, null);
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }
    }
}
