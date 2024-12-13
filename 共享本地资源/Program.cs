var builder = WebApplication.CreateBuilder(args);

// ����Ŀ¼���
builder.Services.AddDirectoryBrowser();


var app = builder.Build();


// ����Ŀ¼���
app.UseDirectoryBrowser(new DirectoryBrowserOptions());

app.UseStaticFiles(new StaticFileOptions()
{
    // �����ı��ļ���utf-8��ʾ
    OnPrepareResponse = ctx =>
    {
        if (ctx.File.Name.EndsWith(".txt") || ctx.File.Name.EndsWith(".md"))
        {
            ctx.Context.Response.ContentType = "text/plain; charset=utf-8";
        }
    }
});


app.Run();