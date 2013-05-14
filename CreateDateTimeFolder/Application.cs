using System;
using System.Globalization;
using System.IO;

namespace CreateDateTimeFolder
{
    internal class Application
    {
        public static void Main(String[] Arguments)
        {
            Directory.CreateDirectory(Path.Combine(Arguments[0], DateTime.Now.ToString("yyyy-MM-dd HH-mm", CultureInfo.InvariantCulture)));
        }
    }
}
