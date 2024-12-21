# Proyecto: API de Productos

## Descripción

Esta es una solución desarrollada en C# que implementa una API para agregar, modificar y listar productos. La API está diseñada siguiendo los principios de desarrollo en capas y orientado a objetos, utilizando Entity Framework y con soporte para pruebas en Swagger y Postman.

## Funcionalidades

1. **Agregar Productos**: Permite registrar un nuevo producto con las propiedades requeridas.
2. **Modificar Productos**: Permite actualizar las propiedades de un producto existente.
3. **Listar Productos**: Permite obtener una lista de productos almacenados.

### Reglas de negocio

- Las propiedades de un producto incluyen:
  - **Nombre** (obligatorio, máximo 50 caracteres).
  - **Marca** (obligatoria).
  - **Alto** (obligatorio).
  - **Ancho** (obligatorio).
  - **Profundidad** (obligatorio).
  - **Peso** (opcional).
- Si no se cumplen estas validaciones, se mostrará un mensaje de error correspondiente.

## Tecnologías utilizadas

- **C#**: Lenguaje de programación.
- **.NET Core**: Framework utilizado para construir la API.
- **Entity Framework Core**: ORM utilizado para la gestión de la base de datos (puede ser Code First o Database First).
- **Swagger**: Documentación interactiva para la API.
- **Postman**: Herramienta para probar los endpoints de la API.

## Estructura del Proyecto

El proyecto está organizado en tres capas principales:

1. **UI (User Interface)**: Contiene los controladores y los endpoints de la API.
2. **Servicios**: Contiene la lógica de negocio.
3. **Datos**: Contiene el modelo de datos y la configuración de Entity Framework.

## Requisitos Previos

- .NET SDK 6.0 o superior.
- SQL Server para la base de datos.
- Visual Studio 2022 (o cualquier IDE compatible con .NET).

## Instalación y Configuración

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/tu_usuario/nombre_del_repositorio.git
   ```

2. **Restaurar paquetes NuGet**:
   ```bash
   dotnet restore
   ```

3. **Configurar la cadena de conexión**:
   - Editar el archivo `appsettings.json` para agregar la cadena de conexión a tu base de datos SQL Server.

4. **Aplicar migraciones (si utilizas Code First)**:
   ```bash
   dotnet ef database update
   ```

5. **Ejecutar el proyecto**:
   ```bash
   dotnet run
   ```

## Uso

1. **Abrir Swagger**:
   - Una vez que la aplicación está en ejecución, abre un navegador y accede a `http://localhost:5000/swagger` (o la URL correspondiente).

2. **Probar con Postman**:
   - Importa la colección de Postman incluida en el repositorio (si está disponible) o configura manualmente las solicitudes a los endpoints de la API.

## Endpoints Principales

- **GET /api/productos**: Lista todos los productos.
- **POST /api/productos**: Agrega un nuevo producto.
- **PUT /api/productos/{id}**: Modifica un producto existente.

## Ejemplo de un Producto

```json
{
  "nombre": "Mesa",
  "marca": "Mueblería XYZ",
  "alto": 75,
  "ancho": 120,
  "profundidad": 60,
  "peso": 20.5
}
```

## Contribución

Si deseas contribuir a este proyecto, puedes abrir un issue o enviar un pull request con tus cambios propuestos.

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE` para más información.

---

**Autor**: VS1379

