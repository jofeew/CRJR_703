CRJR_703
========

I-. Ítem de desarrollo. 
Se necesita dar una solución a una problemática a través de un sistema computacional, la cual debe ser implementada bajo la arquitectura Visual C# y MySql.


Contexto de la problemática:

Una empresa de servicio técnico computacional regional, necesita de la implementación de una aplicación que permita registrar las labores asociadas al rubro del servicio técnico. 

Los mantenedores y los campos que requieren son los siguientes:

Mantenedor Técnico: Permite ingresar y actualizar datos de los técnicos que operan en la empresa.(joan)
Campos:
−	Rut
−	Nombre
−	Dirección
−	Teléfono
−	Especialidad

Mantenedor Cliente: Permite ingresar y actualizar datos de los clientes que visitan la empresa.(claudio)
Campos:
−	Rut
−	Nombre
−	Dirección
−	Teléfono

Mantenedor PC Escritorio: Permite ingresar y actualizar datos de los PC de escritorio.(joan)
Campos:
−	Marca
−	Modelo
−	Cantidad de Ram
−	Tipo Procesador (Intel - AMD)
−	Capacidad HDD

Mantenedor PC Portable: Permite ingresar y actualizar datos de los equipos de portátiles.
Campos:
−	Marca
−	Modelo
−	Cantidad de Ram
−	Tipo Procesador (Intel - AMD)
−	Capacidad HDD
−	Diagnostico
−	Accesorios
o	Batería
o	Cargador









Transaccional Orden de Trabajo: Permite registrar el ingreso de un equipo al servicio técnico, almacenando los datos de todos los mantenedores que se requieran.
Campos:
−	Número de orden de trabajo
−	Fecha
−	Observación
−	Rut Cliente
−	Rut técnico
−	Código del PC
−	Tiempo estimado en servicio técnico (días)

Considere que si bien solo los campos claves de los mantenedores se almacenan en la tabla de Orden de Trabajo, al momento de guardar se deben mostrar los datos básicos del cliente, el técnico y del PC.

Además, en un módulo de Reportes se debe visualizar lo siguiente:

Listado de Ordenes de Trabajo, filtrados por:
−	Todas
−	Técnico
−	Mes
Listado de Técnicos, filtrados por:
−	Todos
−	Especialidad
−	Nombre
−	Apellido

Consideraciones secundarias:
−	Sistema desarrollado en formato de menús, con formularios MDI.
−	Navegación con tecla “Enter” entre los controles.
−	Validación completa de datos.
−	Controlar largo de los controles
−	Controlar foco de inicialización en cada formulario
−	Incorporación de mensajes de alerta y de error cuando corresponda.
