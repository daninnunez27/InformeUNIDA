using ClosedXML.Excel;
using InformeUNIDA.Clases;
using InformeUNIDA.DTO;
using InformeUNIDA.Helper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace InformeUNIDA.Controllers
{
    [EnableCors("AllowAllOrigins")]
    public class EncuestaAlumnoDocenteController : Controller
    {
        public FileResult ExportarExcelReporteEncuestaAlumnoDocenteGrafico(Int32 cinstitucion, Int32 cprograma, Int32 cperiodo, Int32 ccarrera, Int32 cprofesor)
        {
            String query;

            if (cprograma == 6)
            {
                query = " select a.cuestionario," +
                        "     a.cinstitucion,dinstitucion =(select x.dinstitucion from institucion x where x.cinstitucion=a.cinstitucion), " +
                        "     a.cprograma,dprograma = (select x.dprograma from programa x where x.cprograma = a.cprograma), " +
                        "     a.cperiodo,dperiodo = (select x.dperiodo from periodo x where x.cperiodo=a.cperiodo), " +
                        "     a.ccarrera,dcarrera = (select x.dcarrera from carrera x where x.ccarrera=a.ccarrera), " +
                        "     a.cprofesor,dprofesor = (select x.dpersona from persona x inner join profesor y on(x.cpersona=y.cpersona) where y.cprofesor=a.cprofesor), " +
                        "     a.ccurso,dcurso = (select x.dcurso from curso x where x.ccurso=a.ccurso), " +
                        "     a.cbloque,dbloque = (select x.dbloque from bloque x where x.cbloque=a.cbloque), " +
                        "     a.preguntanumero, " +
                        "     promedio_pregunta = (round(((((select count(x.resp1) from encuesta x " +
                        "                                    where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                                    and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                                    and x.resp1 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*1) + " +
                        "                         ((select count(x.resp2) from encuesta x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp2 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*2) + " +
                        "                         ((select count(x.resp3) from encuesta x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp3 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*3) + " +
                        "                         ((select count(x.resp4) from encuesta x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp4 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*4) + " +
                        "                         ((select count(x.resp5) from encuesta x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp5 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*5))/ " +
                        "                     cast((select COUNT(distinct x.calumno) from encuesta x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario and x.ccarrera = a.ccarrera) as float)),2)), " +
                        "     turno = (select (case x.cmodalidad when 1 then 'MAÑANA' when 2 then 'TARDE' when 3 then 'NOCHE' " +
                        "                         when 4 then 'MAÑANA' when 5 then 'TARDE' when 6 then 'NOCHE' " +
                        "                         when 16 then 'MAÑANA' when 17 then 'TARDE' when 18 then 'NOCHE' else '' end) " +
                        "             from bloque x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque), " +
                        "     promedio_curso = round((( " +
                        "                       (select round(COUNT(x.resp1), 2) * 1 from encuesta x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp1 = 1) + " +
                        "                       (select round(COUNT(x.resp2), 2) * 2 from encuesta x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp2 = 1) + " +
                        "                             (select round(COUNT(x.resp3), 2) * 3 from encuesta x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp3 = 1) + " +
                        "                                                 (select round(COUNT(x.resp4), 2) * 4 from encuesta x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp4 = 1) + " +
                        "                                                              (select round(COUNT(x.resp5), 2) * 5 from encuesta x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp5 = 1) " +
                        "						  )/ " +
                        "                       (select round(cast(COUNT(*) as float), 2) from encuesta x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor)),2), " +
                        "     totalalumno = (select COUNT(distinct x.calumno) from encuesta x " +
                        "                    where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                     and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario and x.ccarrera = a.ccarrera) " +
                        " from encuesta a " +
                        " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.cperiodo = " + cperiodo.ToString() + " and " +
                        "     ((a.ccarrera = " + ccarrera.ToString() + " and " + ccarrera.ToString() + " != 0) or (" + ccarrera.ToString() + "= 0)) and " +
                        "     ((a.cprofesor = " + cprofesor.ToString() + " and " + cprofesor.ToString() + "!= 0) or (" + cprofesor.ToString() + " = 0)) " +
                        " group by a.cuestionario,a.cinstitucion,a.cprograma,a.cperiodo,a.ccarrera,a.cprofesor,a.ccurso,a.cbloque,a.preguntanumero " +
                        " order by dinstitucion,dprograma,dperiodo,dcarrera,dprofesor,dcurso,dbloque,preguntanumero ";
            }
            else
            {
                query = " select a.cuestionario," +
                        "     a.cinstitucion,dinstitucion =(select x.dinstitucion from institucion x where x.cinstitucion=a.cinstitucion), " +
                        "     a.cprograma,dprograma = (select x.dprograma from programa x where x.cprograma = a.cprograma), " +
                        "     a.cperiodo,dperiodo = (select x.dperiodo from periodo x where x.cperiodo=a.cperiodo), " +
                        "     a.ccarrera,dcarrera = (select x.dcarrera from carrera x where x.ccarrera=a.ccarrera), " +
                        "     a.cprofesor,dprofesor = (select x.dpersona from persona x inner join profesor y on(x.cpersona=y.cpersona) where y.cprofesor=a.cprofesor), " +
                        "     a.ccurso,dcurso = (select x.dcurso from curso x where x.ccurso=a.ccurso), " +
                        "     a.cbloque,dbloque = (select x.dbloque from bloque x where x.cbloque=a.cbloque), " +
                        "     a.preguntanumero, " +
                        "     promedio_pregunta = (round(((((select count(x.resp1) from encuesta_alumno_a_docente x " +
                        "                                    where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                                    and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                                    and x.resp1 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*1) + " +
                        "                         ((select count(x.resp2) from encuesta_alumno_a_docente x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp2 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*2) + " +
                        "                         ((select count(x.resp3) from encuesta_alumno_a_docente x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp3 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*3) + " +
                        "                         ((select count(x.resp4) from encuesta_alumno_a_docente x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp4 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*4) + " +
                        "                         ((select count(x.resp5) from encuesta_alumno_a_docente x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario " +
                        "                             and x.resp5 = 1 and x.preguntanumero = a.preguntanumero and x.ccarrera = a.ccarrera)*5))/ " +
                        "                     cast((select COUNT(distinct x.calumno) from encuesta_alumno_a_docente x " +
                        "                           where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                             and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario and x.ccarrera = a.ccarrera) as float)),2)), " +
                        "     turno = (select (case x.cmodalidad when 1 then 'MAÑANA' when 2 then 'TARDE' when 3 then 'NOCHE' " +
                        "                         when 4 then 'MAÑANA' when 5 then 'TARDE' when 6 then 'NOCHE' " +
                        "                         when 16 then 'MAÑANA' when 17 then 'TARDE' when 18 then 'NOCHE' else '' end) " +
                        "             from bloque x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque), " +
                        "     promedio_curso = round((( " +
                        "                       (select round(COUNT(x.resp1), 2) * 1 from encuesta_alumno_a_docente x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp1 = 1 and not x.preguntanumero = 21) + " +
                        "                       (select round(COUNT(x.resp2), 2) * 2 from encuesta_alumno_a_docente x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp2 = 1 and not x.preguntanumero = 21) + " +
                        "                             (select round(COUNT(x.resp3), 2) * 3 from encuesta_alumno_a_docente x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp3 = 1 and not x.preguntanumero = 21) + " +
                        "                                                 (select round(COUNT(x.resp4), 2) * 4 from encuesta_alumno_a_docente x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp4 = 1 and not x.preguntanumero = 21) + " +
                        "                                                              (select round(COUNT(x.resp5), 2) * 5 from encuesta_alumno_a_docente x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.resp5 = 1 and not x.preguntanumero = 21) " +
                        "						  )/ " +
                        "                       (select round(cast(COUNT(*) as float), 2) from encuesta_alumno_a_docente x where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.ccarrera = a.ccarrera and x.cbloque = a.cbloque and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and not x.preguntanumero = 21)),2), " +
                        "     totalalumno = (select COUNT(distinct x.calumno) from encuesta_alumno_a_docente x " +
                        "                    where x.cinstitucion = a.cinstitucion and x.cprograma = a.cprograma and x.cperiodo = a.cperiodo and x.cbloque = a.cbloque " +
                        "                     and x.ccurso = a.ccurso and x.cprofesor = a.cprofesor and x.cuestionario = a.cuestionario and x.ccarrera = a.ccarrera) " +
                        " from encuesta_alumno_a_docente a " +
                        " where a.cinstitucion = " + cinstitucion.ToString() + " and a.cprograma = " + cprograma.ToString() + " and a.cperiodo = " + cperiodo.ToString() + " and " +
                        "     ((a.ccarrera = " + ccarrera.ToString() + " and " + ccarrera.ToString() + " != 0) or (" + ccarrera.ToString() + "= 0)) and " +
                        "     ((a.cprofesor = " + cprofesor.ToString() + " and " + cprofesor.ToString() + "!= 0) or (" + cprofesor.ToString() + " = 0)) " +
                        " group by a.cuestionario,a.cinstitucion,a.cprograma,a.cperiodo,a.ccarrera,a.cprofesor,a.ccurso,a.cbloque,a.preguntanumero " +
                        " order by dinstitucion,dprograma,dperiodo,dcarrera,dprofesor,dcurso,dbloque,preguntanumero ";
            }

            var lista = Helper.Helper.RawSqlQuery(query, x => new EncuestaAlumnoDocenteCLS
            {
                dinstitucion = (String)x[2],
                dprograma = (String)x[4],
                dperiodo = (String)x[6],
                dcarrera = (String)x[8],
                dprofesor = (String)x[10],
                dcurso = (String)x[12],
                dbloque = (String)x[14],
                preguntanumero = (Int32)x[15],
                promedio_pregunta = (Double)x[16],
                turno = (String)x[17],
                promedio_curso = (Double)x[18],
                total_alumno = (Int32)x[19]
            });

            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "AlumnoDocenteResumen.xlsx";
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet =
                    workbook.Worksheets.Add("AlumnoDocenteResumen");
                    worksheet.Cell(1, 1).Value = "ENCUETA DE ALUMNO A DOCENTE - GRÁFICO";
                    worksheet.Cell(2, 1).Value = "SEDE";
                    worksheet.Cell(2, 2).Value = "PROGRAMA";
                    worksheet.Cell(2, 3).Value = "PERIODO";
                    worksheet.Cell(2, 4).Value = "CARRERA";
                    worksheet.Cell(2, 5).Value = "DOCENTE";
                    worksheet.Cell(2, 6).Value = "MATERIA";
                    worksheet.Cell(2, 7).Value = "BLOQUE";
                    worksheet.Cell(2, 8).Value = "N°. PREGUNTA";
                    worksheet.Cell(2, 9).Value = "PROMEDIO PREGUNTA";
                    worksheet.Cell(2, 10).Value = "TURNO";
                    worksheet.Cell(2, 11).Value = "PROMEDIO CURSO";
                    worksheet.Cell(2, 12).Value = "TOTAL ALUMNOS";

                    var rangoT = worksheet.Range("A1:L1");
                    rangoT.Style.Font.FontColor = XLColor.Blue;
                    rangoT.Style.Font.Bold = true;
                    rangoT.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    rangoT.Merge(true);

                    var rango = worksheet.Range("A2:L2");
                    rango.Style.Font.FontColor = XLColor.Blue;
                    rango.Style.Font.Bold = true;
                    rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    for (int index = 1; index <= lista.Count; index++)
                    {
                        worksheet.Cell(index + 2, 1).Value = lista[index - 1].dinstitucion;
                        worksheet.Cell(index + 2, 2).Value = lista[index - 1].dprograma;
                        worksheet.Cell(index + 2, 3).Value = lista[index - 1].dperiodo + "_";
                        worksheet.Cell(index + 2, 4).Value = lista[index - 1].dcarrera;
                        worksheet.Cell(index + 2, 5).Value = lista[index - 1].dprofesor;
                        worksheet.Cell(index + 2, 6).Value = lista[index - 1].dcurso;
                        worksheet.Cell(index + 2, 7).Value = lista[index - 1].dbloque;
                        worksheet.Cell(index + 2, 8).Value = lista[index - 1].preguntanumero;
                        worksheet.Cell(index + 2, 9).Value = lista[index - 1].promedio_pregunta;
                        worksheet.Cell(index + 2, 10).Value = lista[index - 1].turno;
                        worksheet.Cell(index + 2, 11).Value = lista[index - 1].promedio_curso;
                        worksheet.Cell(index + 2, 12).Value = lista[index - 1].total_alumno;
                    }
                    worksheet.Columns(1, 12).AdjustToContents();

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();

                        return File(content, contentType, fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public FileResult ExportarExcelReporteEncuestaAlumnoDocenteResumen(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            var url = $"" + Configuracion.url + "/api/encuestaAlumnoDocenteResumenLista/" + cinstitucion_p.ToString() + "/" + cprograma_p.ToString() + "/" + cperiodo_p.ToString() + "/" + ccarrera_p.ToString() + "/" + cprofesor_p.ToString() + "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            List<EncuestaAlumnoDocenteDTO> resultado = new List<EncuestaAlumnoDocenteDTO>();

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            var json = objReader.ReadToEnd();

                            List<EncuestaAlumnoDocenteDTO> lista = JsonConvert.DeserializeObject<List<EncuestaAlumnoDocenteDTO>>(json);

                            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                            string fileName = "AlumnoDocenteResumen.xlsx";
                            try
                            {
                                using (var workbook = new XLWorkbook())
                                {
                                    IXLWorksheet worksheet =
                                    workbook.Worksheets.Add("AlumnoDocenteResumen");
                                    worksheet.Cell(1, 1).Value = "ENCUETA DE ALUMNO A DOCENTE - RESUMEN";
                                    worksheet.Cell(2, 1).Value = "SEDE";
                                    worksheet.Cell(2, 2).Value = "PROGRAMA";
                                    worksheet.Cell(2, 3).Value = "PERIODO";
                                    worksheet.Cell(2, 4).Value = "CARRERA";
                                    worksheet.Cell(2, 5).Value = "DOCENTE";
                                    worksheet.Cell(2, 6).Value = "MATERIA";
                                    worksheet.Cell(2, 7).Value = "BLOQUE";
                                    worksheet.Cell(2, 8).Value = "PROMEDIO";
                                    worksheet.Cell(2, 9).Value = "CANT. ALUMNOS";

                                    var rangoT = worksheet.Range("A1:I1");
                                    rangoT.Style.Font.FontColor = XLColor.Blue;
                                    rangoT.Style.Font.Bold = true;
                                    rangoT.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    rangoT.Merge(true);

                                    var rango = worksheet.Range("A2:I2");
                                    rango.Style.Font.FontColor = XLColor.Blue;
                                    rango.Style.Font.Bold = true;
                                    rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                    for (int index = 1; index <= lista.Count; index++)
                                    {
                                        worksheet.Cell(index + 2, 1).Value = lista[index - 1].dinstitucion;
                                        worksheet.Cell(index + 2, 2).Value = lista[index - 1].dprograma;
                                        worksheet.Cell(index + 2, 3).Value = lista[index - 1].dperiodo + "_";
                                        worksheet.Cell(index + 2, 4).Value = lista[index - 1].dcarrera;
                                        worksheet.Cell(index + 2, 5).Value = lista[index - 1].dprofesor;
                                        worksheet.Cell(index + 2, 6).Value = lista[index - 1].dcurso;
                                        worksheet.Cell(index + 2, 7).Value = lista[index - 1].dbloque;
                                        worksheet.Cell(index + 2, 8).Value = lista[index - 1].promedio;
                                        worksheet.Cell(index + 2, 9).Value = lista[index - 1].cant_alumnos;
                                    }                                  
                                    worksheet.Columns(1, 12).AdjustToContents();

                                    using (var stream = new MemoryStream())
                                    {
                                        workbook.SaveAs(stream);
                                        var content = stream.ToArray();

                                        return File(content, contentType, fileName);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                return null;
                            }

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return null;
            }
        }

    }
}
