using catalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Controllers
{
    public class CatalogoController : Controller
    {
        private static List<Item> _items = new()
{
    // ===== ACCIÓN =====
    new Item {
        Id = 1,
        Titulo = "Akame ga Kill",
        Genero = "Acción",
        Ano = 2014,
        Estudio = "White Fox",
        Estado = "Terminado",
        Calificacion = 9,
        Descripcion = "Un joven aldeano se une a un grupo de asesinos para luchar contra un imperio corrupto.",
        ImagenUrl = "/img/Akame ga kill.jpg"
    },
    new Item {
        Id = 2,
        Titulo = "Jujutsu Kaisen",
        Genero = "Acción",
        Ano = 2020,
        Estudio = "Mappa",
        Estado = "Viendo",
        Calificacion = 10,
        Descripcion = "Yuji Itadori se convierte en el recipiente de un poderoso demonio para salvar a sus amigos.",
        ImagenUrl = "/img/jujutsu kaisen.jpg"
    },
    new Item {
        Id = 3,
        Titulo = "Kimetsu no Yaiba",
        Genero = "Acción",
        Ano = 2019,
        Estudio = "Ufotable",
        Estado = "Terminado",
        Calificacion = 10,
        Descripcion = "Tanjiro busca vengar a su familia y convertir a su hermana de vuelta en humana.",
        ImagenUrl = "/img/Kimetsu.png"
    },
    new Item {
        Id = 4,
        Titulo = "Shingeki no Kyojin",
        Genero = "Acción",
        Ano = 2013,
        Estudio = "Mappa",
        Estado = "Terminado",
        Calificacion = 10,
        Descripcion = "La humanidad vive encerrada en ciudades rodeadas de enormes muros para protegerse de los titanes.",
        ImagenUrl = "/img/Shingeki.jpg"
    },

    // ===== AVENTURA =====
    new Item {
        Id = 5,
        Titulo = "Sword Art Online",
        Genero = "Aventura",
        Ano = 2012,
        Estudio = "A-1 Pictures",
        Estado = "Terminado",
        Calificacion = 8,
        Descripcion = "Miles de jugadores quedan atrapados en un videojuego de realidad virtual del que solo pueden salir ganando.",
        ImagenUrl = "/img/SAO.jpeg"
    },
    new Item {
        Id = 6,
        Titulo = "Mushoku Tensei",
        Genero = "Aventura",
        Ano = 2021,
        Estudio = "Studio Bind",
        Estado = "Viendo",
        Calificacion = 9,
        Descripcion = "Un hombre reencarna en un mundo de fantasía y decide vivir su nueva vida sin arrepentimientos.",
        ImagenUrl = "/img/mushoku tensei.jpeg"
    },
    new Item {
        Id = 7,
        Titulo = "Konosuba",
        Genero = "Aventura",
        Ano = 2016,
        Estudio = "Studio Deen",
        Estado = "Terminado",
        Calificacion = 9,
        Descripcion = "Un chico reencarna en un mundo de fantasía con una diosa inútil y forma el grupo de aventureros más caótico.",
        ImagenUrl = "/img/Konosuba.jpeg"
    },
    new Item {
        Id = 8,
        Titulo = "Nanatsu no Taizai",
        Genero = "Aventura",
        Ano = 2014,
        Estudio = "A-1 Pictures",
        Estado = "Terminado",
        Calificacion = 8,
        Descripcion = "Una princesa busca a los Siete Pecados Capitales para salvar su reino de los Caballeros Sagrados.",
        ImagenUrl = "/img/Nanatsu.jpeg"
    },

    // ===== ROMANCE =====
    new Item {
        Id = 9,
        Titulo = "Kaguya-sama: Love is War",
        Genero = "Romance",
        Ano = 2019,
        Estudio = "A-1 Pictures",
        Estado = "Terminado",
        Calificacion = 10,
        Descripcion = "Dos estudiantes genios se gustan mutuamente pero ninguno quiere confesar primero.",
        ImagenUrl = "/img/Kaguya-sama.jpeg"
    },
    new Item {
        Id = 10,
        Titulo = "Your Lie in April",
        Genero = "Romance",
        Ano = 2014,
        Estudio = "A-1 Pictures",
        Estado = "Terminado",
        Calificacion = 10,
        Descripcion = "Un pianista que perdió la capacidad de escuchar su música vuelve a la vida gracias a una violinista.",
        ImagenUrl = "/img/your lie in april.jpeg"
    },
    new Item {
        Id = 11,
        Titulo = "Sono Bisque Doll",
        Genero = "Romance",
        Ano = 2022,
        Estudio = "CloverWorks",
        Estado = "Terminado",
        Calificacion = 9,
        Descripcion = "Un chico tímido que hace vestidos de muñecas ayuda a una chica popular con sus cosplays.",
        ImagenUrl = "/img/Sono Bisque doll.jpeg"
    },

    new Item {
        Id = 12,
        Titulo = "Horimiya",
        Genero = "Romance",
        Ano = 2021,
        Estudio = "CloverWorks",
        Estado = "Terminado",
        Calificacion = 9,
        Descripcion = "Dos estudiantes descubren sus lados ocultos y desarrollan una relación especial.",
        ImagenUrl = "/img/Horimiya.jpeg"
    },

    // ===== ACCIÓN =====
    new Item {
        Id = 13,
        Titulo = "Fire Force",
        Genero = "Acción",
        Ano = 2019,
        Estudio = "David Production",
        Estado = "Terminado",
        Calificacion = 8,
        Descripcion = "Bomberos especiales luchan contra seres humanos que se convierten espontáneamente en llamas.",
        ImagenUrl = "/img/Fire force.jpeg"
    },

    // ===== AVENTURA =====
    new Item {
        Id = 14,
        Titulo = "JoJo's Bizarre Adventure",
        Genero = "Aventura",
        Ano = 2012,
        Estudio = "David Production",
        Estado = "Viendo",
        Calificacion = 9,
        Descripcion = "La saga generacional de la familia Joestar y sus extrañas aventuras contra el mal.",
        ImagenUrl = "/img/Jojos.png"
    },

    // ===== ROMANCE =====
    new Item {
        Id = 15,
        Titulo = "Nisekoi",
        Genero = "Romance",
        Ano = 2014,
        Estudio = "Shaft",
        Estado = "Terminado",
        Calificacion = 8,
        Descripcion = "El hijo de un yakuza y la hija de un gánster deben fingir ser novios para evitar una guerra entre bandas.",
        ImagenUrl = "/img/Nisekoi.jpg"
    }

};

        // Lista — con filtro opcional por género
        public IActionResult Index(string? genero)
        {
            var resultado = string.IsNullOrEmpty(genero)
                ? _items
                : _items.Where(i => i.Genero == genero).ToList();

            ViewBag.Generos = _items.Select(i => i.Genero).Distinct().ToList();
            ViewBag.GeneroActual = genero;

            return View(resultado);
        }

        // Detalle
        public IActionResult Detalle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            return item == null ? NotFound() : View(item);
        }

        // Formulario — GET
        public IActionResult Agregar()
        {
            return View();
        }

        // Formulario — POST
        [HttpPost]
        public IActionResult Agregar(Item item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
            return RedirectToAction("Index");
        }
    }
}