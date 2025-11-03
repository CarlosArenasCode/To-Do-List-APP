# To-Do List - Sistema de Gestión de Tareas

## Descripción
Aplicación de escritorio desarrollada en C# con Windows Forms que permite gestionar una lista de tareas con operaciones CRUD completas (Crear, Leer, Actualizar, Eliminar) conectada a una base de datos MySQL.

## Características
- **Alta de Tareas**: Agregar nuevas tareas con nombre, descripción y estado
- **Baja de Tareas**: Eliminar tareas existentes
- **Modificación de Tareas**: Actualizar información de tareas
- **Consultas**:
  - Ver todas las tareas
  - Filtrar tareas completadas
  - Filtrar tareas pendientes

## Tecnologías Utilizadas
- **Lenguaje**: C# 7.3
- **Framework**: .NET Framework 4.7.2
- **Interfaz**: Windows Forms
- **Base de Datos**: MySQL
- **Conector**: MySql.Data

## Estructura del Proyecto
```
- ToDoList/
- Form1.cs              # Interfaz principal y lógica de eventos
- Form1.Designer.cs     # Diseño del formulario
- CRUD.cs              # Clase con operaciones CRUD
- Conexion.cs          # Clase para manejo de conexión a MySQL
- Program.cs           # Punto de entrada de la aplicación
```

## Requisitos
- Visual Studio 2017 o superior
- MySQL Server
- MySQL Connector/NET

## Instalación

### 1. Clonar el repositorio
```bash
git clone https://github.com/TU_USUARIO/ToDoList.git
cd ToDoList
```

### 2. Configurar la Base de Datos
Ejecuta el siguiente script SQL en MySQL:

```sql
CREATE DATABASE todolist;
USE todolist;

CREATE TABLE tareas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT,
    completada BOOLEAN DEFAULT FALSE
);
```

### 3. Configurar la Conexión
Edita el archivo `Conexion.cs` con tus credenciales de MySQL:
```csharp
string servidor = "localhost";
string bd = "todolist";
string usuario = "root";
string password = "TU_PASSWORD";
```

### 4. Restaurar paquetes NuGet
En Visual Studio:
- Clic derecho en el proyecto ? "Restore NuGet Packages"

### 5. Compilar y Ejecutar
- Presiona F5 o clic en "Iniciar"

## Uso
1. La aplicación muestra todas las tareas al iniciar
2. Para **agregar** una tarea: completa los campos y presiona "Agregar"
3. Para **eliminar** una tarea: selecciónala de la lista y presiona "Eliminar"
4. Para **modificar** una tarea: selecciónala, edita los campos y presiona "Modificar"
5. Usa los botones de filtro para ver tareas completas, pendientes o todas

## Base de Datos
La tabla `tareas` contiene:
- **id**: Identificador único (AUTO_INCREMENT)
- **nombre**: Nombre de la tarea (VARCHAR 100)
- **descripcion**: Descripción detallada (TEXT)
- **completada**: Estado de la tarea (BOOLEAN: 0=Pendiente, 1=Completada)

## Autor
**Carlos Saul Arenas Maciel**  
Fecha: 03/11/2025

## Notas
- Este proyecto fue desarrollado como parte de un trabajo académico
- Implementa las 4 operaciones CRUD completas
- Incluye validación de datos y manejo de errores
