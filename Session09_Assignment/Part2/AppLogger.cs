using System;
using System.Collections.Generic;
using System.Text;

namespace DEPICSharpTask7.Part2
{
    public class AppLogger
    {
        // Q5: private static field that holds the single instance (starts as null)
        private static AppLogger? _instance;

        // Q5: private constructor — nobody outside the class can call "new AppLogger()"
        private AppLogger()
        {
        }

        // Q5: creates the instance only on the FIRST call, then always returns the same one
        public static AppLogger GetLogger()
        {
            if (_instance is null)
                _instance = new AppLogger();

            return _instance;
        }
    }

}
