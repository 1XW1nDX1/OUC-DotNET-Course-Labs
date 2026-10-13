# Lab1 校园科创展的三个应用入口

- 开发工具：Visual Studio Community 2026
- 目标框架：.NET Framework 10.0

## 各项目启动方式

### 1 - 控制台欢迎页

进入项目目录后，运行`.\bin\release\net10.0\ExpoConsole.exe`，或使用Visual Studio自带的调试功能启动

期望输出：

```Shell
校园科创展服务台
开发者：25030021018
负责展区：海洋科技
```

### 2 - 展位提示窗体

进入项目目录后，运行`.\bin\Release\net10.0-windows\ExpoDesktop.exe`，或使用Visual Studio自带的调试功能启动

期望输出：弹出弹窗，并按照题目要求执行

#### 拓展任务 - 1

本项目已处理拓展任务1中的*在窗体中处理空串和仅含空格的输入，提示后不覆盖上一次有效结果。*功能。

#### 拓展任务 - 3

进入ExpoWPF项目目录，运行`.\bin\Release\net10.0-windows\ExpoWPF.exe"，或使用Visual Studio自带的调试功能启动

期望输出：弹出弹窗，并按照题目要求执行（不包含*在窗体中处理空串和仅含空格的输入，提示后不覆盖上一次有效结果。*功能）。

### 3 - 服务状态接口

进入项目目录后，运行`.\bin\Release\net10.0\ExpoApi.exe`启动API，或使用Visual Studio自带的调试功能启动。

API测试地址为`http://localhost:7777/lab1/status`，可以手动POST或使用Visual Studio配合项目中的ExpoApi.http进行测试

期望输出：EXPO-READY|25030021018|海洋科技
