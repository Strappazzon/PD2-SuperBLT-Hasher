# Contribution Guidelines

By participating, you agree to abide by the [Code of Conduct](https://github.com/Strappazzon/.github/blob/-/CODE_OF_CONDUCT.md).  
When submitting changes to this repository, you agree that the content you contribute may be provided under the terms of the [MIT License](https://opensource.org/licenses/MIT).

## I Have a Question

Before you ask a question, search for existing [Issues](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/issues) that might help you.  
In case you have found a suitable issue and still need clarification, you can write your question in that issue. It is also advisable to search the internet for answers first.

If you then still need to ask a question and need clarification you can [open an issue](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/issues/new/choose).

## Issue Reporting and Feature Requests

> [!CAUTION]
> If you found a security issue, **DO NOT** report it in the issue tracker or elsewhere in public.  
> See: [Security Policy](https://github.com/Strappazzon/.github/blob/-/SECURITY.md).

- Take a look at the [issues](https://github.com/Strappazzon/PD2-SuperBLT-Hasher/issues) first to make sure your issue/feature hasn't been reported/requested before.  
  If so, engage in the already existing discussion.
- Check whether your issue/feature is already fixed/implemented.
- Issues in languages other than English will be closed and ignored.
- If you are familiar with the languages used in this repo, you are always welcome to fix/implement an issue/feature yourself.
- Add one issue at a time. Do not put multiple issues into one thread.
- When reporting a bug please describe the steps which reproduce the problem.
- When reporting a crash include the stack trace from SuperBLT Hasher (click the "**▼ Details**" button in the crash dialog).
  Include the stack trace text in the Issue in a [file attachment](https://help.github.com/en/github/managing-your-work-on-github/file-attachments-on-issues-and-pull-requests) or put it in a
  [PrivateBin](https://privatebin.net/) ([PasteBin](https://pastebin.com/) is fine too) and provide the link to that paste.
- All issues must be properly formatted with Markdown.  
  If you don't know what that is, read [Basic writing and formatting syntax](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax) before submitting an issue.

### DO NOT post "+1" comments

If you don't have any additional info/context to add but would like to indicate that you're affected by the issue, upvote the original issue.  
See: [Add Reactions](https://github.blog/news-insights/product-news/add-reactions-to-pull-requests-issues-and-comments/)

## Getting Started

Before you can start contributing, you'll need to set up your environment first.

### Website

See [docs/README.md](../docs/README.md).

### Application

#### Dependencies

SuperBLT Hasher is written in [Visual Basic (.NET)](https://learn.microsoft.com/en-us/dotnet/visual-basic/) and [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
so you will need the following dependencies installed:

- [Visual Studio](https://visualstudio.microsoft.com/vs/)
  - You can [download the community edition](https://visualstudio.microsoft.com/vs/community/) for free
  - The "**.NET desktop development**" Workload is required
  - The "**.NET Framework 4.8.1 targeting pack**" Individual component is required
  - The "**NuGet package manager**" Individual component is required
- [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
- [.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)

#### Building (CLI)

1. [Download](https://gitlab.com/SuperBLT/HashLib/tree/05b104ea/c%23) and compile HashLib
2. Copy the output DLL inside `.\gui`
3. From Visual Studio, select **Open a project or solution**, then open the solution file `SuperBLTHasherCLI.sln`
4. Compile using **Build** -> **Build Solution**
   - The compiled binary will be inside the `.\cli\bin` folder

#### Building (GUI)

1. [Download](https://gitlab.com/SuperBLT/HashLib/tree/05b104ea/c%23) and compile HashLib
2. Copy the output DLL inside `.\gui`
3. From Visual Studio, select **Open a project or solution**, then open the solution file `SuperBLTHasher.sln`
4. Compile using **Build** -> **Build Solution**
   - The compiled binary will be inside the `.\gui\bin` folder

## Code style and Conventions

### C\#

The general rule this project follows is "use Visual Studio defaults".
Using an IDE that supports the [.editorconfig](https://editorconfig.org/) standard will make this much simpler.

- Use `this.` even if not necessary
- Use camelCase when naming variables

### Visual Basic .NET

The general rule this project follows is "use Visual Studio defaults".
Using an IDE that supports the [.editorconfig](https://editorconfig.org/) standard will make this much simpler.

- Use `Me.` even if not necessary
- Use PascalCase when naming variables

### Markdown

Documentation is written in [GitHub Flavored Markdown](https://docs.github.com/en/get-started/writing-on-github).  
Some website pages are written in [GitHub Flavored Markdown](https://docs.github.com/en/get-started/writing-on-github)
and rendered by [kramdown](https://kramdown.gettalong.org/).

In both cases, [markdownlint](https://github.com/DavidAnson/markdownlint) is used to enforce style rules for Markdown files.

## Submitting Changes

- Make changes on a separate branch, not on the master branch, then send your changes as a
  [Pull Request](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-pull-requests).

  ```ps1
  git checkout -b MyNewFeature master
  ```

- When submitting changes, you confirm that your code is licensed under the terms of the [MIT License](https://opensource.org/licenses/MIT).
- Please test your code before you submit changes. Untested code will **not** be merged!
- Make sure your Pull Request is up-to-date with the rest of the codebase.

## Git Commit Messages

- Use the present tense ("Add feature" not "Added feature").
- Use the imperative mood ("Move cursor to..." not "Moves cursor to...").
- Wrap all lines at 70 columns (except for long URLs).
- Writing a detailed description is not mandatory.
- Reference issues and Pull Requests after the description, if any.  
  Use `Closes:` or `Fixes:`.

### Sample Complete Commit Message

```plaintext
explain the commit in one line

The body of the commit message should explain things in more detail.
Please word-wrap to keep columns to 70 characters or less.

Fixes: https://github.com/Strappazzon/PD2-SuperBLT-Hasher/issues/1771
```

## Repository Structure

This is a brief description on how the repository files and folders are structured and what each one contains.  
It only contains the most relevant files and folders as some of them are self-explanatory.

```sh
.
├── docs                         # Website source
├── src                          # SuperBLT Hasher source
│   ├── cli
│   ├── gui
│   │   ├── SuperBLTHasher.UI    # UI components
│   │   ├── SuperBLTHasher.Utils # Helper classes
│   │   ├── My Project           # Project data and configuration
│   │   └── Resources            # Assets
│   └── Licenses                 # Third party license notices
└── version                      # Version number used bu SuperBLT Hasher updater
```
