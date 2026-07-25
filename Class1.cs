using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CliWrap;

namespace Qiling.net
{
    public class Qiling
    {
        public async void Emulate(string OStoEmulate, string CPUtypeEmulatedOS, string PathToExecutable)
        {
            string PythonPath = "";
            if(OperatingSystem.IsWindows())
            {
                if(RuntimeInformation.OSArchitecture == Architecture.X86)
                {
                    PythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "./Windows/Python_x86.exe");
                }
                if(RuntimeInformation.OSArchitecture == Architecture.X64)
                {
                    PythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "./Windows/Python_x64.exe");
                }
                if(RuntimeInformation.OSArchitecture == Architecture.Arm64)
                {
                    PythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "./Windows/Python_arm64.exe");
                }
            }

            if(OperatingSystem.IsLinux())
            {
                
                if(RuntimeInformation.OSArchitecture == Architecture.X64)
                {
                    PythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "./Linux/Python_x64");
                }
                if(RuntimeInformation.OSArchitecture == Architecture.Arm64)
                {
                    PythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "./Linux/Python_arm64");
                }
            }

            if(OperatingSystem.IsMacOS())
            {
                if(RuntimeInformation.OSArchitecture == Architecture.X64)
                {
                    PythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "./MacOS/Python_x64.exe");
                }
                if(RuntimeInformation.OSArchitecture == Architecture.Arm64)
                {
                    PythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "./MacOS/Python_arm64.exe");
                }
            }

            if(OStoEmulate == "Windows" | OStoEmulate == "windows")
            {
                
            }

            if(OStoEmulate == "Linux" | OStoEmulate == "linux")
            {
                
            }

            if(OStoEmulate == "MacOS" | OStoEmulate == "macos")
            {
                
            }
        }
    }
}
