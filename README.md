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

---

## Course Description (ENG)

This course provides a complete, hands-on guide to building a professional RESTful API from scratch using **.NET Core 8**. Throughout 17 modules, you’ll learn how to design and implement backend systems with **Entity Framework Core**, apply **JWT-based authentication and role-based authorization**, and follow best practices such as the **repository pattern**, **API versioning**, and **pagination**. You’ll also configure **SQL Server databases**, add **image upload functionality**, and finally **deploy your API to Azure**, simulating a real production environment.

---

## Conceptos Clave (SPA)

Sin descripción: Sección 01

### Sección 02

Esta sección tiene por objetivo dar unas bases sobre C# con la idea de que se familiaricen con los conceptos comunes usados en el día a día con .NET.

- Tipos básicos
- Clases e Interfaces
- Herencia
- Patrón adaptador
- Inyección de dependencias
- Métodos asíncronos
- Atributos o decoradores

### Sección 03

Esta sección tiene por objetivo sentar las bases necesarias para iniciar el desarrollo de una API con .NET. Aprenderemos a crear y configurar un proyecto desde cero, entendiendo su estructura interna y los elementos clave para el desarrollo backend profesional.

- ¿Qué es .NET y cómo funciona en el ecosistema de desarrollo?
- Creación y configuración inicial de un proyecto .NET.
- Explicación detallada del archivo Program.cs y su rol en la aplicación.
- Organización de la estructura de directorios del proyecto.
- Configuración de un contenedor Docker con SQL Server para la persistencia de datos.

### Sección 04

Esta sección tiene por objetivo construir la entidad Categoría, conectarla a la base de datos y realizar la primera migración con Entity Framework Core.
Es un paso fundamental para comenzar a manejar datos de manera estructurada en nuestra API.

- Definición del modelo Categoría con sus propiedades esenciales.
- Configuración de la conexión con la base de datos SQL Server.
- Instalación de paquetes necesarios para trabajar con EF Core
- Creación del archivo de contexto (DbContext).
- Configuración de la cadena de conexión en el proyecto en Program.cs.
- Ejecución de la primera migración y actualización de la base de datos

### Sección 05

Esta sección tiene por objetivo introducir el patrón repositorio, una técnica comúnmente utilizada para desacoplar la lógica de acceso a datos del resto de la aplicación, promoviendo buenas prácticas y una arquitectura más limpia.

- Introducción al patrón repositorio en aplicaciones .NET.
- Creación de una interfaz ICategoryRepository para definir las operaciones del repositorio.
- Implementación concreta del repositorio CategoryRepository para acceder a los datos de la entidad Categoría.

### Sección 06

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

### Sección 07

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

### Sección 08

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

### Sección 09

Esta sección tiene por objetivo comprender y configurar correctamente CORS (Cross-Origin Resource Sharing) en una API desarrollada con ASP.NET Core, asegurando que pueda ser consumida de forma segura desde otras aplicaciones o dominios.

- Qué es CORS y por qué es importante en el desarrollo de APIs REST.
- Configuración global de CORS en el proyecto.
- Cómo permitir controladores o métodos específicos según políticas definidas.

### Sección 10

Esta sección tiene por objetivo proteger los recursos de la API asegurando que solo usuarios autenticados y autorizados puedan acceder a determinados endpoints. Además, se incorpora el uso de herramientas como Postman y Swagger para validar el comportamiento de la autenticación y autorización.

- Cómo proteger accesos a través de atributos como [Authorize]
- Diferencias entre endpoints públicos y privados
- Uso de Postman para probar endpoints protegidos:
- Acceso a recursos de categorías
- Acceso a recursos de usuarios
- Exportar la colección con tokens incluidos
- Incorporar la autenticación en Swagger para consumir la API desde la documentación

### Sección 11

Esta sección tiene por objetivo optimizar el rendimiento de la API mediante la implementación de mecanismos de caché, reduciendo así el tiempo de respuesta y el consumo de recursos del servidor.

- Cómo añadir y configurar caché en ASP.NET Core.
- Fundamentos de caché en aplicaciones web y su importancia en APIs REST.
- Uso de perfiles de caché para definir políticas reutilizables.
- Gestión de constantes para centralizar y mantener la configuración de caché.

### Sección 12

Esta sección tiene por objetivo implementar el versionamiento de nuestra API REST para mantener la compatibilidad con versiones anteriores mientras se agregan nuevas funcionalidades, asegurando una evolución controlada del proyecto.

- Qué es el versionamiento de APIs y por qué es fundamental en proyectos reales.
- Instalación y configuración de las extensiones necesarias para soportar múltiples versiones.
- Declaración y manejo de versiones en los controladores.
- Documentación de endpoints por versión (por ejemplo, Version 1).
- Agregar una nueva versión (Version 2) y realizar tareas prácticas con ella.
- Organización del código cuando se manejan múltiples versiones en paralelo.
- Cómo declarar una API como neutral o marcarla como obsoleta ([Obsolete]).

### Sección 13

Esta sección tiene por objetivo reemplazar la autenticación personalizada de la API por un sistema robusto y escalable utilizando ASP.NET Core Identity, aprovechando sus mecanismos integrados para el manejo de usuarios, roles y autenticación segura.

- Introducción al sistema Identity de ASP.NET Core
- Integración de Identity en un proyecto existente.
- Creación del modelo y soporte para el uso de Identity.
- Migración y actualización de la base de datos para habilitar Identity.
- Configuración de Login con Identity.
- Ajustes necesarios en el método de registro.
- Cambios al listar y obtener usuarios con el nuevo sistema.
- Pruebas funcionales y corrección de errores derivados de la integración.

### Sección 14

Esta sección tiene por objetivo permitir la carga y gestión de imágenes asociadas a productos en nuestra API, abarcando desde la configuración inicial hasta la validación y refactorización del código para una solución más limpia y mantenible.

- Configuración del entorno para permitir la subida de archivos en ASP.NET Core.
- Subida de imagen al crear un producto, incluyendo el uso de una imagen por defecto.
- Subida de imagen al actualizar un producto ya existente.
- Pruebas de funcionalidad y refactorización del código relacionado con el manejo de imágenes.

### Sección 15

Esta sección tiene por objetivo mejorar la estructura de la API agregando datos iniciales (seed), implementando paginación para controlar el volumen de resultados, y explorando el uso de Mapster como alternativa moderna a AutoMapper.

- Generación de datos iniciales (seeding) para poblar la base de datos.
- Refactorización del proceso de seed para hacerlo reutilizable y limpio.
- Conceptos clave sobre paginación en APIs REST.
- Implementación de paginación con parámetros de consulta (pageNumber,pageSize).
- Refactorización de la respuesta para incluir metadatos de paginación (total, páginas, etc.).
- Introducción a Mapster como alternativa ligera y eficiente a AutoMapper.
- Uso del agente en Visual Studio Code para migrar de AutoMapper a Mapster y generar clases de mapeo automáticamente.

### Sección 16

Esta sección tiene por objetivo desplegar la API desarrollada en un entorno de producción utilizando los servicios en la nube de Microsoft Azure. Se abordarán tanto la conexión a la base de datos como la publicación del backend.

- Configuración inicial de la cuenta y portal de Azure.
- Prueba de conexión entre el entorno local y la base de datos en la nube.
- Migración del esquema y datos a la base de datos de Azure.
- Publicación de la API en Azure App Service.
- Pruebas de funcionamiento en el entorno de producción.
