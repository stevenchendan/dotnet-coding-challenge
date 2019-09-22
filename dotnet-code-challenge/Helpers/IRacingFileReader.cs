using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Helpers
{
    public interface IRacingFileReader
    {
        bool DisplayHorsesFromFile(string path);
    }
}
