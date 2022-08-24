using System.IO;
using UnityEditor;
using UnityEngine;

namespace Sapi.SpaceInvader
{
    /// <summary>
    /// Take screenshot of game view and save it to image file
    /// </summary>
    public class EditorScreenshoter
    {
        private const string _savePath = "Screenshot/";
        private const string _saveFormat = "{0}{1} Screenshot [{2}].png";

        [MenuItem("Sapi/Screenshot Game %F12")]
        private static void TakeScreenshot()
        {
            if (!Directory.Exists(_savePath))
            {
                Directory.CreateDirectory(_savePath);
            }

            string date = System.DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            string path = GetFormattedPath(date);

            ScreenCapture.CaptureScreenshot(path);
            Debug.Log("Screenshot of Game View has been saved at <color=blue>" + Path.GetFullPath(path) + "</color>");
        }

        private static string GetFormattedPath(string date)
            => string.Format(_saveFormat, _savePath, Application.productName, date);
    }
}
