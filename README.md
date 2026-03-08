# TP_PAV_v1 — Sistema de Gestión de Estaciones YPF

Aplicación de escritorio desarrollada en **C# con Windows Forms (.NET Framework 4.8)** para la gestión integral de estaciones de servicio YPF. El sistema permite administrar empleados, camiones, combustibles, estaciones, tanques, sucursales y generar remitos y reportes.

---

## Tabla de Contenidos

- [Descripción General](#descripción-general)
- [Arquitectura](#arquitectura)
- [Tecnologías Utilizadas](#tecnologías-utilizadas)
- [Requisitos Previos](#requisitos-previos)
- [Instalación y Configuración](#instalación-y-configuración)
- [Uso del Sistema](#uso-del-sistema)
- [Módulos del Sistema](#módulos-del-sistema)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Base de Datos](#base-de-datos)
- [Reportes](#reportes)

---

## Descripción General

**TP_PAV_v1** es un sistema de gestión pensado para las operaciones internas de estaciones YPF. Permite llevar el control de:

- Personal (empleados, turnos, tipos de documento)
- Flota de camiones y marcas
- Tipos de combustible y tanques
- Estaciones, sucursales y zonas geográficas (provincias, localidades, barrios)
- Emisión de remitos (alta de despachos de combustible)
- Generación de reportes internos

El acceso al sistema está protegido por un módulo de autenticación que valida al empleado mediante su **legajo** y **número de documento**.

---

## Arquitectura

El proyecto sigue una **arquitectura de 3 capas**:

```
┌────────────────────────────────────┐
│   Capa de Presentación             │
│   (Windows Forms – Formularios/)   │
│   LoginForm, Principal, ABM*, etc. │
└────────────────┬───────────────────┘
                 │
┌────────────────▼───────────────────┐
│   Capa de Entidades                │
│   (Entidades/)                     │
│   Empleado, Camion, Estacion, …    │
└────────────────┬───────────────────┘
                 │
┌────────────────▼───────────────────┐
│   Capa de Acceso a Datos           │
│   (AccesoADatos/)                  │
│   AD_Empleados, AD_Camiones, …     │
└────────────────┬───────────────────┘
                 │
┌────────────────▼───────────────────┐
│   Base de Datos SQL Server         │
└────────────────────────────────────┘
```

---

## Tecnologías Utilizadas

| Tecnología | Versión |
|---|---|
| C# / .NET Framework | 4.8 |
| Windows Forms | — |
| SQL Server | 2017+ |
| SQL Server Reporting Services (RDLC) | — |
| Microsoft.ReportingServices.ReportViewerControl.Winforms | 150.1484.0 |
| Microsoft.SqlServer.Types | 14.0.314.76 |

---

## Requisitos Previos

- **Sistema Operativo**: Windows 10 / 11 (64 bits recomendado)
- **Visual Studio**: 2017 o superior (con carga de trabajo de escritorio .NET)
- **.NET Framework**: 4.8
- **SQL Server**: instancia accesible con la base de datos del proyecto restaurada
- **NuGet**: los paquetes se restauran automáticamente al compilar

---

## Instalación y Configuración

### 1. Clonar el repositorio

```bash
git clone https://github.com/NachoChiofalo/TP_PAV1.git
cd TP_PAV1
```

### 2. Abrir la solución en Visual Studio

Abrir el archivo `TP_PAV_v1/TP_PAV_v1.sln` con Visual Studio.

### 3. Configurar la cadena de conexión

Editar el archivo `TP_PAV_v1/App.config` y actualizar la cadena de conexión con los datos del servidor SQL Server de destino:

```xml
<connectionStrings>
  <add name="TP_PAV_v1.Properties.Settings.BD3K7G11_2022ConnectionString"
       connectionString="Data Source=<SERVIDOR>,<PUERTO>;Initial Catalog=<BASE_DE_DATOS>;User ID=<USUARIO>;Password=<CONTRASEÑA>"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

> ⚠️ **Importante**: No compartir ni subir credenciales reales al repositorio.

### 4. Restaurar paquetes NuGet

En Visual Studio: `Herramientas → Administrador de paquetes NuGet → Restaurar paquetes NuGet`.

O desde la consola del Administrador de paquetes:

```
Update-Package -reinstall
```

### 5. Compilar y ejecutar

```
Compilar → Compilar solución  (Ctrl + Shift + B)
Depurar  → Iniciar sin depurar (Ctrl + F5)
```

El ejecutable se genera en `TP_PAV_v1/bin/Debug/TP_PAV_v1.exe`.

---

## Uso del Sistema

### Inicio de sesión

Al ejecutar la aplicación se muestra el formulario de **Login**. El empleado debe ingresar:

- **Legajo**: número de legajo del empleado.
- **Número de documento**: documento asociado al empleado en la base de datos.

Una vez autenticado, se accede al menú principal desde donde se navega a todos los módulos.

---

## Módulos del Sistema

### ABM (Alta / Baja / Modificación)

Cada módulo permite crear, editar y eliminar registros:

| Módulo | Descripción |
|---|---|
| **ABM Empleados** | Gestión del personal (legajo, nombre, turno, tipo de documento) |
| **ABM Turnos** | Administración de turnos de trabajo |
| **ABM Tipo de Documento** | Tipos de documento aceptados (DNI, pasaporte, etc.) |
| **ABM Camiones** | Flota de camiones (patente, marca, capacidad, etc.) |
| **ABM Marcas** | Marcas de vehículos |
| **ABM Combustibles** | Tipos de combustible disponibles |
| **ABM Tipo de Combustible** | Clasificación de combustibles |
| **ABM Tanques** | Tanques de almacenamiento con su capacidad y tipo de combustible |
| **ABM Estaciones** | Estaciones de servicio |
| **ABM Sucursales** | Sucursales asociadas a estaciones |
| **ABM Provincias** | Provincias del país |
| **ABM Localidades** | Localidades por provincia |
| **ABM Barrios** | Barrios por localidad |

### Alta de Remito

Permite registrar un nuevo remito (despacho/entrega de combustible), asociando camión, estación, tanque, tipo de combustible y cantidad.

### Reportes

Generación de reportes imprimibles mediante SSRS (RDLC):

| Reporte | Descripción |
|---|---|
| **Listado de Empleados** | Nómina completa del personal |
| **Listado de Camiones** | Flota de camiones registrados |
| **Listado de Marcas** | Marcas de vehículos |
| **Tipos de Combustible** | Clasificación y detalle de combustibles |

---

## Estructura del Proyecto

```
TP_PAV_v1/
├── AccesoADatos/           # Capa de acceso a datos (SQL Server)
│   ├── AD_Barrios.cs
│   ├── AD_Camiones.cs
│   ├── AD_Combustibles.cs
│   ├── AD_Empleados.cs
│   ├── AD_Estaciones.cs
│   ├── AD_Marcas.cs
│   ├── AD_Provincias.cs
│   ├── AD_Remitos.cs
│   ├── AD_Sucursales.cs
│   ├── AD_Tanque.cs
│   ├── AD_TipoCombustible.cs
│   ├── AD_TipoDocumento.cs
│   ├── AD_Turnos.cs
│   └── AD_Usuarios.cs
├── Entidades/              # Modelos de dominio
│   ├── Barrio.cs
│   ├── Camion.cs
│   ├── Combustible.cs
│   ├── Empleado.cs
│   ├── Estacion.cs
│   ├── Localidad.cs
│   ├── Marca.cs
│   ├── Provincia.cs
│   ├── Sucursal.cs
│   ├── Tanques.cs
│   ├── TipoCombustible.cs
│   ├── TipoDocumento.cs
│   ├── Turno.cs
│   └── Usuario.cs
├── Formularios/            # Capa de presentación (Windows Forms)
│   ├── LoginForm.cs/.Designer.cs
│   ├── Principal.cs/.Designer.cs
│   ├── ABM*.cs/.Designer.cs
│   ├── AltaRemito.cs/.Designer.cs
│   └── Reporte*.cs/.Designer.cs
├── Properties/             # Metadatos del ensamblado y recursos
├── Resources/              # Imágenes y recursos gráficos
├── SqlServerTypes/         # DLLs de tipos espaciales de SQL Server
├── *.rdlc                  # Definiciones de reportes SSRS
├── App.config              # Configuración de la aplicación
├── Program.cs              # Punto de entrada
├── TP_PAV_v1.csproj        # Archivo de proyecto
├── TP_PAV_v1.sln           # Solución de Visual Studio
└── packages.config         # Dependencias NuGet
```

---

## Base de Datos

El sistema se conecta a una base de datos **SQL Server**. Las principales tablas son:

| Tabla | Descripción |
|---|---|
| `Empleados` | Personal de la empresa |
| `Turnos` | Turnos de trabajo |
| `TipoDocumento` | Tipos de documento |
| `Camiones` | Flota de vehículos |
| `Marcas` | Marcas de vehículos |
| `TipoCombustible` | Tipos de combustible |
| `Combustibles` | Combustibles disponibles |
| `Tanques` | Tanques de almacenamiento |
| `Estaciones` | Estaciones de servicio |
| `Sucursales` | Sucursales por estación |
| `Provincias` | Provincias del país |
| `Localidades` | Localidades |
| `Barrios` | Barrios |
| `Remitos` | Remitos de despacho de combustible |
| `Usuarios` | Cuentas de acceso al sistema |

La cadena de conexión se configura en `App.config` (ver sección [Instalación y Configuración](#instalación-y-configuración)).

---

## Reportes

Los reportes se generan mediante **SQL Server Reporting Services (SSRS)** usando archivos `.rdlc`. Se visualizan dentro de la aplicación con el control **ReportViewer** de Microsoft.

Los archivos de definición de reportes se encuentran en la raíz del proyecto:

- `ListadoDeCamiones.rdlc`
- `ListadoDeEmpleados.rdlc`
- `ListadoDeMarcas.rdlc`
- `ListadoTipoCombustible.rdlc`

---

## Autores

Proyecto académico desarrollado en el marco de la materia **Programación de Aplicaciones con Visual Studio** — 2022.
