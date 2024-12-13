+ .NET8 SDK https://dotnet.microsoft.com/zh-cn/download。编译运行后发布，采用独立框架。
+ 配置防火墙：控制面板->系统和安全->Windows Defender防火墙->高级设置->入栈规则，将原本添加的规则删掉，新建规则，指定TCP端口。测试其他设备能否通过ip:port访问
+ 控制面板->程序->启用或关闭Windows功能->打开两个IIS服务
+ 安装相关环境：https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-9.0.0-windows-hosting-bundle-installer
+ 搜索IIS manager，添加网站，选择发布的文件夹，指定防火墙放行的端口。
