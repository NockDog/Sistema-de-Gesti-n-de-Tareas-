# Sistema de Gestión de Tareas

## Descripción
Este proyecto es un sistema de gestión de tareas que permite a los usuarios realizar las siguientes operaciones:

1. Agregar una nueva tarea con un título y descripción.
2. Listar todas las tareas (pendientes y completadas).
3. Marcar una tarea como completada.
4. Eliminar una tarea.
5. Salir del sistema.

El sistema utiliza una interfaz de consola interactiva y sigue el principio de responsabilidad única (SRP) para el diseño de las clases. No utiliza una base de datos, y la gestión de tareas está limitada a un máximo de 10.

## Requisitos
- Lenguaje: C#
- Gestión de tareas en memoria (sin base de datos).
- Aplicación de consola con un menú interactivo.
- Límite de 10 tareas.

## Estructura del Proyecto
### Clases
1. **`Task`**
   - **Propiedades**:
     - `Id`: Identificador único de la tarea.
     - `Title`: Título de la tarea.
     - `Description`: Descripción de la tarea.
     - `IsCompleted`: Estado de la tarea (true para completada, false para pendiente).
   - **Método**:
     - `DisplayInfo`: Muestra la información básica de la tarea.

2. **`TaskManager`**
   - **Métodos**:
     - `AddTask`: Agregar una nueva tarea.
     - `ListAllTasks`: Listar todas las tareas (pendientes y completadas).
     - `CompleteTask`: Marcar una tarea como completada.
     - `DeleteTask`: Eliminar una tarea.

3. **`Program`**
   - Contiene el menú principal e interactúa con el usuario mediante la consola.

## Pruebas Realizadas
### Resultados de los Tests

- **Test número 1: Agregar Tarea**
  - **Descripción**: Se agrega una tarea con título y descripción.
  - **Resultado**: Exitosa. La tarea se agrega sin problemas y se registra en la lista.

- **Test número 2: Agregar tarea sin nombre o/y sin descripción**
  - **Descripción**: Se agrega una tarea sin título o descripción.
  - **Resultado**: La tarea se agrega correctamente. Lo ideal sería que el sistema solicite el nombre como obligatorio.

- **Test número 3: Listar todas las tareas**
  - **Descripción**: Se muestran todas las tareas (pendientes y completadas).
  - **Resultado**: Exitosa. Las tareas se muestran con ID, estado (completada o no), y orden de creación.

- **Test número 4: Marcar tarea como completada**
  - **Descripción**: Se marca una tarea como completada.
  - **Resultado**: Exitosa. El estado de "Completada" cambia de "No" a "Sí" y se refleja en la lista de tareas.

- **Test número 5: Marcar tarea que no existe como completada**
  - **Descripción**: Se intenta completar una tarea con un ID inexistente.
  - **Resultado**: Exitosa. El sistema identifica que el ID no existe y muestra "Tarea no encontrada".

- **Test número 6: Eliminar tarea que existe**
  - **Descripción**: Se elimina una tarea existente.
  - **Resultado**: Exitosa. La tarea se elimina sin problemas y se refleja en la lista de tareas.

- **Test número 7: Eliminar tarea que NO existe**
  - **Descripción**: Se intenta eliminar una tarea con un ID inexistente.
  - **Resultado**: Exitosa. El sistema identifica que el ID no existe y muestra "Tarea no encontrada".

- **Test número 8: Salir**
  - **Descripción**: Se selecciona la opción de salir del sistema.
  - **Resultado**: Exitosa. El programa finaliza correctamente mediante un `break`.

## Uso
1. Ejecutar el programa.
2. Utilizar las opciones del menú interactivo para gestionar las tareas:
   - Opción 1: Agregar una nueva tarea.
   - Opción 2: Listar todas las tareas.
   - Opción 3: Marcar una tarea como completada.
   - Opción 4: Eliminar una tarea.
   - Opción 5: Salir del sistema.
3. Seguir las instrucciones proporcionadas por el programa.

## Mejoras Futuras
- Validar que el título de la tarea sea obligatorio al agregar una nueva tarea.
- Implementar funcionalidad para editar tareas existentes.
- Mejorar la interfaz del menú con más opciones para personalizar la experiencia del usuario.
- Soporte para más de 10 tareas mediante paginación.
