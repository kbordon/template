* create .csproj file and Startup.cs, run dotnet restore for every project
* dotnet build
* to add static files
     * > dotnet add package Microsoft.AspNetCore.StaticFiles -v 1.1.3
     * To Startup.cs, in the Configure() method: app.UseStaticFiles();
* Request.Query["input-id"] for Get
* Request.Form["input-id"] for set
* app.UseDeveloperExceptionPage()
