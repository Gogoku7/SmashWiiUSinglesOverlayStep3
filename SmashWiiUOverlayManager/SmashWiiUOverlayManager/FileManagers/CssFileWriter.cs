using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashWiiUOverlayManager.FileManagers
{
    public class CssFileWriter
    {
        public void WriteFile(string filePath, string cssText)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(filePath);
            }
            try
            {
                File.WriteAllText(filePath, cssText);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
