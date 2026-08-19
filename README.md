# 八宝粥的多MC服务端管理面板（BBZ MCServers Manager）

> ⚠️ **开发已暂停** —— 本仓库仅存档源码，不再继续维护。下一代基于 C# 重写的项目 **Prime-Minecraft-Servers-Engine（PMCSsE）仍在开发中、尚未稳定可用**，详见下文。

这是一个用于管理多个 Minecraft 服务端的图形化工具（WinForms / VB.NET）。它通过 **RCON** 远程控制 MC 服务端、通过 **SFTP** 上传/下载文件，并使用 **7z** 进行备份/回档，可同时管理多台机器上的多个服务端实例。

## 功能特性

- **多服务端统一管理**：在一个面板里集中监控、启停多个 Minecraft 服务端实例。
- **RCON 远程控制**：向服务端发送控制台命令（如 `list`、停服、保存世界等），并实时读取返回。
- **SFTP 文件传输**：经 SSH/SFTP 上传、下载、删除服务端文件。
- **备份与回档**：基于 7z 压缩，支持完整备份、增量备份，以及单文件、仅变化部分等回档模式。
- **定时任务执行器**：可配置周期性的自动化操作（如定期备份）。
- **日志系统**：独立的日志窗口，记录运行状态与错误信息。
- **异步改造**：耗时操作（RCON/SFTP/备份/定时任务）已移入后台线程，移除了原来的 `Application.DoEvents()` 轮询，大幅降低 CPU 占用。

## 版本与目录

- `9865178` — **alpha3.3**：原始 VB.NET 源码
- `45dc397` — **alpha3.4**：反编译恢复 + 异步改造后的 VB.NET 源码

```
BBZ_MCServers_Manager\  主工程源码（VB.NET / WinForms，.NET 8）
配置文件\                配置文件（含本机路径与测试凭据，已被 .gitignore 排除，不入库）
```

## ⚠️ 为什么停止维护？

本项目是基于 **MSI 安装包反编译恢复**的源码。原安装包只发布了编译后的程序，并没有提供可读的源代码，因此本仓库的代码是通过反编译工具（ILSpy）还原、再转写为 VB.NET 得到的。

这意味着：

- **代码可读性差**：反编译产物保留了编译器生成的内部成员、`internal virtual` 属性、冗长的委托调用，逻辑晦涩。
- **维护成本极高**：修改任何一处都可能牵动大量反编译遗留的样板代码，风险大、见效慢。
- **难以扩展**：结构混乱、命名不规则，难以在此基础上继续增加功能或修复问题。

因此**已暂停对本仓库的开发**，并决定基于原功能用更现代、更清晰的语言 **C#** 从头重写。

## ✅ 下一代项目：Prime-Minecraft-Servers-Engine（PMCSsE）

本工具已决定基于原功能用更现代、更清晰的语言 **C#** 从头重写，新项目为：

### 🔗 [Prime-Minecraft-Servers-Engine](https://github.com/babaozhouO/Prime-Minecraft-Servers-Engine)（[使用文档](https://babaozhouo.github.io/Prime-Minecraft-Servers-Engine/)）

> ⚠️ **注意**：该项目**仍在开发中，未经严格稳定性测试**，且采用**前后端分离**架构——在前后端通信完成之前，已实现的功能还**无法使用**。请**谨慎使用**，只建议使用**正式发布版本**。

**项目概览**（源自新项目 README，进度以线上仓库为准）：

| 组件 | 技术栈 | 平台 | 状态 |
|------|--------|------|------|
| 后端 | .NET 10.0 | Windows / Linux / macOS | 开发中（~20%） |
| 前端 | Avalonia（MVVM+事件驱动） | Win10/11、Linux、macOS、iOS、Android | 开发中（~15%） |
| 前端 | WPF（事件驱动） | Windows 10/11 | 停更 |
| [Yuzu 前端（第三方）](https://github.com/LLP773/PMCSsE_Yuzu-Frontend) | Avalonia（MVVM+事件驱动） | 多平台 | 第三方维护 |

**已实现 / 规划中的功能**：

- 托管（多个）服务端，快速启停、查看日志、命令输入 —— ✔
- 服内外互联系统（无需 QQ 机器人，稳定易用）—— ✔
- 全量备份 —— ✔
- 发送文件至 SFTP 文件服务器 —— 90%
- 快速打开服务端目录 / 模组 / 插件文件夹等 —— 30%
- 前后端通信 —— 80%
- 自动下载并部署服务端、资源监控、玩家列表、文件级/块级增量备份、智能命令补全等 —— 规划中

> 若你希望使用或参与下一代工具，请前往
> **[Prime-Minecraft-Servers-Engine](https://github.com/babaozhouO/Prime-Minecraft-Servers-Engine)**。
> **本仓库仅供归档历史版本使用，不再维护。**

## 许可

本项目以 Apache License 2.0 开源，详见 [LICENSE.txt](LICENSE.txt)。
