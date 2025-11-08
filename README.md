# .NET Core, API RESTful, SQL Server, JWT autenticación, backend profesional, Desarrollo web con C#

> [ENG/SPA]

<https://www.udemy.com/course/backend-net-core/>

| #   | Section Content (SPA)                                      | Lectures | Duration    | 📂                                                               |
| --- | ---------------------------------------------------------- | -------- | ----------- | ---------------------------------------------------------------- |
| 1   | Introduction                                               | 4        | 23 min      | [open](./01-introduction/README.md)                              |
| 2   | Breve introducción a C# y fundamentos esenciales para .NET | 11       | 1 hr 1 min  | [open](./02-breve-intro-a-dotnet/README.md)                      |
| 3   | Creación de proyecto                                       | 8        | 28 min      | [open](./03-creacion-de-proyecto/README.md)                      |
| 4   | Creación de categoría                                      | 9        | 25 min      | [open](./03-creacion-de-proyecto/README.md)                      |
| 5   | Repositorio categoría                                      | 6        | 16 min      | [open](./03-creacion-de-proyecto/README.md)                      |
| 6   | API Categoría                                              | 13       | 52 min      | [open](./03-creacion-de-proyecto/README.md)                      |
| 7   | API Producto                                               | 19       | 1 hr 44 min | [open](./03-creacion-de-proyecto/README.md)                      |
| 8   | API Usuario, autenticación y JWT                           | 16       | 1 hr 10 min | [open](./08-api-usuario-autenticacion-y-jwt/README.md)           |
| 9   | CORS                                                       | 6        | 13 min      | [open](./09-cors/README.md)                                      |
| 10  | Autorización                                               | 9        | 47 min      | [open](./10-autorizacion/README.md)                              |
| 11  | Caché                                                      | 7        | 21 min      | [open](./11-cache/README.md)                                     |
| 12  | Versionando API                                            | 11       | 43 min      | [open](./12-versionando-api/README.md)                           |
| 13  | Autenticación y autorización con Identity                  | 11       | 49 min      | [open](./13-autenticacion-y-autorizacion-con-identity/README.md) |
| 14  | Implementar subida de imagen                               | 7        | 31 min      | [open](./14-implementar-subida-de-imagen/README.md)              |
| 15  | Seed, paginación y uso de agente                           | 10       | 51 min      | [open](./15-seed-paginacion-y-uso-de-agente/README.md)           |
| 16  | Publicando API en Azure                                    | 8        | 37 min      | [open](./16-publicando-api-en-azure/README.md)                   |
| 17  | Fin del curso                                              | 1        | 2 min       | [open](./17-fin-del-curso/README.md)                             |

## Course Description

This course provides a complete, hands-on guide to building a professional RESTful API from scratch using **.NET Core 8**. Throughout 17 modules, you’ll learn how to design and implement backend systems with **Entity Framework Core**, apply **JWT-based authentication and role-based authorization**, and follow best practices such as the **repository pattern**, **API versioning**, and **pagination**. You’ll also configure **SQL Server databases**, add **image upload functionality**, and finally **deploy your API to Azure**, simulating a real production environment.

## [SPA] Conceptos Clave

Sin descripción: Sección 1

### Sección 2

Esta sección tiene por objetivo dar unas bases sobre C# con la idea de que se familiaricen con los conceptos comunes usados en el día a día con .NET.

- Tipos básicos
- Clases e Interfaces
- Herencia
- Patrón adaptador
- Inyección de dependencias
- Métodos asíncronos
- Atributos o decoradores

### Sección 3

Esta sección tiene por objetivo sentar las bases necesarias para iniciar el desarrollo de una API con .NET. Aprenderemos a crear y configurar un proyecto desde cero, entendiendo su estructura interna y los elementos clave para el desarrollo backend profesional.

- ¿Qué es .NET y cómo funciona en el ecosistema de desarrollo?
- Creación y configuración inicial de un proyecto .NET.
- Explicación detallada del archivo Program.cs y su rol en la aplicación.
- Organización de la estructura de directorios del proyecto.
- Configuración de un contenedor Docker con SQL Server para la persistencia de datos.

### Sección 4

Esta sección tiene por objetivo construir la entidad Categoría, conectarla a la base de datos y realizar la primera migración con Entity Framework Core.
Es un paso fundamental para comenzar a manejar datos de manera estructurada en nuestra API.

- Definición del modelo Categoría con sus propiedades esenciales.
- Configuración de la conexión con la base de datos SQL Server.
- Instalación de paquetes necesarios para trabajar con EF Core
- Creación del archivo de contexto (DbContext).
- Configuración de la cadena de conexión en el proyecto en Program.cs.
- Ejecución de la primera migración y actualización de la base de datos

### Sección 5

Esta sección tiene por objetivo introducir el patrón repositorio, una técnica comúnmente utilizada para desacoplar la lógica de acceso a datos del resto de la aplicación, promoviendo buenas prácticas y una arquitectura más limpia.

- Introducción al patrón repositorio en aplicaciones .NET.
- Creación de una interfaz ICategoryRepository para definir las operaciones del repositorio.
- Implementación concreta del repositorio CategoryRepository para acceder a los datos de la entidad Categoría.

### Sección 6

Esta sección tiene por objetivo trabajar con la entidad Categoría desde el controlador, utilizando buenas prácticas como el uso de DTOs y AutoMapper. También aprenderemos a implementar los endpoints necesarios para realizar operaciones CRUD completas.

- Qué es un DTO (Data Transfer Object) y por qué es útil
- Cómo crear un DTO específico para la entidad Categoría
- Configuración básica de AutoMapper para mapear entre entidades y DTOs
- Introducción a controladores de tipo API
- Implementación de endpoints para:
- Listar todas las categorías
- Obtener una categoría por ID
- Manejar errores cuando la categoría no existe
- Crear una nueva categoría
- Actualizar una categoría existente
- Eliminar una categoría

### Sección 7

Esta sección tiene por objetivo construir todos los elementos necesarios para gestionar productos en nuestra API, desde el modelo de datos y su relación con las categorías, hasta la implementación de endpoints avanzados con filtros y búsquedas.

- Creación del modelo Producto y su relación con la entidad Categoría
- Migración para reflejar el modelo Producto en la base de datos
- Definición de DTOs específicos para Producto
- Creación de la interfaz de repositorio para producto
- Implementación del repositorio para acceder a los datos de productos
- Creación del controlador ProductsController y su inyección de dependencias
- Implementación de endpoints para:
  - Listar todos los productos
  - Obtener un producto por su ID
  - Crear un producto asociado a una categoría
  - Obtener el nombre de la categoría del producto (carga anticipada con Include)
  - Obtener productos por categoría
  - Buscar productos por nombre o descripción
  - Comprar un producto (disminuir stock)
  - Actualizar un producto existente
  - Eliminar un producto

### Sección 8

Esta sección tiene por objetivo implementar el sistema de autenticación para nuestra API REST, permitiendo a los usuarios registrarse, iniciar sesión y acceder a recursos protegidos utilizando JWT (JSON Web Tokens).

- Fundamentos de seguridad en APIs REST.
- Creación del modelo Usuario.
- Definición de DTOs para creación y autenticación de usuarios.
- Creación e implementación de la interfaz IUserRepository.
- Registro de usuarios con encriptación de contraseñas utilizando Bcrypt.
- Introducción a JWT y su uso para autenticación segura.
- Desarrollo del método Login para validar credenciales y emitir tokens.
- Continuación del desarrollo de Login con generación de UserLoginResponseDto.
- Creación del controlador UserController con los endpoints:
  - Obtener todos los usuarios.
  - Obtener usuario individual por ID.
  - Crear usuario (registro).
  - Acceso (login) del usuario autenticado.
