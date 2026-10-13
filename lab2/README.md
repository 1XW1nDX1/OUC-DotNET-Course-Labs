
# Lab2 展板边框计算与表达式求值

- 开发工具：Visual Studio Community 2026
- 目标框架：.NET Framework 10.0

## 运行说明

### 1 - 桌面端计算

进入项目目录后，运行`.\bin\Release\net10.0-windows\Desktop.exe`，或使用Visual Studio自带的调试功能启动

测试用例如题目，结果全部通过，额外测试用例为w,h,b:21，16，0.5，手算期望结果为展示面积 300.00，边框面积 36.00，外周长 74.00，结果也通过

### 2 - Web 端计算

进入项目目录后，运行`.\bin\Release\net10.0\Web.exe`启动API，或使用Visual Studio自带的调试功能启动。

API测试地址为`http://localhost:5156/api/frame/calculate`，可以手动POST或使用Visual Studio配合项目中的test.http进行测试

测试用例如test.http，已包含额外测试用例（跟任务一一样）

#### 拓展任务

已完成，现在可以通过JSON发送请求并收到JSON响应（原有的文本响应也保留下来了），test.http中的额外测试用例就是用JSON的请求

### 3 - 表达式求值

进入项目目录后，运行`​.\bin\release\net10.0\Console1.exe`​，或使用Visual Studio自带的调试功能启动

期望输出：

```shell
运行结果为：False，此时x=13，y=17
运行结果为：True，此时x=13，y=18
```
