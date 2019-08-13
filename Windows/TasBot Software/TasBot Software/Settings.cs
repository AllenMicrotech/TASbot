using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TasBot_Software
{
    public static class Settings
    {
        public static string lastUsedVersion = "";
        public static string filename = "";

        public static void Init()
        {
            filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "tasbot");
            filename += "/settings.amt";
        }

        public static bool HasConfigFile()
        {
            return File.Exists(filename);
        }

        public static void Load()
        {

        }

        public static void Save()
        {

        }

        public static void SetToDefaults()
        {

        }
    }
}
