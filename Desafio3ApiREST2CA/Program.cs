using Desafio3ApiREST2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Desafio3ApiREST2CA
{
    class Program
    {
        const string URL_IMAGENES = "http://localhost:50686/api/Imagens/";

        static void Main(string[] args)
        {
            Console.WriteLine("PRESIONE ENTER para crear las imagenes");
            GetImagenesAsync();
            Console.ReadLine();
            //List<Imagen> imagenes = CreateImagenes(50);
            //CargarImagenesAsync(imagenes);
            Console.WriteLine("Imagenes cargadas");
            Console.ReadLine();
        }

        private static void PRESS_ENTER()
        {
            Console.WriteLine("PRESIONE ENTER");
            Console.ReadLine();
        }

        private static async void GetImagenesAsync()
        {
            var http = new HttpClient();
            var jsonlist = await http.GetStringAsync(URL_IMAGENES);
            var lista = JsonConvert.DeserializeObject <List<Imagen>>(jsonlist);

            var listaFinal = from img in lista
                             where img.Size.Heigh == 1920 && img.Size.Width == 1080
                             && img.Path.Length >= 255
                             select img;

            foreach (var img in lista)
            {
                Console.WriteLine($"Imagen nombre: {img.Nombre}.{img.Formato}.");
                
            }
            Console.ReadLine();
        }



        private static void CargarImagenesAsync(List<Imagen> imagenes)
        {
            foreach (Imagen img in imagenes)
            {
                var http = new HttpClient();
                var json = JsonConvert.SerializeObject(img);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var rta =  http.PostAsync(URL_IMAGENES, content);
            }
        }

        private static List<Imagen> CreateImagenes(int cantidad)
        {
            List<Imagen> imagenes = new List<Imagen>();
            for (int i = 1; i < cantidad; i++)
            {
                Imagen img = new Imagen()
                {
                    Id = i,
                    Formato = FormatosImagen.BMP,
                    Nombre = "Numero" + i,
                    Path = @"C:\Temp",
                    Size = new Tamanio() { Heigh = 320, Width = 640 }
                };
                imagenes.Add(img);
            }
            return imagenes;
        }

    }
}
