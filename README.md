# App Gestión Empleados II

Aplicación de gestión de empleados desarrollada con .NET MAUI que permite administrar la información de empleados de manera eficiente a través de una interfaz multiplataforma.

## Descripción

Esta aplicación forma parte de un sistema completo de gestión de empleados que consta de dos componentes principales:

1. **Frontend (Este repositorio)**: Aplicación móvil/desktop desarrollada en .NET MAUI
2. **Backend**: API RESTful desarrollada en Python - [ApiEmpleados](https://github.com/SERGICBG17/ApiEmpleados)

## Características

- Gestión completa de empleados (CRUD)
- Interfaz multiplataforma (Android, iOS, Windows, macOS)
- Sincronización en tiempo real con la API
- Diseño moderno y responsive
- Conexión segura con el backend

## Tecnologías

- **.NET MAUI** - Framework multiplataforma
- **C#** - Lenguaje de programación
- **XAML** - Diseño de interfaz
- **HttpClient** - Comunicación con la API
- **MVVM** - Patrón de arquitectura

## Requisitos Previos

### Para el Frontend
- Visual Studio 2022 (versión 17.3 o superior)
- Workload de .NET MAUI instalado
- .NET 7.0 SDK o superior

### Para el Backend (Requerido)
- Python 3.8 o superior
- Base de datos configurada
- API ejecutándose localmente o en servidor

## Instalación

### 1. Configurar el Backend

Primero, debes clonar y configurar el backend:

```bash
# Clonar el repositorio del backend
git clone https://github.com/SERGICBG17/ApiEmpleados.git
cd ApiEmpleados

# Crear entorno virtual
python -m venv venv

# Activar entorno virtual
# En Windows:
venv\Scripts\activate
# En macOS/Linux:
source venv/bin/activate

# Instalar dependencias
pip install -r requirements.txt

# Configurar base de datos (seguir instrucciones del README del backend)

# Ejecutar la API
python app.py
```

### 2. Configurar el Frontend

```bash
# Clonar este repositorio
git clone https://github.com/SERGICBG17/AppGestionEmpleadosII.git
cd AppGestionEmpleadosII

# Abrir la solución en Visual Studio 2022
# o desde línea de comandos:
start AppGestionEmpleadosII.sln
```

### 3. Configurar la URL de la API

Edita el archivo de configuración para apuntar a tu API:

```csharp
// En tu archivo de configuración o servicio
private const string ApiBaseUrl = "http://localhost:5000/api"; // Ajusta según tu configuración
```

### 4. Ejecutar la Aplicación

1. Selecciona la plataforma de destino (Windows, Android, iOS, macOS)
2. Presiona F5 o haz clic en "Ejecutar"
3. La aplicación se compilará y ejecutará en la plataforma seleccionada

## Uso

1. **Listar Empleados**: Visualiza todos los empleados registrados
2. **Agregar Empleado**: Completa el formulario con los datos del nuevo empleado
3. **Editar Empleado**: Selecciona un empleado y modifica sus datos
4. **Eliminar Empleado**: Elimina empleados del sistema
5. **Buscar Empleado**: Filtra empleados por diferentes criterios

## Integración con el Backend

La aplicación se comunica con el backend mediante peticiones HTTP REST:

- **GET** `/api/empleados` - Obtener lista de empleados
- **GET** `/api/empleados/{id}` - Obtener empleado específico
- **POST** `/api/empleados` - Crear nuevo empleado
- **PUT** `/api/empleados/{id}` - Actualizar empleado
- **DELETE** `/api/empleados/{id}` - Eliminar empleado

## Estructura del Proyecto

```
AppGestionEmpleadosII/
├── Models/              # Modelos de datos
├── ViewModels/          # Lógica de presentación (MVVM)
├── Views/               # Interfaces de usuario (XAML)
├── Services/            # Servicios de API y negocio
├── Resources/           # Recursos (imágenes, estilos, etc.)
└── Platforms/           # Código específico de plataforma
```

## Configuración Adicional

### Android
- Permisos de Internet en `AndroidManifest.xml`
- Configuración de seguridad de red para conexiones HTTP

### iOS
- Configuración de `Info.plist` para permitir conexiones HTTP
- Permisos de red

### Windows
- Configuración de capacidades en `Package.appxmanifest`

## Solución de Problemas

### La aplicación no se conecta a la API

1. Verifica que el backend esté ejecutándose
2. Comprueba la URL de la API en la configuración
3. Asegúrate de que no haya firewall bloqueando la conexión
4. En Android/iOS, verifica los permisos de red

### Errores de compilación

1. Limpia y reconstruye la solución
2. Verifica que todas las dependencias NuGet estén instaladas
3. Actualiza Visual Studio a la última versión

## Licencia

Este proyecto está bajo la Licencia MIT 


## Enlaces Relacionados

- [Backend - ApiEmpleados](https://github.com/SERGICBG17/ApiEmpleados)
- [Documentación de .NET MAUI](https://learn.microsoft.com/es-es/dotnet/maui/)
