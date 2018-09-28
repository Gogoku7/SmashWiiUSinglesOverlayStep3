using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashWiiUOverlayManager.FileManagers
{
    public class CssFileTextReplacer
    {
        public string ReplaceTemplateFileText(string templateCss, string cssValue)
        {
            if (templateCss == null)
            {
                throw new ArgumentException(nameof(templateCss));
            }
            if (string.IsNullOrEmpty(cssValue))
            {
                cssValue = "";
            }
            try
            {
                return templateCss.Replace("PLACEHOLDER", cssValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplaceTemplateFileTextForTeam(string cssteamNameTextTemplateCss, string playerSponsor, string playerName)
        {
            string playerFullName;
            if (string.IsNullOrEmpty(playerName))
            {
                playerName = "???";
            }

            if (string.IsNullOrEmpty(playerSponsor))
            {
                playerFullName = playerName;
            }
            else
            {
                playerFullName = $"{playerSponsor} | {playerName}";
            }

            return cssteamNameTextTemplateCss.Replace("PLACEHOLDER", playerFullName);
        }
    }
}
