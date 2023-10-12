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
    public class EncuestaFuncionarioAutoevaluacionController : Controller
    {
        public FileResult ExportarExcelReporteEncuestaFuncionarioAutoevaluacionLista(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            var url = $"" + Configuracion.url + "/api/encuestaFuncionarioAutoevaluacionLista/" + cinstitucion_p.ToString() + "/" + cprograma_p.ToString() + "/" + cperiodo_p.ToString() ;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            List<EncuestaAlumnoSgaDTO> resultado = new List<EncuestaAlumnoSgaDTO>();

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

                            List<EncuestaFuncionarioAutoevaluacionDTO> lista = JsonConvert.DeserializeObject<List<EncuestaFuncionarioAutoevaluacionDTO>>(json);

                            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                            string fileName = "FuncionarioAutoevaluacionLista.xlsx";
                            try
                            {
                                using (var workbook = new XLWorkbook())
                                {
                                    IXLWorksheet worksheet =
                                    workbook.Worksheets.Add("FuncionarioAutoevaluacionLista");
                                    worksheet.Cell(1, 1).Value = "ENCUETA DE FUNCIONARIO A AUTOEVALUACION - LISTA";
                                    worksheet.Cell(2, 1).Value = "SEDE";
                                    worksheet.Cell(2, 2).Value = "AÑO";                                   
                                    worksheet.Cell(2, 3).Value = "NRO. PREGUNTA";
                                    worksheet.Cell(2, 4).Value = "PREGUNTA DESCRIPCIÓN";
                                    worksheet.Cell(2, 5).Value = "PROM. PREGUNTA";
                                    worksheet.Cell(2, 6).Value = "PROM. AÑO";
                                    worksheet.Cell(2, 7).Value = "CANT. FUNCIONARIOS";

                                    var rangoT = worksheet.Range("A1:G1");
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
                                        worksheet.Cell(index + 2, 2).Value = lista[index - 1].anio;                                      
                                        worksheet.Cell(index + 2, 3).Value = lista[index - 1].preguntanumero;
                                        worksheet.Cell(index + 2, 4).Value = lista[index - 1].preguntadescripcion;
                                        worksheet.Cell(index + 2, 5).Value = lista[index - 1].promedio_pregunta;
                                        worksheet.Cell(index + 2, 6).Value = lista[index - 1].promedio_anio;
                                        worksheet.Cell(index + 2, 7).Value = lista[index - 1].cant_funcionarios;
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
