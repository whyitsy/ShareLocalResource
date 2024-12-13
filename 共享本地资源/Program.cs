var builder = WebApplication.CreateBuilder(args);

// 启用目录浏览
builder.Services.AddDirectoryBrowser();


var app = builder.Build();


// 启用目录浏览
app.UseDirectoryBrowser(new DirectoryBrowserOptions());

app.UseStaticFiles(new StaticFileOptions()
{
    // 配置文本文件以utf-8显示
    OnPrepareResponse = ctx =>
    {
        if (ctx.File.Name.EndsWith(".txt") || ctx.File.Name.EndsWith(".md"))
        {
            ctx.Context.Response.ContentType = "text/plain; charset=utf-8";
        }
    }
});


app.Run();