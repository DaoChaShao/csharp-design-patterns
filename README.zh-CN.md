<p align="right">
  Language Switch / 语言选择：
  <a href="./README.zh-CN.md">🇨🇳 中文</a> | <a href="./README.md">🇬🇧 English</a>
</p>

**方案简介**
---  
此解决方案用于练习理解和应用设计原则，例如 **SOLID 模式** 以及其他原则。

**隐私声明**
---  
本应用可能需要输入个人信息或隐私数据，以生成定制化的建议、推荐和必要的结果。但是请放心，本应用 **不会**
收集、存储或传输您的个人信息。所有处理均在浏览器或运行时环境中本地完成，**不会**
将任何数据发送到外部服务器或第三方服务。整个代码库是开放且透明的 —— 您可以随时在 [这里](./) 查看代码，以验证数据处理方式。

**许可协议**
---  
本应用基于 [BSD-3-Clause License](LICENSE) 授权。您可以点击链接查看完整的许可协议。

**如何使用基于 Node.js 的 git-changelog**
---  

1. 如果有需要，可以通过运行以下命令更新 npm 工具：`npm install -g npm@x.x.x`，其中 x.x.x 是您目标的 npm 版本。然后，您可以在
   Rider 中运行 `npx npm --version` 或 `npm -v` 来验证已安装的 npm 版本。
2. 使用 `git-changelog`（Node.js）来管理您的变更日志。
3. 首先，您需要在您的仓库根目录下创建一个名为 `.gitignore` 的文件。该文件对于排除文件和目录不被 Git 跟踪是必需的。您可以在此仓库中找到一个示例
   `.gitignore` 文件。
4. 然后，您需要在 Rider 中设置 `版本控制系统`（VCS），并将其连接到 Git。
5. 在终端中使用以下命令安装 `git-changelog`：`npm install -g git-changelog`。您可以在 Rider 中运行
   `git-changelog --version` 来验证已安装的 git-changelog 版本。
6. 如果您希望在 Rider 中使用 `git-changelog` 工具自动生成变更日志，您需要在仓库根目录下添加一个配置文件。该文件应命名为
   `.changelogrc`。您可以在仓库中找到此文件的示例。
7. 要自动生成变更日志，您可以在终端中运行命令 `git-changelog`。这将根据 `.changelogrc` 文件中的配置在您的仓库根目录下创建一个
   `CHANGELOG.md` 文件。
8. 每次运行 `git-changelog` 命令时，`CHANGELOG.md` 文件将自动更新。
9. `CHANGELOG.md` 是使用 **默认模板** 生成的。要更改其格式，请自定义 `templates` 目录中的 `template.md` 和
   `commit_template.md` 文件。
10. 要了解更多关于 `git-changelog` 工具的信息，您可以查看官方 [文档](https://github.com/rafinskipg/git-changelog)。
   