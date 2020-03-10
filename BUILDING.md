# Building SuperBLT Hasher from its source code

This file should assist you in compiling and running SuperBLT Hasher.

## Building requirements

* [.NET Framework 4.6.1 or newer](https://dotnet.microsoft.com/download/dotnet-framework).
* Visual Studio. You can [download the community edition](https://visualstudio.microsoft.com/vs/community/) for free.
  * The ".NET desktop development" Workload is required.

## Getting the source code

Clone the repository via Git:

```cmd
git clone https://github.com/Strappazzon/PD2-SuperBLT-Hasher.git PD2-SuperBLT-Hasher
cd PD2-SuperBLT-Hasher
```

Alternatively, you can clone the repository via any Git client, or download a zip archive of the repository [from here](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/archive/master.zip).

## Getting HashLib

1. Navigate to the HashLib [GitLab repository](https://gitlab.com/SuperBLT/HashLib).
2. Open the `c#` folder and [download the archive](https://gitlab.com/SuperBLT/HashLib/-/archive/master/HashLib-master.zip?path=c%23) of this directory.
3. Extract the downloaded archive.

## Building with Visual Studio

1. Start Visual Studio.
2. Select **Open a project or solution** and open the `HashLib.sln` solution file.
3. Compile HashLib using **Build** -> **Build Solution**.
   * The compiled DLL will be inside the `.\HashLib\bin\Debug` folder
4. Copy the DLL where `SuperBLTHasher.sln` is (In this case: `.\PD2-SuperBLT-Hasher\src\SuperBLTHasher.sln`).
5. Close the HashLib solution and open the `SuperBLTHasher.sln` solution file located in your cloned repository (In this case: `.\PD2-SuperBLT-Hasher\src\SuperBLTHasher.sln`).
6. Compile SuperBLT Hasher using **Build** -> **Build Solution**.
   * The compiled binary will be inside the `.\src\bin\Debug` folder.
