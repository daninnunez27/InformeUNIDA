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
    public class InstitucionController : Controller
    {
        [HttpGet]
        public List<SelectListItem> ObtenerListarInstitucion(Int32 cusuario)
        {
            List<SelectListItem> lista = new List<SelectListItem>();

            //using (sofya_AcadContext db = new sofya_AcadContext())
            //{
            //    lista = (from a in db.Institucions
            //             group new { a } by new { a.Cinstitucion, a.Dinstitucion } into g
            //             select new SelectListItem
            //             {
            //                 Value = g.Key.Cinstitucion.ToString(),
            //                 Text = g.Key.Dinstitucion
            //             }).OrderBy(c => c.Value).ToList();
            //    lista.Insert(0, new SelectListItem
            //    {
            //        Value = "-3",
            //        Text = "-- Seleccionar Institución --"
            //    });
            //}
            using (sofya_AcadContext db = new sofya_AcadContext())
            {
                lista = (from a in db.FuncionarioWebCarreras
                            join b in db.FuncionarioWebs on a.Cfuncionario equals b.Cfuncionario
                            join c in db.Carreras on a.Ccarrera equals c.Ccarrera
                            join d in db.Institucions on c.Cinstitucion equals d.Cinstitucion
                         where b.Cusuario == cusuario
                         group new { c,d } by new { c.Cinstitucion, d.Dinstitucion } into g
                         select new SelectListItem
                         {
                             Value = g.Key.Cinstitucion.ToString(),
                             Text = g.Key.Dinstitucion
                         }).OrderBy(c => c.Value).ToList();
                lista.Insert(0, new SelectListItem
                {
                    Value = "-3",
                    Text = "-- Seleccionar Institución --"
                });
            }
            return lista;
        }

    }
}
