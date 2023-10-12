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
    public class ProfesorController : Controller
    {
        [HttpGet]
        public List<SelectListItem> ObtenerListarProfesor(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, String valor)
        {
            String query = "";

            List<SelectListItem> lista = new List<SelectListItem>();
            List<SelectListItem> listaPostgrado = new List<SelectListItem>();
            List<SelectListItem> listaTemporal = new List<SelectListItem>();

            using (sofya_AcadContext db = new sofya_AcadContext())
            {
                switch (valor)
                {
                    case "1":
                    case "2":
                        listaPostgrado = (from a in db.Encuesta
                                          join b in db.Profesors
                                          on a.Cprofesor equals b.Cprofesor
                                          join c in db.Personas
                                          on b.Cpersona equals c.Cpersona
                                          where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo && ((a.Ccarrera == ccarrera && ccarrera != 0) || ccarrera == 0) && a.Cprograma == 6
                                          group new { a, c } by new { a.Cprofesor, c.Dpersona } into g
                                          select new SelectListItem
                                          {
                                              Text = g.Key.Dpersona,
                                              Value = g.Key.Cprofesor.ToString()
                                          }).OrderBy(c => c.Text).ToList();

                        listaTemporal = (from a in db.EncuestaAlumnoADocentes
                                 join b in db.Profesors
                                 on a.Cprofesor equals b.Cprofesor
                                 join c in db.Personas
                                 on b.Cpersona equals c.Cpersona
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo && ((a.Ccarrera == ccarrera && ccarrera != 0) || ccarrera == 0)
                                 group new { a, c } by new { a.Cprofesor, c.Dpersona } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dpersona,
                                     Value = g.Key.Cprofesor.ToString()
                                 }).OrderBy(c => c.Text).ToList();

                        lista = listaPostgrado.Union(listaTemporal).ToList();

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "3":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "4":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "5":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "6":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "7":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "8":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "9":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "10":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "11":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "12":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "13":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "14":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "15":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "16":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "17":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "18":
                        query = " select convert(varchar(3),a.cusuario_coordinador),e.dusuario " +
                                " from encuesta_docente_a_coordinador a inner " +
                                " join funcionario_web b on (a.cusuario_coordinador = b.cusuario) " +
                                " inner join funcionario_web_carrera c on (b.cfuncionario = c.cfuncionario) " +
                                " inner join carrera d on (c.ccarrera = d.ccarrera) " +
                                " inner join usuario e on (a.cusuario_coordinador = e.cusuario) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.cperiodo = " + cperiodo.ToString() + " and c.ccarrera = " + ccarrera.ToString() +
                                " group by a.cusuario_coordinador,e.dusuario " +
                                " order by e.dusuario";

                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Docente --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODOS)"
                        //});
                        break;
                    case "19":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "20":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "21":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "22":
                        query = " select convert(varchar(6),a.cprofesor),c.dpersona " +
                                " from encuesta_coordinador_a_profesor a inner " +
                                " join profesor b on (a.cprofesor = b.cprofesor) " +
                                " inner join persona c on (b.cpersona = c.cpersona) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.anio = " + cperiodo.ToString() + " and a.cusuario_coordinador = " + ccarrera.ToString() +
                                " group by a.cprofesor,c.dpersona " +
                                " order by c.dpersona ";

                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar el Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "(TODOS)"
                        });
                        break;
                    case "23":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "24":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "25":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "26":
                        lista = (from a in db.EncuestaDecanoACoordinadors
                                 join b in db.Usuarios
                                 on a.CusuarioCoordinador equals b.Cusuario
                                 where a.Cinstitucion == cinstitucion && a.Anio == cperiodo && a.Cuestionario == "C0030" && a.CusuarioDecano== ccarrera
                                 group new { a, b } by new { a.CusuarioCoordinador, b.Dusuario } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dusuario,
                                     Value = g.Key.CusuarioCoordinador.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Coordinador --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODOS)"
                        });
                        break;
                    case "27":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "28":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Docente --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                }
            }
            return lista;
        }

    }
}
