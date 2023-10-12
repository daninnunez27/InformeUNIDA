using InformeUNIDA.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeUNIDA.Controllers
{
    [EnableCors("AllowAllOrigins")]
    public class PeriodoController : Controller
    {
        [HttpGet]
        public List<SelectListItem> ObtenerListarPeriodo(Int32 cinstitucion, Int32 cprograma, String valor)
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            List<SelectListItem> listaPostgrado = new List<SelectListItem>();
            List<SelectListItem> listaVirtual = new List<SelectListItem>();
            List<SelectListItem> listaTemporal = new List<SelectListItem>();

            using (sofya_AcadContext db = new sofya_AcadContext())
            {
                switch (valor)
                {
                    case "1":
                    case "2":
                        listaPostgrado = (from a in db.Encuesta
                                          join b in db.Periodos
                                          on a.Cperiodo equals b.Cperiodo
                                          where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cprograma == 6
                                          group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                          select new SelectListItem
                                          {
                                              Text = g.Key.Dperiodo,
                                              Value = g.Key.Cperiodo.ToString()
                                          }).OrderByDescending(c => c.Text).ToList();

                        listaTemporal = (from a in db.EncuestaAlumnoADocentes
                                         join b in db.Periodos
                                         on a.Cperiodo equals b.Cperiodo
                                         where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                         group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                         select new SelectListItem
                                         {
                                             Text = g.Key.Dperiodo,
                                             Value = g.Key.Cperiodo.ToString()
                                         }).OrderByDescending(c => c.Text).ToList();

                        lista = listaPostgrado.Union(listaTemporal).ToList();

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "3":
                        lista = (from a in db.EncuestaAlumnoABibliotecas
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "4":
                        lista = (from a in db.EncuestaAlumnoASgas
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "5":
                        lista = (from a in db.EncuestaAlumnoACoordinadors
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "6":
                        lista = (from a in db.EncuestaAlumnoACafeteria
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "7":
                        lista = (from a in db.EncuestaAlumnoAInfraestructuras
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "8":
                        lista = (from a in db.EncuestaAlumnoALibreria
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "9":
                        lista = (from a in db.EncuestaAlumnoALaboratorios
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "10":
                        listaVirtual = (from a in db.EncuestaDocenteAAutoevaluacions
                                        join b in db.Periodos
                                        on a.Cperiodo equals b.Cperiodo
                                        where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cprograma == 9 && a.Cuestionario== "C0027"
                                        group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                        select new SelectListItem
                                        {
                                            Text = g.Key.Dperiodo,
                                            Value = g.Key.Cperiodo.ToString()
                                        }).OrderBy(c => c.Text).ToList();

                        listaTemporal = (from a in db.EncuestaDocenteAAutoevaluacions
                                        join b in db.Periodos
                                        on a.Cperiodo equals b.Cperiodo
                                        where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cuestionario == "C0017"
                                         group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                        select new SelectListItem
                                        {
                                            Text = g.Key.Dperiodo,
                                            Value = g.Key.Cperiodo.ToString()
                                        }).OrderBy(c => c.Text).ToList();

                        lista = listaVirtual.Union(listaTemporal).ToList();

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "11":
                        lista = (from a in db.EncuestaDocenteABibliotecas
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "12":
                        lista = (from a in db.EncuestaDocenteACafeteria
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "13":
                        lista = (from a in db.EncuestaDocenteAInfraestructuras
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "14":
                        lista = (from a in db.EncuestaDocenteALaboratorios
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "15":
                        lista = (from a in db.EncuestaDocenteALibreria
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "16":
                        lista = (from a in db.EncuestaDocenteASgps
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "17":
                        lista = (from a in db.EncuestaDocenteAAlumnos
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "18":
                        lista = (from a in db.EncuestaDocenteACoordinadors
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "19":
                        lista = (from a in db.EncuestaFuncionarioAAutoevaluacions
                                 where a.Cinstitucion == cinstitucion 
                                 group new { a } by new { a.Anio } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Anio.ToString(),
                                     Value = g.Key.Anio.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "20":
                        lista = (from a in db.EncuestaEgresadoARetroalimentacions
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma
                                 group new { a } by new { a.Anio } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Anio.ToString(),
                                     Value = g.Key.Anio.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "21":
                        lista = (from a in db.EncuestaCoordinadorAAutoevaluacions
                                 where a.Cinstitucion == cinstitucion
                                 group new { a } by new { a.Anio } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Anio.ToString(),
                                     Value = g.Key.Anio.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "22":
                        lista = (from a in db.EncuestaCoordinadorAProfesors
                                 where a.Cinstitucion == cinstitucion
                                 group new { a } by new { a.Anio } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Anio.ToString(),
                                     Value = g.Key.Anio.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "23":
                        lista = (from a in db.Encuesta
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cuestionario == "C0028"
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "24":
                        lista = (from a in db.Encuesta
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cuestionario == "C0029"
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "25":
                        lista = (from a in db.Encuesta
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cuestionario == "C0029"
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "26":
                        lista = (from a in db.EncuestaDecanoACoordinadors
                                 where a.Cinstitucion == cinstitucion
                                 group new { a } by new { a.Anio } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Anio.ToString(),
                                     Value = g.Key.Anio.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "27":
                        lista = (from a in db.Encuesta
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cuestionario == "C0031"
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                    case "28":
                        lista = (from a in db.Encuesta
                                 join b in db.Periodos
                                 on a.Cperiodo equals b.Cperiodo
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cuestionario == "C0031"
                                 group new { a, b } by new { a.Cperiodo, b.Dperiodo } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dperiodo,
                                     Value = g.Key.Cperiodo.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Periodo --"
                        });
                        break;
                }
            }
            return lista;
        }

    }
}
