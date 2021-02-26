#region "Copyright (c) 2019 - 2021 Alberto Strappazzon, https://strappazzon.xyz/PD2-SuperBLT-Hasher"
/*

 SuperBLT Hasher - VB.Net implementation of SuperBLT Hashing Library
 Copyright (c) 2020 Alberto Strappazzon, https://strappazzon.xyz/PD2-SuperBLT-Hasher

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 SOFTWARE.

*/
#endregion

using System;
using System.Diagnostics;
using System.IO;
using ZNix.SuperBLT;

namespace SuperBLTHasherCLI
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                // Title
                Console.Write(" ┌─┐┬ ┬┌─┐┌─┐┬─┐┌┐ ┬ ┌┬┐ "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("┬ ┬┌─┐┌─┐┬ ┬┌─┐┬─┐\n"); Console.ResetColor();
                Console.Write(" └─┐│ │├─┘├┤ ├┬┘├┴┐│  │  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("├─┤├─┤└─┐├─┤├┤ ├┬┘\n"); Console.ResetColor();
                Console.Write(" └─┘└─┘┴  └─┘┴└─└─┘┴─┘┴  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("┴ ┴┴ ┴└─┘┴ ┴└─┘┴└─\n"); Console.ResetColor();

                // Description
                Console.Write(" Generate hashes for "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("PAYDAY 2"); Console.ResetColor(); Console.Write(" mods\n");
                Console.Write(" Made by Strappazzon ("); Console.ForegroundColor = ConsoleColor.White; Console.Write("https://github.com/Strappazzon"); Console.ResetColor(); Console.Write(")\n\n");

                // Separator
                for (int i = 0; i < Console.BufferWidth; i++)
                {
                    Console.Write("=");
                }

                // Usage info
                string proc = Process.GetCurrentProcess().ProcessName;
                Console.Write("\n\n USAGE:\n\n");
                Console.Write("   " + proc + " file|directory\n\n");
                Console.Write("   file        File to hash\n");
                Console.Write("   directory   Folder to hash\n\n");
                Console.Write("   Example: " + proc + " \"D:\\Games\\PAYDAY 2\\mods\\My Mod\"\n");

                return 1;
            }

            try
            {
                bool isDir = (File.GetAttributes(args[0]) & FileAttributes.Directory) == FileAttributes.Directory;
                if (isDir)
                {
                    string hash = Hasher.HashDirectory(args[0]);
                    Console.WriteLine(hash);
                    return 0;
                }
                else
                {
                    string hash = Hasher.HashFile(args[0]);
                    Console.WriteLine(hash);
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
        }
    }
}
