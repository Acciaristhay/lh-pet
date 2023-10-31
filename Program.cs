namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "projeto - LH pets versão 1 ");

        app.UsesTatitcFiles();
        app.MapGet("/index", (HttpContext contexto)=> {
             contexto.Response.Redirect("index.html," false);

        } );

        app.Run();
    }
}
