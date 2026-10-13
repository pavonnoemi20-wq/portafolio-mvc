# Portafolio MVC

Portafolio personal responsivo creado con **ASP.NET Core MVC (.NET 8)**, Razor, HTML, CSS y JavaScript. Incluye tres ilustraciones SVG locales integradas en el proyecto.

## Secciones

- **Inicio:** presentación, habilidades y proyectos destacados.
- **Proyectos:** propuestas académicas de app móvil, gestión de datos y análisis.
- **Contacto:** formulario con validación del lado del servidor. Actualmente es una demostración; no envía correos ni almacena mensajes.
- Diseño adaptable a móvil, tablet y escritorio.

## Requisitos

- .NET 8 SDK
- Visual Studio Code o Visual Studio
- Git (opcional para publicar en GitHub)

Comprueba la instalación:

```bash
dotnet --version
```

## Abrir en Visual Studio (versión morada)

1. Instala la carga de trabajo **ASP.NET y desarrollo web** y el SDK de .NET 8.
2. Descomprime el ZIP.
3. Abre el archivo `PortafolioMVC.sln` con Visual Studio.
4. Espera a que restaure los paquetes y selecciona el perfil `https` o `http` en la barra superior.
5. Presiona el botón verde de ejecutar (IIS Express o el nombre del proyecto, según el perfil disponible).

## Ejecutar localmente

Desde la carpeta que contiene `PortafolioMVC.csproj`:

```bash
dotnet restore
dotnet run
```

Abre en el navegador la dirección local que aparezca en la terminal.

## Subir a GitHub

1. Crea un repositorio vacío en GitHub, por ejemplo `portafolio-mvc`.
2. Abre una terminal en esta carpeta.
3. Ejecuta:

```bash
git init
git add .
git commit -m "Crear portafolio MVC inicial"
git branch -M main
git remote add origin https://github.com/TU-USUARIO/portafolio-mvc.git
git push -u origin main
```

Reemplaza `TU-USUARIO` por tu usuario real de GitHub.

## Publicar en Azure App Service

Este proyecto es una aplicación ASP.NET Core, por lo que debes crear un **App Service para .NET 8** (no uno de Python).

### Opción sencilla desde VS Code

1. Instala la extensión **Azure App Service** y entra en tu cuenta de Azure.
2. Ejecuta `dotnet publish -c Release -o ./publish`.
3. En Azure, crea un App Service compatible con .NET 8 y el sistema operativo que vayas a usar.
4. Usa la extensión para desplegar la carpeta publicada, siguiendo el flujo que muestre la extensión, o configura un flujo de despliegue desde GitHub Actions.
5. Abre la URL del App Service y verifica las secciones y las imágenes.

### Antes de usarlo como portafolio profesional

- Cambia “Nomi” por el nombre que quieras mostrar y revisa cada descripción.
- Añade enlaces reales a tus repositorios cuando los proyectos estén publicados.
- Configura un servicio de correo si deseas que el formulario envíe mensajes.
- No subas contraseñas, claves ni cadenas de conexión al repositorio.
- Verifica la configuración de .NET/runtime que ofrece tu suscripción de Azure al momento de crear el App Service.

## Estructura

```text
PortafolioMVC/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   └── ContactViewModel.cs
├── Views/
│   ├── Home/
│   │   ├── Contact.cshtml
│   │   ├── Error.cshtml
│   │   ├── Index.cshtml
│   │   └── Projects.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── wwwroot/
│   ├── css/site.css
│   ├── images/
│   │   ├── database.svg
│   │   ├── hero-code.svg
│   │   └── purisimo-cafe.svg
│   └── js/site.js
├── Program.cs
└── PortafolioMVC.csproj
```
