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

        public void WritePlayer1CharacterFile(string content)
        {
            var filePath = @"Files\css\player1Character.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WritePlayer2CharacterFile(string content)
        {
            var filePath = @"Files\css\player2Character.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WritePlayer1NameTextFile(string content)
        {
            var filePath = @"Files\css\player1NameText.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WritePlayer2NameTextFile(string content)
        {
            var filePath = @"Files\css\player2NameText.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WritePlayer1PortFile(string content)
        {
            var filePath = @"Files\css\player1Port.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WritePlayer2PortFile(string content)
        {
            var filePath = @"Files\css\player2Port.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WritePlayer1ScoreTextFile(string content)
        {
            var filePath = @"Files\css\player1ScoreText.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WritePlayer2ScoreTextFile(string content)
        {
            var filePath = @"Files\css\player2ScoreText.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WriteRoundBoxTextFile(string content)
        {
            var filePath = @"Files\css\roundBoxText.css";
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
