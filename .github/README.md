<h1 align="center">
  <br>
  <img src="https://strappazzon.xyz/PD2-SuperBLT-Hasher/assets/img/favicon.png" width="128px" alt="SuperBLT Hasher Icon">
  <br>
  SuperBLT Hasher
  <br>
</h1>

<h4 align="center">VB.Net implementation of SuperBLT Hashing Library.</h4>

<p align="center">
  <a href="https://strappazzon.xyz/PD2-SuperBLT-Hasher"><img alt="HTML Version" src="https://img.shields.io/badge/HTML%20Version-%23ff5f2f?style=flat-square&logo=HTML5&logoColor=%23ffffff"></a>
  <a href="https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases"><img alt="GitHub All Releases" src="https://img.shields.io/github/downloads/Strappazzon/PD2-SuperBLT-Hasher/total?color=%231e72a5&label=Downloads&logo=DocuSign&logoColor=%23ffffff&style=flat-square"></a>
  <a href="https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest"><img alt="Latest Release" src="https://img.shields.io/github/v/release/Strappazzon/PD2-SuperBLT-Hasher?color=%23008080&include_prereleases&label=Latest%20Release&style=flat-square"></a>
</p>

<p align="center">
  <a href="#about">About</a> •
  <a href="#usage">Usage</a> •
  <a href="#settings">Settings</a> •
  <a href="#screenshot">Screenshot</a> •
  <a href="#download">Download</a> •
  <a href="#contributing">Contributing</a> •
  <a href="#license">License</a>
</p>

## About

SuperBLT Hasher is a Visual Basic .Net implementation of the [SuperBLT Hashing Library](https://gitlab.com/SuperBLT/HashLib). Hashing of single files and folders is supported.

## Usage

### GUI

1. Open **SuperBLTHasher.exe**.
2. Customize the settings by ticking\unticking the checkboxes.
3. Drag and drop a folder or file inside the dark area where it says **"Drag a folder or file here"**.

### Command Line

SuperBLT Hasher accepts the following command line arguments:

<table>
  <tr>
    <th align="left">Name</th>
    <th align="left">Long Name</th>
    <th align="left">Required?</th>
    <th align="left">Description</th>
  </tr>
  <tr>
    <td><code>-p</code></td>
    <td><code>-path</code></td>
    <td>Yes</td>
    <td>
      Path to folder or file you want to hash.
      <br>
      If the path contains spaces, quotation marks are <strong>required</strong>.
    </td>
  </tr>
  <tr>
    <td><code>-e</code></td>
    <td><code>--export</code></td>
    <td>No</td>
    <td>
      If you include this argument, the program will ask you where you want to save the computed hash.
    </td>
  </tr>
  <tr>
    <td><code>-c</code></td>
    <td><code>--clipboard</code></td>
    <td>No</td>
    <td>
      If you include this argument, the program will copy the computed hash to the clipboard.
    </td>
  </tr>
</table>

#### Example

```sh
SuperBLTHasher -p "D:\Path\To My Mod\Folder" -c
```

This command would compute the hash of the folder `D:\Path\To My Mod\Folder` and copy the computed hash to the clipboard.

## Settings

* **Write hash to file**
  * _Disabled by default_
  * The program will ask you where you want to save the computed hash

* **Copy hash to clipboard**
  * _Disabled by default_
  * The program will copy the computed hash to the clipboard

* **Check for updates**
  * _Disabled by default_
  * The program will connect to GitHub servers to check if the current version is up to date

All settings are stored inside a `user.cfg` file, in the same directory as SuperBLT Hasher.

## Screenshot

<img src="https://strappazzon.xyz/PD2-SuperBLT-Hasher/assets/img/screenshot.png" alt="SuperBLT Hasher Screenshot">

## Download

You can [download](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest) the latest version of SuperBLT Hasher from the Releases page.

## Contributing

If you are interested in fixing issues and contributing directly to the code base, please see:

* [Building SuperBLT Hasher from its source code](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/blob/master/BUILDING.md)
* [Contribution Guidelines](./CONTRIBUTING.md)
* [Code of Conduct](./CODE_OF_CONDUCT.md)

## License

```
Copyright (c) 2020 Alberto Strappazzon

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
