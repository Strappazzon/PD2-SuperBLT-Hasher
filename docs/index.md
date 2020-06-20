---
layout: default
title: "SuperBLT Hasher | VB.Net implementation of SuperBLT Hashing Library"
description: "Visual Basic .Net implementation of the SuperBLT Hashing Library. Hashing of single files and folders is supported."
---

<h1 align="center">
  <br>
  <img src="https://strappazzon.github.io/PD2-SuperBLT-Hasher/static/img/favicon.png" width="128px" alt="">
  <br>
  SuperBLT Hasher
  <br>
</h1>

<h4 align="center">VB.Net implementation of SuperBLT Hashing Library.</h4>

<p align="center">
  <a href="#about">About</a> •
  <a href="#usage">Usage</a> •
  <a href="#settings">Settings</a> •
  <a href="#screenshot">Screenshot</a> •
  <a href="#download">Download</a> •
  <a href="#source-code">Source Code</a> •
  <a href="#license">License</a>
</p>

## About

SuperBLT Hasher is a Visual Basic .Net implementation of the [SuperBLT Hashing Library](https://gitlab.com/SuperBLT/HashLib). Hashing of single files and folders is supported.

## Usage

### GUI

1. Launch **SuperBLTHasher.exe**.
2. Customize the settings by ticking\unticking the checkboxes.
3. Drag and drop a folder or file inside the dark area where it says **"Drag a folder or file here"**.

### Command Line

SuperBLT Hasher accepts the following command line arguments:

| Name | Long Name     | Required? | Description                                                                                                  |
|------|---------------|-----------|--------------------------------------------------------------------------------------------------------------|
| `-p` | `--path`      | Yes       | Path to folder or file you want to hash. <br> If the path contains spaces, quotation marks are **required**. |
| `-e` | `--export`    | No        | If you include this argument, the program will ask you where you want to save the computed hash.             |
| `-c` | `--clipboard` | No        | If you include this argument, the program will copy the computed hash to the clipboard.                      |

#### Example

> SuperBLTHasher -p <span class="h-s">"D:\Path\To My Mod\Folder"</span> -c

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

<a href="https://strappazzon.github.io/PD2-SuperBLT-Hasher/static/img/screenshot.png">
  <img src="https://strappazzon.github.io/PD2-SuperBLT-Hasher/static/img/screenshot.png" alt="SuperBLT Hasher Screenshot">
</a>

## Download

You can [download](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest) the latest version of SuperBLT Hasher from the Releases page.

## Source Code

The complete SuperBLT Hasher source code is available [on GitHub](https://github.com/Strappazzon/PD2-SuperBLT-Hasher).

## License

By downloading and/or using SuperBLT Hasher, you are agreeing to the license terms.

> Copyright (c) 2020 Alberto Strappazzon
>
> Permission is hereby granted, free of charge, to any person obtaining a copy
> of this software and associated documentation files (the "Software"), to deal
> in the Software without restriction, including without limitation the rights
> to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
> copies of the Software, and to permit persons to whom the Software is
> furnished to do so, subject to the following conditions:
>
> The above copyright notice and this permission notice shall be included in all
> copies or substantial portions of the Software.
>
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
> IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
> FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
> AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
> LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
> OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
> SOFTWARE.
