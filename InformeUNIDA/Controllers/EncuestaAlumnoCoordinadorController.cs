using ClosedXML.Excel;
using InformeUNIDA.DTO;
using InformeUNIDA.Helper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace InformeUNIDA.Controllers
{
    [EnableCors("AllowAllOrigins")]
    public class EncuestaAlumnoCoordinadorController : Controller
    {
        public FileResult ExportarExcelReporteEncuestaAlumnoCoordinadorLista(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            var url = $"" + Configuracion.url + "/api/encuestaAlumnoCoordinadorLista/" + cinstitucion_p.ToString() + "/" + cprograma_p.ToString() + "/" + cperiodo_p.ToString() + "/" + ccarrera_p.ToString();
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            List<EncuestaAlumnoCoordinadorDTO> resultado = new List<EncuestaAlumnoCoordinadorDTO>();

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

                            List<EncuestaAlumnoCoordinadorDTO> lista = JsonConvert.DeserializeObject<List<EncuestaAlumnoCoordinadorDTO>>(json);

                            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                            string fileName = "AlumnoCoordinadorLista.xlsx";
                            try
                            {
                                using (var workbook = new XLWorkbook())
                                {
                                    IXLWorksheet worksheet =
                                    workbook.Worksheets.Add("AlumnoCoordinadorLista");
                                    worksheet.Cell(1, 1).Value = "ENCUETA DE ALUMNO A COORDINADOR - LISTA";
                                    worksheet.Cell(2, 1).Value = "SEDE";
                                    worksheet.Cell(2, 2).Value = "PROGRAMA";
                                    worksheet.Cell(2, 3).Value = "PERIODO";
                                    worksheet.Cell(2, 4).Value = "CARRERA";
                                    worksheet.Cell(2, 5).Value = "COORDINADOR";
                                    worksheet.Cell(2, 6).Value = "PARTE";
                                    worksheet.Cell(2, 7).Value = "NRO. PREGUNTA";
                                    worksheet.Cell(2, 8).Value = "PREGUNTA DESCRIPCIÓN";
                                    worksheet.Cell(2, 9).Value = "SI";
                                    worksheet.Cell(2, 10).Value = "NO";
                                    worksheet.Cell(2, 11).Value = "Muy en desacuerdo";
                                    worksheet.Cell(2, 12).Value = "En desacuerdo";
                                    worksheet.Cell(2, 13).Value = "Neutro";
                                    worksheet.Cell(2, 14).Value = "De acuerdo";
                                    worksheet.Cell(2, 15).Value = "Muy de acuerdo";
                                    worksheet.Cell(2, 16).Value = "PROM. PREGUNTA";
                                    worksheet.Cell(2, 17).Value = "CANT. ALUMNOS";

                                    var rangoT = worksheet.Range("A1:Q1");
                                    rangoT.Style.Font.FontColor = XLColor.Blue;
                                    rangoT.Style.Font.Bold = true;
                                    rangoT.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    rangoT.Merge(true);

                                    var rango = worksheet.Range("A2:Q2");
                                    rango.Style.Font.FontColor = XLColor.Blue;
                                    rango.Style.Font.Bold = true;
                                    rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                    for (int index = 1; index <= lista.Count; index++)
                                    {
                                        worksheet.Cell(index + 2, 1).Value = lista[index - 1].dinstitucion;
                                        worksheet.Cell(index + 2, 2).Value = lista[index - 1].dprograma;
                                        worksheet.Cell(index + 2, 3).Value = lista[index - 1].dperiodo + "_";
                                        worksheet.Cell(index + 2, 4).Value = lista[index - 1].dcarrera;
                                        worksheet.Cell(index + 2, 5).Value = lista[index - 1].dusuario;
                                        worksheet.Cell(index + 2, 6).Value = lista[index - 1].parte;
                                        worksheet.Cell(index + 2, 7).Value = lista[index - 1].preguntanumero;
                                        worksheet.Cell(index + 2, 8).Value = lista[index - 1].preguntadescripcion;
                                        worksheet.Cell(index + 2, 9).Value = lista[index - 1].SI;
                                        worksheet.Cell(index + 2, 10).Value = lista[index - 1].NO;
                                        worksheet.Cell(index + 2, 11).Value = lista[index - 1].muy_en_desacuerdo;
                                        worksheet.Cell(index + 2, 12).Value = lista[index - 1].en_desacuerdo;
                                        worksheet.Cell(index + 2, 13).Value = lista[index - 1].neutro;
                                        worksheet.Cell(index + 2, 14).Value = lista[index - 1].de_acuerdo;
                                        worksheet.Cell(index + 2, 15).Value = lista[index - 1].muy_de_acuerdo;
                                        worksheet.Cell(index + 2, 16).Value = lista[index - 1].promedio_pregunta;
                                        worksheet.Cell(index + 2, 17).Value = lista[index - 1].cant_alumnos;
                                    }
                                    worksheet.Columns(1, 17).AdjustToContents();

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
