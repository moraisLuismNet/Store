## Store

**Store** is an ASP.NET Core web API for a store, managing categories, products, and users. It includes controllers for CRUD operations and features such as pagination, filtering, image file management, and JWT authentication/authorization. It implements services for action logging, file management, password encryption and hashing, and a scheduled task. Entity Framework Core is configured for interaction with a SQL Server database, with DTOs for data transfer and validators for data input. Finally, development and production configurations, a Dockerfile, and a Docker-Compose for container deployment are provided.

![Store](img/UML.png)

Store/  
├───Classes/  
│   └───ResultHash.cs  
├───Controllers/  
│   ├───ActionsController.cs  
│   ├───CategoriesController.cs  
│   ├───ProductsController.cs  
│   └───UsersController.cs  
├───DTOs/  
│   ├───CategoryDTO.cs  
│   ├───CategoryInsertDTO.cs  
│   ├───CategoryItemDTO.cs  
│   ├───CategoryProductDTO.cs  
│   ├───CategoryUpdateDTO.cs  
│   ├───LoginResponseDTO.cs  
│   ├───ProductDTO.cs  
│   ├───ProductFilterDTO.cs  
│   ├───ProductInsertDTO.cs  
│   ├───ProductSaleDTO.cs  
│   ├───ProductUpdateDTO.cs  
│   ├───UserChangePasswordDTO.cs  
│   └───UserDTO.cs  
├───Filters/  
│   └───ExceptionFilter.cs  
├───Middlewares/  
│   └───RegisterAndControlMiddleware.cs  
├───Models/  
│   ├───Action.cs  
│   ├───Category.cs  
│   ├───Product.cs  
│   ├───StoreContext.cs  
│   └───User.cs  
├───Services/  
│   ├───ActionsService.cs  
│   ├───FileManagerService.cs  
│   ├───HashService.cs  
│   ├───IFileManagerService.cs  
│   ├───ScheduledTaskService.cs  
│   └───TokenService.cs  
├───Validators/  
│   ├───GroupFileType.cs  
│   ├───ValidationFileType.cs  
│   └───WeightFileValidation.cs  
├───appsettings.Development.json  
├───appsettings.json  
├───Dockerfile  
└───Program.cs  

![Store](img/1.png)
![Store](img/2.png)


## Program
``` 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<StoreContext>(options =>
    options.UseSqlServer(connectionString)
);
``` 

## appsetting.Development.json
``` 
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=*;Initial Catalog=Store;Integrated Security=True;Encrypt=False"
  }
}
``` 

![Store](img/DB.png)

[DeepWiki moraisLuismNet/Store](https://deepwiki.com/moraisLuismNet/Store)
