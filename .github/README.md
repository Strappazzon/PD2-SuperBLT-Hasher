<h1 align="center">
  <br>
  <img src="https://strappazzon.github.io/PD2-SuperBLT-Hasher/static/img/favicon.png" width="128px" alt="">
  <br>
  SuperBLT Hasher
  <br>
</h1>

<h4 align="center">Generate hashes for PAYDAY 2 mods.</h4>

<p align="center">
  <a href="https://strappazzon.xyz/PD2-SuperBLT-Hasher">
    <img alt="HTML Version" src="https://img.shields.io/badge/HTML%20Version-%23ff5f2f?style=flat-square&logo=HTML5&logoColor=%23ffffff">
  </a>
  <a href="https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases">
    <img alt="GitHub All Releases" src="https://img.shields.io/github/downloads/Strappazzon/PD2-SuperBLT-Hasher/total?color=%231e72a5&label=Downloads&logo=DocuSign&logoColor=%23ffffff&style=flat-square">
  </a>
  <a href="https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest">
    <img alt="Latest Release" src="https://img.shields.io/github/v/release/Strappazzon/PD2-SuperBLT-Hasher?color=%23008080&include_prereleases&label=Latest%20Release&style=flat-square">
  </a>
</p>

<p align="center">
  <a href="#about">About</a> •
  <a href="#usage">Usage</a> •
  <a href="#screenshot">Screenshot</a> •
  <a href="#download">Download</a> •
  <a href="#contributing">Contributing</a> •
  <a href="#license">License</a>
</p>

## About

SuperBLT Hasher is a Visual Basic .Net/C# implementation of the [SuperBLT Hashing Library](https://gitlab.com/SuperBLT/HashLib). Hashing of single files and folders is supported.

## Usage

### GUI

1. Launch **SuperBLT Hasher.exe**.
2. Drag and drop a folder or file inside the dark area where it says **"Drag a folder or file here"**.
3. Copy the hash to clipboard.

### Command Line

Simply pass the file or folder path to **superblthasher-cli.exe**.

#### Example

```bash
> superblthasher-cli "D:\Path\To Mod\Folder"
```

## Screenshot

<img src="https://strappazzon.github.io/PD2-SuperBLT-Hasher/static/img/screenshot.png" alt="SuperBLT Hasher GUI Screenshot">

## Download

You can [download](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest) the latest version of SuperBLT Hasher from the Releases page.

## Contributing

If you are interested in fixing issues and contributing directly to the code base, please see:

* [Building SuperBLT Hasher from its source code](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/blob/master/BUILDING.md)
* [Contribution Guidelines](./CONTRIBUTING.md)
* [Code of Conduct](./CODE_OF_CONDUCT.md)

## License

```
Copyright (c) 2020 - 2021 Alberto Strappazzon

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
```
