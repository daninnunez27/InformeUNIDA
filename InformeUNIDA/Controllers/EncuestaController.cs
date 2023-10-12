using ClosedXML.Excel;
using InformeUNIDA.Models;
using InformeUNIDA.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using InformeUNIDA.Clases;
using InformeUNIDA.DTO;
using Microsoft.AspNetCore.Cors;

namespace InformeUNIDA.Controllers
{
    [EnableCors("AllowAllOrigins")]
    public class EncuestaController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        private InstitucionController institucion = new InstitucionController();
        private ProgramaController programa = new ProgramaController();
        private PeriodoController periodo = new PeriodoController();
        private CarreraController carrera = new CarreraController();
        private ProfesorController profesor = new ProfesorController();

        private EncuestaAlumnoDocenteController encuestaAlumnoDocente = new EncuestaAlumnoDocenteController();
        private EncuestaAlumnoBibliotecaController encuestaAlumnoBiblioteca = new EncuestaAlumnoBibliotecaController();
        private EncuestaAlumnoSgaController encuestaAlumnoSga = new EncuestaAlumnoSgaController();
        private EncuestaAlumnoCoordinadorController encuestaAlumnoCoordinador = new EncuestaAlumnoCoordinadorController();
        private EncuestaAlumnoInfraestructuraController encuestaAlumnoInfraestructura = new EncuestaAlumnoInfraestructuraController();
        private EncuestaAlumnoLaboratorioController encuestaAlumnoLaboratorio = new EncuestaAlumnoLaboratorioController();
        private EncuestaAlumnoLibreriaController encuestaAlumnoLibreria = new EncuestaAlumnoLibreriaController();
        private EncuestaAlumnoCafeteriaController encuestaAlumnoCafeteria = new EncuestaAlumnoCafeteriaController();
        private EncuestaAlumnoSatisfaccionController encuestaAlumnoSatisfaccion = new EncuestaAlumnoSatisfaccionController();

        private EncuestaDocenteAutoevaluacionController encuestaDocenteAutoevaluacion = new EncuestaDocenteAutoevaluacionController();
        private EncuestaDocenteBibliotecaController encuestaDocenteBiblioteca = new EncuestaDocenteBibliotecaController();
        private EncuestaDocenteCafeteriaController encuestaDocenteCafeteria = new EncuestaDocenteCafeteriaController();
        private EncuestaDocenteInfraestructuraController encuestaDocenteInfraestructura = new EncuestaDocenteInfraestructuraController();
        private EncuestaDocenteLaboratorioController encuestaDocenteLaboratorio = new EncuestaDocenteLaboratorioController();
        private EncuestaDocenteLibreriaController encuestaDocenteLibreria = new EncuestaDocenteLibreriaController();
        private EncuestaDocenteSgpController encuestaDocenteSgp = new EncuestaDocenteSgpController();
        private EncuestaDocenteAlumnoController encuestaDocenteAlumno = new EncuestaDocenteAlumnoController();
        private EncuestaDocenteCoordinadorController encuestaDocenteCoordinador = new EncuestaDocenteCoordinadorController();
        private EncuestaDocenteSatisfaccionController encuestaDocenteSatisfaccion = new EncuestaDocenteSatisfaccionController();
        private EncuestaDocenteSatisfaccionResumenController encuestaDocenteSatisfaccionResumen = new EncuestaDocenteSatisfaccionResumenController();
        private EncuestaDocenteSatisfaccion2Controller encuestaDocenteSatisfaccion2 = new EncuestaDocenteSatisfaccion2Controller();
        private EncuestaDocenteSatisfaccionResumen2Controller encuestaDocenteSatisfaccionResumen2 = new EncuestaDocenteSatisfaccionResumen2Controller();

        private EncuestaFuncionarioAutoevaluacionController encuestaFuncionarioAutoevaluacion = new EncuestaFuncionarioAutoevaluacionController();

        private EncuestaCoordinadorAutoevaluacionController encuestaCoordinadorAutoevaluacion = new EncuestaCoordinadorAutoevaluacionController();
        private EncuestaCoordinadorDocenteController encuestaCoordinadorDocente = new EncuestaCoordinadorDocenteController();

        private EncuestaEgresadoRetroalimentacionController encuestaEgresadoRetroalimentacion = new EncuestaEgresadoRetroalimentacionController();

        private EncuestaDecanoCoordinadorController encuestaDecanoCoordinador = new EncuestaDecanoCoordinadorController();

        public EncuestaController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        //[HttpPost]
        public IActionResult Index(Int32 cusuario)
        {
            string funcionario;
            cusuario = 205;
            string vir="", pos="", pre = "";

            using (sofya_AcadContext db = new sofya_AcadContext())
            {
                var nombreFuncionario = (from a in db.Usuarios
                                         where a.Cusuario == cusuario
                                         //group new { a } by new { a.Cusuario } into g
                                         select a).FirstOrDefault();

                funcionario =  nombreFuncionario.Dusuario;


                var PruebaProgramas = (from a in db.FuncionarioWebCarreras
                                       join b in db.FuncionarioWebs on a.Cfuncionario equals b.Cfuncionario
                                       join c in db.Carreras on a.Ccarrera equals c.Ccarrera
                                       join d in db.Programas on c.Cprograma equals d.Cprograma
                                       where b.Cusuario == cusuario
                                       group new { d } by new { d.Cprograma, d.Dprograma } into g
                                       select g.Key.Cprograma).ToList();

                foreach (var p in PruebaProgramas) {
                    switch (p)
                    {
                        case 5:
                        case 13:
                            pre = "1";
                            break;
                        case 6:
                        case 16:
                            pos = "1";
                            break;
                        case 9:
                        case 17:
                            vir = "1";
                            break;
                        default:
                            // Default stuff
                            break;
                    }
                }
            }


            ViewBag.cusuario = cusuario;
            ViewBag.funcionario = "Bienvenido : " + funcionario;
            ViewBag.pre = pre;
            ViewBag.pos = pos;
            ViewBag.vir = vir;

            ViewBag.ListaInstitucion = ObtenerListarInstitucion(cusuario);
            return View();
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoDocenteGraficoAsync(Int32 cinstitucion,Int32 cprograma,Int32 cperiodo,Int32 ccarrera,Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Docente-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoDocenteGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString() + "/" + cprofesor.ToString() + "");

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;       
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoDocenteResumenAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Docente-Resumen-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoDocenteResumen/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString() + "/" + cprofesor.ToString() + "");

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoBibliotecaGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Biblioteca-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoBibliotecaGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoSgaGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Sga-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoSgaGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoCoordinadorResumenAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Coordinador-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoCoordinadorResumen/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoCafeteriaGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Cafeteria-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoCafeteriaGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoInfraestructuraGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Infraestructura-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoInfraestructuraGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoLibreriaGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Libreria-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoLibreriaGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoLaboratorioGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Laboratorio-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoLaboratorioGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaAlumnoSatisfaccionGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Alumno-a-Satisfaccion-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaAlumnoSatisfaccionGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteAutoevaluacionGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Autoevaluacion-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteAutoevaluacionGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteBibliotecaGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Biblioteca-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteBibliotecaGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteCafeteriaGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Cafeteria-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteCafeteriaGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteInfraestructuraGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Infraestructura-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteInfraestructuraGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteLaboratorioGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Laboratorio-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteLaboratorioGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteLibreriaGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Libreria-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteLibreriaGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteSgpGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Sgp-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteSgpGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteAlumnoGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Alumno-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteAlumnoGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }
        
        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteCoordinadorResumenAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Coordinador-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteCoordinadorResumen/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString() + "/" + cprofesor.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteSatisfaccionGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Satisfaccion-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteSatisfaccionGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteSatisfaccionResumenAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Satisfaccion-Resumen-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteSatisfaccionResumen/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteSatisfaccionGrafico2Async(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Satisfaccion-F2-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteSatisfaccionGrafico2/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDocenteSatisfaccionResumen2Async(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Docente-a-Satisfaccion-Resumen-F2-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDocenteSatisfaccionResumen2/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaFuncionarioAutoevaluacionGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Funcionario-a-Autoevaluacion-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaFuncionarioAutoevaluacionGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() );

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaCoordinadorAutoevaluacionGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Coordinador-a-Autoevaluacion-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaCoordinadorAutoevaluacionGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaCoordinadorDocenteGraficoAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Coordinador-a-Docente-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaCoordinadorDocenteGrafico/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString() + "/" + cprofesor.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaEgresadoRetroalimentacionResumenAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Egresado-a-Retroalimentacion-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaEgresadoRetroalimentacionResumen/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }

        [HttpPost]
        public async Task<dynamic> ReporteEncuestaDecanoCoordinadorResumenAsync(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            byte[] buffer;
            string nombreArchivo = "";
            buffer = null;

            nombreArchivo = "Encuesta-Decano-a-Coordinador-" + cinstitucion.ToString() + cprograma.ToString() + cperiodo.ToString() + ccarrera.ToString() + cprofesor.ToString() + ".pdf";

            var path = _webHostEnvironment.WebRootPath + "\\reporte\\" + nombreArchivo;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuracion.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/encuestaDecanoCoordinadorResumen/" + cinstitucion.ToString() + "/" + cprograma.ToString() + "/" + cperiodo.ToString() + "/" + ccarrera.ToString() + "/" + cprofesor.ToString());

                if (response.IsSuccessStatusCode)
                {
                    buffer = response.Content.ReadAsByteArrayAsync().Result;
                }
            }

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            System.IO.File.WriteAllBytes(path, buffer);

            return nombreArchivo;
        }
        public FileResult ProcesarExportar(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p, String opcion_p)
        {
            switch (opcion_p)
            {
                case "1":
                    return ExportarExcelReporteEncuestaAlumnoDocenteGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "2":
                    return ExportarExcelReporteEncuestaAlumnoDocenteResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "3":
                    return ExportarExcelReporteEncuestaAlumnoBibliotecaGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "4":
                    return ExportarExcelReporteEncuestaAlumnoSgaGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "5":
                    return ExportarExcelReporteEncuestaAlumnoCoordinadorResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "6":
                    return ExportarExcelReporteEncuestaAlumnoCafeteriaGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "7":
                    return ExportarExcelReporteEncuestaAlumnoInfraestructuraGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "8":
                    return ExportarExcelReporteEncuestaAlumnoLibreriaGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "9":
                    return ExportarExcelReporteEncuestaAlumnoLaboratorioGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "10":
                    return ExportarExcelReporteEncuestaDocenteAutoevaluacionGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "11":
                    return ExportarExcelReporteEncuestaDocenteBibliotecaGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "12":
                    return ExportarExcelReporteEncuestaDocenteCafeteriaGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "13":
                    return ExportarExcelReporteEncuestaDocenteInfraestructuraGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "14":
                    return ExportarExcelReporteEncuestaDocenteLaboratorioGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "15":
                    return ExportarExcelReporteEncuestaDocenteLibreriaGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "16":
                    return ExportarExcelReporteEncuestaDocenteSgpGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "17":
                    return ExportarExcelReporteEncuestaDocenteAlumnoGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "18":
                    return ExportarExcelReporteEncuestaDocenteCoordinadorResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "19":
                    return ExportarExcelReporteEncuestaFuncionarioAutoevaluacionGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "20":
                    return ExportarExcelReporteEncuestaEgresadoRetroalimentacionResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "21":
                    return ExportarExcelReporteEncuestaCoordinadorAutoevaluacionGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "22":
                    return ExportarExcelReporteEncuestaCoordinadorDocenteResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "23":
                    return ExportarExcelReporteEncuestaAlumnoSatisfaccionGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "24":
                    return ExportarExcelReporteEncuestaDocenteSatisfaccionGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "25":
                    return ExportarExcelReporteEncuestaDocenteSatisfaccionResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "26":
                    return ExportarExcelReporteEncuestaDecanoCoordinadorResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "27":
                    return ExportarExcelReporteEncuestaDocenteSatisfaccionGrafico2(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
                case "28":
                    return ExportarExcelReporteEncuestaDocenteSatisfaccionResumen2(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
            }
            return null;
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoDocenteGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoDocente.ExportarExcelReporteEncuestaAlumnoDocenteGrafico(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);         
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoDocenteResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoDocente.ExportarExcelReporteEncuestaAlumnoDocenteResumen(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);   
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoBibliotecaGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoBiblioteca.ExportarExcelReporteEncuestaAlumnoBibliotecaLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoSgaGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoSga.ExportarExcelReporteEncuestaAlumnoSgaLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoCoordinadorResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoCoordinador.ExportarExcelReporteEncuestaAlumnoCoordinadorLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoCafeteriaGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoCafeteria.ExportarExcelReporteEncuestaAlumnoCafeteriaLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoInfraestructuraGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoInfraestructura.ExportarExcelReporteEncuestaAlumnoInfraestructuraLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoLibreriaGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoLibreria.ExportarExcelReporteEncuestaAlumnoLibreriaLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoLaboratorioGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoLaboratorio.ExportarExcelReporteEncuestaAlumnoLaboratorioLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaAlumnoSatisfaccionGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaAlumnoSatisfaccion.ExportarExcelReporteEncuestaAlumnoSatisfaccionLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteAutoevaluacionGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteAutoevaluacion.ExportarExcelReporteEncuestaDocenteAutoevaluacionLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteBibliotecaGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteBiblioteca.ExportarExcelReporteEncuestaDocenteBibliotecaLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteCafeteriaGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteCafeteria.ExportarExcelReporteEncuestaDocenteCafeteriaLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteInfraestructuraGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteInfraestructura.ExportarExcelReporteEncuestaDocenteInfraestructuraLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteLaboratorioGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteLaboratorio.ExportarExcelReporteEncuestaDocenteLaboratorioLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteLibreriaGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteLibreria.ExportarExcelReporteEncuestaDocenteLibreriaLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteSgpGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteSgp.ExportarExcelReporteEncuestaDocenteSgpLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteAlumnoGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteAlumno.ExportarExcelReporteEncuestaDocenteAlumnoLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteCoordinadorResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteCoordinador.ExportarExcelReporteEncuestaDocenteCoordinadorLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteSatisfaccionGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteSatisfaccion.ExportarExcelReporteEncuestaDocenteSatisfaccionLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteSatisfaccionResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteSatisfaccionResumen.ExportarExcelReporteEncuestaDocenteSatisfaccionResumenLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteSatisfaccionGrafico2(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteSatisfaccion2.ExportarExcelReporteEncuestaDocenteSatisfaccion2Lista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDocenteSatisfaccionResumen2(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDocenteSatisfaccionResumen2.ExportarExcelReporteEncuestaDocenteSatisfaccionResumen2Lista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaFuncionarioAutoevaluacionGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaFuncionarioAutoevaluacion.ExportarExcelReporteEncuestaFuncionarioAutoevaluacionLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaEgresadoRetroalimentacionResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaEgresadoRetroalimentacion.ExportarExcelReporteEncuestaEgresadoRetroalimentacionLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaCoordinadorAutoevaluacionGrafico(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaCoordinadorAutoevaluacion.ExportarExcelReporteEncuestaCoordinadorAutoevaluacionLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaCoordinadorDocenteResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaCoordinadorDocente.ExportarExcelReporteEncuestaCoordinadorDocenteLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpPost]
        public FileResult ExportarExcelReporteEncuestaDecanoCoordinadorResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            return encuestaDecanoCoordinador.ExportarExcelReporteEncuestaDecanoCoordinadorResumenLista(cinstitucion_p, cprograma_p, cperiodo_p, ccarrera_p, cprofesor_p);
        }

        [HttpGet]
        public List<SelectListItem> ObtenerListarInstitucion(Int32 cusuario)
        {
            return institucion.ObtenerListarInstitucion(cusuario);
        }

        [HttpGet]
        public List<SelectListItem> ObtenerListarPrograma(Int32 cinstitucion, String valor,Int32 cusuario)
        {
            return programa.ObtenerListarPrograma(cinstitucion, valor,cusuario);
        }

        [HttpGet]
        public List<SelectListItem> ObtenerListarPeriodo(Int32 cinstitucion,Int32 cprograma, String valor)
        {
            return periodo.ObtenerListarPeriodo(cinstitucion, cprograma, valor);
        }

        [HttpGet]
        public List<SelectListItem> ObtenerListarCarrera(Int32 cinstitucion, Int32 cprograma,Int32 cperiodo,String valor)
        {
            return carrera.ObtenerListarCarrera(cinstitucion, cprograma, cperiodo, valor);
        }

        [HttpGet]
        public List<SelectListItem> ObtenerListarProfesor(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo,Int32 ccarrera, String valor)
        {
            return profesor.ObtenerListarProfesor(cinstitucion, cprograma, cperiodo, ccarrera, valor);
        }

    }
}