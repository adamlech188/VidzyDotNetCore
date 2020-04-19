REM This is to install EF Core 3.x
dotnet tool install --global dotnet-ef
REM this package add EF tools 
dotnet add package Microsoft.EntityFrameworkCore.Design
REM This is to install provider for SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
REM Scaffold database
dotnet-ef dbcontext scaffold "Server=DESKTOP-1LQNN3A\\SQLEXPRESS;Database=Vidzy;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --context VidzyContext --context-dir VidzyDbContext --output-dir Models --json --force