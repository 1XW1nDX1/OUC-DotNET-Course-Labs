# Lab3 温度校准值搜寻器

- 开发工具：Visual Studio Community 2026
- 目标框架：.NET Framework 10.0

## 运行说明

进入项目目录后，运行`.\bin\Release\net10.0-windows\Temperature Calibration Value Searcher.exe`，或使用Visual Studio自带的调试功能启动

## 任务核心说明

### 1 - 创建一轮校准

定义了一个`StartNewCircle()`函数，用来在点击“开始新一轮”后在目标范围内生成一个随机目标值，赋值给全局变量`targetTemperature`并设置当前有效区间

随机生成的目标值除了测试函数外没有修改入口，从而保持目标值不变

在Form1实例化的时候开始设置一些初始值，并在FormLoad的时候调用一次`StartNewCircle()`自动开始新一轮

### 2 - 校验并更新区间

### 3 - 历史记录与循环

## 拓展任务

已完成，现在可以通过JSON发送请求并收到JSON响应（原有的文本响应也保留下来了），test.http中的额外测试用例就是用JSON的请求

### 3 - 表达式求值

进入项目目录后，运行`​.\bin\release\net10.0\Console1.exe`​，或使用Visual Studio自带的调试功能启动

期望输出：

```shell
运行结果为：False，此时x=13，y=17
运行结果为：True，此时x=13，y=18
```
