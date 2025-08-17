<p align="right">
  Language Switch / 语言选择：
  <a href="./README.zh-CN.md">🇨🇳 中文</a> | <a href="./README.md">🇬🇧 English</a>
</p>

**INTRODUCTION**
---
This solution is used to practice understanding and applying design principles, such as SOLID patterns and other
principles.

**PRIVACY NOTICE**
---
This application may require inputting personal information or private data to generate customised suggestions,
recommendations, and necessary results. However, please rest assured that the application does **NOT** collect, store,
or transmit your personal information. All processing occurs locally in the browser or runtime environment, and **NO**
data is sent to any external server or third-party service. The entire codebase is open and transparent — you are
welcome to review the code [here](./) at any time to verify how your data is handled.

**LICENCE**
---
This application is licensed under the [BSD-3-Clause License](LICENSE). You can click the link to read the licence.

**HOW TO USE git-changelog built with Node.js**
---

1. If capable, you can update the installation tool npm by running the following command`npm install -g npm@x.x.x`,
   where x.x.x is your target npm version. You can then verify the installed npm version in Rider by running
   `npx npm --version` or `npm -v`.
2. Use `git-changelog` (Node.js) to manage your changelog.
3. To begin with, you must create a file named `.gitignore` in the root of your repository. This file is essential for
   excluding files and directories from being tracked by Git. You can find a sample `.gitignore` file in this
   repository.
4. Then, you need to set up `version control System` (VCS) in Rider by connecting it to Git.
5. Install `git-changelog` in your terminal using the following command: `npm install -g git-changelog`. You can verify
   the installed git-changelog version in Rider by running `git-changelog --version`.
6. If you want to use the `git-changelog` tool in Rider to generate a changelog automatically, you must add a
   configuration file in the root of your repository. The file should be named `.changelogrc`. You can find an example
   of this file in the repository.
7. To generate a changelog automatically, you can run the command `git-changelog` in your terminal. This will create a
   `CHANGELOG.md` file is at the root of your repository based on the configuration in the `.changelogrc` file.
8. The `CHANGELOG.md` file will be updated automatically each time you run the `git-changelog` command.
9. The `CHANGELOG.md` is generated using ** the default template**. To change its format, customise the `template.md`
   and `commit_template.md` files inside the `templates` directory.
10. To know more about the `git-changelog` tool, you can check the
    official [documentation](https://github.com/rafinskipg/git-changelog).