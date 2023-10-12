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
    public class CarreraController : Controller
    {
        [HttpGet]
        public List<SelectListItem> ObtenerListarCarrera(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, String valor)
        {
            String query = "";

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
                                          join b in db.Carreras
                                          on a.Ccarrera equals b.Ccarrera
                                          where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo && a.Cprograma == 6
                                          group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                          select new SelectListItem
                                          {
                                              Text = g.Key.Dcarrera,
                                              Value = g.Key.Ccarrera.ToString()
                                          }).OrderBy(c => c.Text).ToList();

                        listaTemporal = (from a in db.EncuestaAlumnoADocentes
                                         join b in db.Carreras
                                         on a.Ccarrera equals b.Ccarrera
                                         where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                         group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                         select new SelectListItem
                                         {
                                             Text = g.Key.Dcarrera,
                                             Value = g.Key.Ccarrera.ToString()
                                         }).OrderBy(c => c.Text).ToList();

                        lista = listaPostgrado.Union(listaTemporal).ToList();

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "0",
                            Text = "(TODAS)"
                        });
                        break;
                    case "3":
                        lista = (from a in db.EncuestaAlumnoABibliotecas
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "4":
                        lista = (from a in db.EncuestaAlumnoASgas
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "5":
                        lista = (from a in db.EncuestaAlumnoACoordinadors
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "6":
                        lista = (from a in db.EncuestaAlumnoACafeteria
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "7":
                        lista = (from a in db.EncuestaAlumnoAInfraestructuras
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "8":
                        lista = (from a in db.EncuestaAlumnoALibreria
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "9":
                        lista = (from a in db.EncuestaAlumnoALaboratorios
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "10":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Carrera --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "1000",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "11":
                        query = " select Convert(varchar(3),b.ccarrera) ccarrera,c.dcarrera " +
                                " from bloque_sesion_prof a inner join bloque b on (a.cinstitucion = b.cinstitucion and a.cprograma = b.cprograma and a.cbloque = b.cbloque) " +
                                " 	inner join carrera c on(b.ccarrera = c.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and " +
                                "        a.cperiodo = " + cperiodo.ToString() + " and a.cprofesor in(select x.cprofesor " +
                                "                                                                    from encuesta_docente_a_biblioteca x " +
                                "                                                                    where x.cinstitucion = " + cinstitucion.ToString() + " and x.cprograma = " + cprograma.ToString() + " and x.cperiodo = " + cperiodo.ToString() + " " +
                                "                                                                    group by x.cprofesor) " +
                                " group by b.ccarrera,c.dcarrera " +
                                " order by c.dcarrera ";



                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "12":
                        query = " select Convert(varchar(3),b.ccarrera) ccarrera,c.dcarrera " +
                                " from bloque_sesion_prof a inner join bloque b on (a.cinstitucion = b.cinstitucion and a.cprograma = b.cprograma and a.cbloque = b.cbloque) " +
                                " 	inner join carrera c on(b.ccarrera = c.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and " +
                                "        a.cperiodo = " + cperiodo.ToString() + " and a.cprofesor in(select x.cprofesor " +
                                "                                                                    from encuesta_docente_a_Cafeteria x " +
                                "                                                                    where x.cinstitucion = " + cinstitucion.ToString() + " and x.cprograma = " + cprograma.ToString() + " and x.cperiodo = " + cperiodo.ToString() + " " +
                                "                                                                    group by x.cprofesor) " +
                                " group by b.ccarrera,c.dcarrera " +
                                " order by c.dcarrera ";



                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "13":
                        query = " select Convert(varchar(3),b.ccarrera) ccarrera,c.dcarrera " +
                                " from bloque_sesion_prof a inner join bloque b on (a.cinstitucion = b.cinstitucion and a.cprograma = b.cprograma and a.cbloque = b.cbloque) " +
                                " 	inner join carrera c on(b.ccarrera = c.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and " +
                                "        a.cperiodo = " + cperiodo.ToString() + " and a.cprofesor in(select x.cprofesor " +
                                "                                                                    from encuesta_docente_a_infraestructura x " +
                                "                                                                    where x.cinstitucion = " + cinstitucion.ToString() + " and x.cprograma = " + cprograma.ToString() + " and x.cperiodo = " + cperiodo.ToString() + " " +
                                "                                                                    group by x.cprofesor) " +
                                " group by b.ccarrera,c.dcarrera " +
                                " order by c.dcarrera ";



                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "14":
                        query = " select Convert(varchar(3),b.ccarrera) ccarrera,c.dcarrera " +
                                " from bloque_sesion_prof a inner join bloque b on (a.cinstitucion = b.cinstitucion and a.cprograma = b.cprograma and a.cbloque = b.cbloque) " +
                                " 	inner join carrera c on(b.ccarrera = c.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and " +
                                "        a.cperiodo = " + cperiodo.ToString() + " and a.cprofesor in(select x.cprofesor " +
                                "                                                                    from encuesta_docente_a_laboratorio x " +
                                "                                                                    where x.cinstitucion = " + cinstitucion.ToString() + " and x.cprograma = " + cprograma.ToString() + " and x.cperiodo = " + cperiodo.ToString() + " " +
                                "                                                                    group by x.cprofesor) " +
                                " group by b.ccarrera,c.dcarrera " +
                                " order by c.dcarrera ";



                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "15":
                        query = " select Convert(varchar(3),b.ccarrera) ccarrera,c.dcarrera " +
                                " from bloque_sesion_prof a inner join bloque b on (a.cinstitucion = b.cinstitucion and a.cprograma = b.cprograma and a.cbloque = b.cbloque) " +
                                " 	inner join carrera c on(b.ccarrera = c.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and " +
                                "        a.cperiodo = " + cperiodo.ToString() + " and a.cprofesor in(select x.cprofesor " +
                                "                                                                    from encuesta_docente_a_Libreria x " +
                                "                                                                    where x.cinstitucion = " + cinstitucion.ToString() + " and x.cprograma = " + cprograma.ToString() + " and x.cperiodo = " + cperiodo.ToString() + " " +
                                "                                                                    group by x.cprofesor) " +
                                " group by b.ccarrera,c.dcarrera " +
                                " order by c.dcarrera ";



                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "16":
                        query = " select Convert(varchar(3),b.ccarrera) ccarrera,c.dcarrera " +
                                " from bloque_sesion_prof a inner join bloque b on (a.cinstitucion = b.cinstitucion and a.cprograma = b.cprograma and a.cbloque = b.cbloque) " +
                                " 	inner join carrera c on(b.ccarrera = c.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and " +
                                "        a.cperiodo = " + cperiodo.ToString() + " and a.cprofesor in(select x.cprofesor " +
                                "                                                                    from encuesta_docente_a_sgp x " +
                                "                                                                    where x.cinstitucion = " + cinstitucion.ToString() + " and x.cprograma = " + cprograma.ToString() + " and x.cperiodo = " + cperiodo.ToString() + " " +
                                "                                                                    group by x.cprofesor) " +
                                " group by b.ccarrera,c.dcarrera " +
                                " order by c.dcarrera ";



                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "17":
                        query = " select Convert(varchar(3),b.ccarrera) ccarrera,c.dcarrera " +
                                " from bloque_sesion_prof a inner join bloque b on (a.cinstitucion = b.cinstitucion and a.cprograma = b.cprograma and a.cbloque = b.cbloque) " +
                                " 	inner join carrera c on(b.ccarrera = c.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and " +
                                "        a.cperiodo = " + cperiodo.ToString() + " and a.cprofesor in(select x.cprofesor " +
                                "                                                                    from encuesta_docente_a_alumno x " +
                                "                                                                    where x.cinstitucion = " + cinstitucion.ToString() + " and x.cprograma = " + cprograma.ToString() + " and x.cperiodo = " + cperiodo.ToString() + " " +
                                "                                                                    group by x.cprofesor) " +
                                " group by b.ccarrera,c.dcarrera " +
                                " order by c.dcarrera ";

                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "18":
                        //query = " select convert(varchar(3),c.ccarrera),d.dcarrera " +
                        //        " from encuesta_docente_a_coordinador a inner " +
                        //        " join funcionario_web b on (a.cusuario_coordinador = b.cusuario) " +
                        //        " inner join funcionario_web_carrera c on (b.cfuncionario = c.cfuncionario) " +
                        //        " inner join carrera d on (c.ccarrera = d.ccarrera) " +
                        //        " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.cperiodo = " + cperiodo.ToString() +
                        //        " group by c.ccarrera,d.dcarrera " +
                        //        " order by dcarrera ";

                        query = " select convert(varchar(3),a.ccarrera) ccarrera,b.dcarrera " +
                                " from encuesta_docente_a_coordinador a inner " +
                                " join carrera b on (a.ccarrera = b.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.cperiodo = " + cperiodo.ToString() +
                                " group by a.ccarrera,b.dcarrera ";

                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "19":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Carrera --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "20":
                        //query = " select convert(varchar(3),c.ccarrera),d.dcarrera " +
                        //        " from encuesta_docente_a_coordinador a inner " +
                        //        " join funcionario_web b on (a.cusuario_coordinador = b.cusuario) " +
                        //        " inner join funcionario_web_carrera c on (b.cfuncionario = c.cfuncionario) " +
                        //        " inner join carrera d on (c.ccarrera = d.ccarrera) " +
                        //        " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.cperiodo = " + cperiodo.ToString() +
                        //        " group by c.ccarrera,d.dcarrera " +
                        //        " order by dcarrera ";

                        query = " select convert(varchar(3),a.ccarrera) ccarrera,b.dcarrera " +
                                " from encuesta_egresado_a_retroalimentacion a inner " +
                                " join carrera b on (a.ccarrera = b.ccarrera) " +
                                " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.anio = " + cperiodo.ToString() +
                                " group by a.ccarrera,b.dcarrera ";

                        lista = Helper.Helper.RawSqlQuery(query, x => new SelectListItem
                        {
                            Value = (String)x[0],
                            Text = (String)x[1]
                        });

                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "21":
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Carrera --"
                        });
                        lista.Insert(1, new SelectListItem
                        {
                            Value = "100",
                            Text = "-- (TODAS) --"
                        });
                        break;
                    case "22":
                        lista = (from a in db.EncuestaCoordinadorAProfesors
                                 join b in db.Usuarios
                                 on a.CusuarioCoordinador equals b.Cusuario
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Anio == cperiodo && a.Cuestionario == "C0009"
                                 group new { a, b } by new { a.CusuarioCoordinador, b.Dusuario } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dusuario,
                                     Value = g.Key.CusuarioCoordinador.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "23":
                        lista = (from a in db.Encuesta
                                 join b in db.Carreras
                                 on a.Ccarrera equals b.Ccarrera
                                 where a.Cinstitucion == cinstitucion && a.Cprograma == cprograma && a.Cperiodo == cperiodo && a.Cuestionario == "C0028"
                                 group new { a, b } by new { a.Ccarrera, b.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "24":
                        lista = (from a in db.Encuesta
                                 join b in db.BloqueSesionProfs                     
                                 on new { X1 = a.Cperiodo, X2 = a.Cprofesor } equals new { X1 =  Convert.ToInt32(b.Cperiodo.ToString()), X2 = Convert.ToInt32(b.Cprofesor.ToString()) }
                                 join c in db.Bloques on b.Cbloque equals c.Cbloque
                                 join d in db.Carreras on c.Ccarrera equals d.Ccarrera
                                 where a.Cperiodo == cperiodo && a.Cuestionario == "C0029"
                                 group new { a, b } by new { c.Ccarrera, d.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "1000",
                        //    Text = "-- (TODAS) --"
                        //});
                        break;
                    case "25":
                        lista = (from a in db.Encuesta
                                 join b in db.BloqueSesionProfs
                                 on new { X1 = a.Cperiodo, X2 = a.Cprofesor } equals new { X1 = Convert.ToInt32(b.Cperiodo.ToString()), X2 = Convert.ToInt32(b.Cprofesor.ToString()) }
                                 join c in db.Bloques on b.Cbloque equals c.Cbloque
                                 join d in db.Carreras on c.Ccarrera equals d.Ccarrera
                                 where a.Cperiodo == cperiodo && a.Cuestionario == "C0029"
                                 group new { a, b } by new { c.Ccarrera, d.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "1000",
                        //    Text = "-- (TODAS) --"
                        //});
                        break;
                    case "26":
                        lista = (from a in db.EncuestaDecanoACoordinadors
                                 join b in db.Usuarios
                                 on a.CusuarioDecano equals b.Cusuario
                                 where a.Cinstitucion == cinstitucion && a.Anio == cperiodo && a.Cuestionario == "C0030"
                                 group new { a, b } by new { a.CusuarioDecano, b.Dusuario } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dusuario,
                                     Value = g.Key.CusuarioDecano.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "-3",
                            Text = "-- Seleccionar Decano --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "0",
                        //    Text = "(TODAS)"
                        //});
                        break;
                    case "27":
                        lista = (from a in db.Encuesta
                                 join b in db.BloqueSesionProfs
                                 on new { X1 = a.Cperiodo, X2 = a.Cprofesor } equals new { X1 = Convert.ToInt32(b.Cperiodo.ToString()), X2 = Convert.ToInt32(b.Cprofesor.ToString()) }
                                 join c in db.Bloques on b.Cbloque equals c.Cbloque
                                 join d in db.Carreras on c.Ccarrera equals d.Ccarrera
                                 where a.Cperiodo == cperiodo && a.Cuestionario == "C0031"
                                 group new { a, b } by new { c.Ccarrera, d.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "1000",
                        //    Text = "-- (TODAS) --"
                        //});
                        break;
                    case "28":
                        lista = (from a in db.Encuesta
                                 join b in db.BloqueSesionProfs
                                 on new { X1 = a.Cperiodo, X2 = a.Cprofesor } equals new { X1 = Convert.ToInt32(b.Cperiodo.ToString()), X2 = Convert.ToInt32(b.Cprofesor.ToString()) }
                                 join c in db.Bloques on b.Cbloque equals c.Cbloque
                                 join d in db.Carreras on c.Ccarrera equals d.Ccarrera
                                 where a.Cperiodo == cperiodo && a.Cuestionario == "C0031"
                                 group new { a, b } by new { c.Ccarrera, d.Dcarrera } into g
                                 select new SelectListItem
                                 {
                                     Text = g.Key.Dcarrera,
                                     Value = g.Key.Ccarrera.ToString()
                                 }).OrderBy(c => c.Text).ToList();
                        lista.Insert(0, new SelectListItem
                        {
                            Value = "",
                            Text = "-- Seleccionar Carrera --"
                        });
                        //lista.Insert(1, new SelectListItem
                        //{
                        //    Value = "1000",
                        //    Text = "-- (TODAS) --"
                        //});
                        break;
                }
            }
            return lista;
        }

    }
}
