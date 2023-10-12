using DocumentFormat.OpenXml.Office2010.ExcelAc;
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
    public class ProgramaController : Controller
    {
        [HttpGet]
        public List<SelectListItem> ObtenerListarPrograma(Int32 cinstitucion, String valor, Int32 cusuario)
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            List<SelectListItem> listaPostgrado = new List<SelectListItem>();
            List<SelectListItem> listaVirtual = new List<SelectListItem>();
            List<SelectListItem> listaTemporal = new List<SelectListItem>();
            List<Programa> listaProgramasAutorizados = new List<Programa>();

            using (sofya_AcadContext db = new sofya_AcadContext())
            {
                //listaProgramasAutorizados = (from a in db.FuncionarioWebCarreras
                //                             join b in db.FuncionarioWebs on a.Cfuncionario equals b.Cfuncionario
                //                             join c in db.Carreras on a.Ccarrera equals c.Ccarrera
                //                             join d in db.Programas on c.Cprograma equals d.Cprograma
                //                             where b.Cusuario == cusuario
                //                             group new { d } by new { d.Cprograma, d.Dprograma } into g
                //                             select new Programa
                //                             {
                //                                 Dprograma = g.Key.Dprograma,
                //                                 Cprograma = g.Key.Cprograma
                //                             }).OrderBy(d => d.Dprograma).ToList();


               var PruebaProgramas = (from a in db.FuncionarioWebCarreras
                                             join b in db.FuncionarioWebs on a.Cfuncionario equals b.Cfuncionario
                                             join c in db.Carreras on a.Ccarrera equals c.Ccarrera
                                             join d in db.Programas on c.Cprograma equals d.Cprograma
                                             where b.Cusuario == cusuario
                                             group new { d } by new { d.Cprograma, d.Dprograma } into g
                                             select g.Key.Cprograma).ToList();

                switch (valor)
                {
                    case "1":
                    case "2":
                        listaPostgrado = (from a in db.Encuesta
                                          join b in db.Programas
                                          on a.Cprograma equals b.Cprograma
                                          where a.Cinstitucion == cinstitucion && a.Cprograma == 6
                                          && PruebaProgramas.Contains(b.Cprograma)
                                          group new { b } by new { b.Cprograma, b.Dprograma } into g
                                          select new SelectListItem
                                          {
                                              Text = g.Key.Dprograma,
                                              Value = g.Key.Cprograma.ToString()
                                          }).OrderBy(c => c.Text).ToList();

                        listaTemporal = (from a in db.EncuestaAlumnoADocentes
                                        join b in db.Programas
                                        on a.Cprograma equals b.Cprograma
                                        where a.Cinstitucion == cinstitucion
                                        && PruebaProgramas.Contains(b.Cprograma)
                                        group new {  b } by new { b.Cprograma, b.Dprograma } into g
                                         select new SelectListItem
                                         {
                                             Text = g.Key.Dprograma,
                                             Value = g.Key.Cprograma.ToString()
                                         }).OrderBy(c => c.Text).ToList();

                        lista = listaPostgrado.Union(listaTemporal).ToList();


                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "3":
                        lista = (from a in db.EncuestaAlumnoABibliotecas
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion
                                 && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "4":
                        lista = (from a in db.EncuestaAlumnoASgas
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "5":
                        lista = (from a in db.EncuestaAlumnoACoordinadors
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "6":
                        lista = (from a in db.EncuestaAlumnoACafeteria
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "7":
                        lista = (from a in db.EncuestaAlumnoAInfraestructuras
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "8":
                        lista = (from a in db.EncuestaAlumnoALibreria
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "9":
                        lista = (from a in db.EncuestaAlumnoALaboratorios
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "10":
                        //listaVirtual = (from a in db.EncuestaDocenteAAutoevaluacions
                        //         join b in db.Programas
                        //         on a.Cprograma equals b.Cprograma
                        //         where a.Cinstitucion == cinstitucion && a.Cprograma==9 && a.Cuestionario== "C0027"
                        //                group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                        //         select new SelectListItem
                        //         {
                        //             Text = g.Key.Dprograma,
                        //             Value = g.Key.Cprograma.ToString()
                        //         }).OrderBy(c => c.Text).ToList();

                        listaTemporal = (from a in db.EncuestaDocenteAAutoevaluacions
                                        join b in db.Programas
                                        on a.Cprograma equals b.Cprograma
                                        where a.Cinstitucion == cinstitucion && a.Cuestionario == "C0017" && PruebaProgramas.Contains(b.Cprograma)
                                         group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                        select new SelectListItem
                                        {
                                            Text = g.Key.Dprograma,
                                            Value = g.Key.Cprograma.ToString()
                                        }).OrderBy(c => c.Text).ToList();

                        lista = listaVirtual.Union(listaTemporal).ToList();

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "11":
                        lista = (from a in db.EncuestaDocenteABibliotecas
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "12":
                        lista = (from a in db.EncuestaDocenteACafeteria
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "13":
                        lista = (from a in db.EncuestaDocenteAInfraestructuras
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "14":
                        lista = (from a in db.EncuestaDocenteALaboratorios
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "15":
                        lista = (from a in db.EncuestaDocenteALibreria
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "16":
                        lista = (from a in db.EncuestaDocenteASgps
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "17":
                        lista = (from a in db.EncuestaDocenteAAlumnos
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "18":
                        lista = (from a in db.EncuestaDocenteACoordinadors
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "19":
                        //lista = (from a in db.EncuestaFuncionarioAAutoevaluacions
                        //         join b in db.Programas
                        //         on a.Cprograma equals b.Cprograma
                        //         where a.Cinstitucion == cinstitucion
                        //         group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                        //         select new SelectListItem
                        //         {
                        //             Text = g.Key.Dprograma,
                        //             Value = g.Key.Cprograma.ToString()
                        //         }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"                         
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "20":
                        lista = (from a in db.EncuestaEgresadoARetroalimentacions
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "21":
                        //lista = (from a in db.EncuestaFuncionarioAAutoevaluacions
                        //         join b in db.Programas
                        //         on a.Cprograma equals b.Cprograma
                        //         where a.Cinstitucion == cinstitucion
                        //         group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                        //         select new SelectListItem
                        //         {
                        //             Text = g.Key.Dprograma,
                        //             Value = g.Key.Cprograma.ToString()
                        //         }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "22":
                        lista = (from a in db.EncuestaCoordinadorAProfesors
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "23":
                        lista = (from a in db.Encuesta
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma 
                                 where a.Cinstitucion == cinstitucion && a.Cuestionario == "C0028" && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "24":
                        lista = (from a in db.Encuesta
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && a.Cuestionario == "C0029" && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "25":
                        lista = (from a in db.Encuesta
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && a.Cuestionario == "C0029" && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "26":
                        //lista = (from a in db.EncuestaFuncionarioAAutoevaluacions
                        //         join b in db.Programas
                        //         on a.Cprograma equals b.Cprograma
                        //         where a.Cinstitucion == cinstitucion
                        //         group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                        //         select new SelectListItem
                        //         {
                        //             Text = g.Key.Dprograma,
                        //             Value = g.Key.Cprograma.ToString()
                        //         }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "27":
                        lista = (from a in db.Encuesta
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && a.Cuestionario == "C0031" && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                    case "28":
                        lista = (from a in db.Encuesta
                                 join b in db.Programas
                                 on a.Cprograma equals b.Cprograma
                                 where a.Cinstitucion == cinstitucion && a.Cuestionario == "C0031" && PruebaProgramas.Contains(b.Cprograma)
                                 group new { a, b } by new { a.Cprograma, b.Dprograma } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dprograma,
                                     Value = g.Key.Cprograma.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Programa --"
                        });
                        break;
                }
            }
            return lista;
        }

    }
}
