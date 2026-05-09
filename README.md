
# Tecnológico de Software 
- **Arquitectura de Software** 
- **Alumno:** Euruviel Marquez Martinez
- **Docente:** Jorge Pedrozo Romero
- **Fecha:** 08/05/2026
- **Actividad:** Actividad #02 – Práctica .NET: Proyecto vacío en .NET

# Catálogo de Anime — ArqSoft S01

Aplicación web desarrollada como actividad de la materia **Arquitectura de Software**.
Es un catálogo personal de animes recomendados, construido con el patrón **MVC** en ASP.NET Core.

---

## Descripción

Esta app permite llevar un registro personal de animes organizados por género.
El usuario puede ver el catálogo completo, filtrar por categoría, ver el detalle
de cada anime y agregar nuevos títulos a la lista.

El catálogo está dividido en 3 géneros:
-  **Acción** — Akame ga Kill, Jujutsu Kaisen, Kimetsu no Yaiba, Shingeki no Kyojin, Fire Force
-  **Aventura** — Sword Art Online, Mushoku Tensei, Konosuba, Nanatsu no Taizai, JoJo's Bizarre Adventure
-  **Romance** — Kaguya-sama, Your Lie in April, Sono Bisque Doll, Horimiya, Nisekoi

---
## Arquitectura MVC

El proyecto sigue el patrón **Modelo - Vista - Controlador**:

- **Model** (`Item.cs`) — Define los datos de cada anime:
  Título, Género, Año, Estudio, Estado, Calificación, Descripción e Imagen.

- **Controller** (`CatalogoController.cs`) — Maneja la lógica:
  lista de animes en memoria, filtro por género, detalle y agregar nuevo anime.

- **Views** (`/Views/Catalogo/`) — Las páginas que ve el usuario:
  `Index.cshtml` (catálogo), `Detalle.cshtml` (detalle), `Agregar.cshtml` (formulario).

---

##  Funcionalidades

-  Lista de animes en tarjetas con imagen, género, estudio y año
-  Filtro por género (Acción, Aventura, Romance)
-  Badge de estado con colores: Viendo, Terminado, Pausado
-  Calificación con estrellitas ⭐ del 1 al 10
-  Página de detalle con imagen y toda la información
-  Formulario para agregar nuevos animes
-  Diseño oscuro estilo anime con tema rojo y azul oscuro

---
##  Capturas de pantalla

### Página Principal
![Inicio](Captura%20de%20pantalla%202026-05-08%20210107.png)

### Catálogo
![Catalogo](Captura%20de%20pantalla%202026-05-08%20210159.png)

### Detalle
![Detalle](Captura%20de%20pantalla%202026-05-08%20210212.png)

### Estadísticas
![Estadisticas](Captura%20de%20pantalla%202026-05-08%20210222.png)

---
