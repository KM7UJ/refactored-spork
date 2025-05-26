Създаване на проект
- ASP.NET Web Core API (Model-View-Controller)
- Authentication Type: Individual accounts
- Framework: NET Core 3.1

1. Създаване на модел
**!** Всеки модел задължително трябва да има ID поле
2. Миграция
`Add-Migration MigrationName`
`Update-Database`
3. Създаване на контролер `MVC Controller with views, using Entity Framework`
4. Добавяне в `Views/Shared/_Layout.cshtml` бутон водещ до Изгледа на модела
```html
<li class="nav-item">
  <a class="nav-link" asp-area="" asp-controller="ViewName" asp-action="Index">Името на изгледа</a>
</li>
```
5. Идентификация (Areas - Add new area - Identity - Register Login Logout)
6. Services (Startup.cs)

`ConfigureServices`
```cs
services.AddIdentity<IdentityUser, IdentityRole>()
	.AddEntityFrameworkStores<ApplicationDbContext>()
```
`Configure`
```cs
using (var serviceScope = app.ApplicationServices.CreateScope())
{
    using (var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
    {
        context.Database.Migrate();
        if (!context.Roles.Any())
        {
            context.Roles.Add(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
            });
            context.Roles.Add(new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
            });
            context.SaveChanges();

        }
    }
}
```
7. Добавяне на задаване на роли админ за първият регистриран (Register.cshtml.cs)
Пише се след `if(result.Succeeded)`
```cs
if (_userManager.Users.Count() == 1)
{ 
	await _userManager.AddToRoleAsync(user, "Admin"); 
}
else
{ 
	await _userManager.AddToRoleAsync(user, "User"); 
}
```
