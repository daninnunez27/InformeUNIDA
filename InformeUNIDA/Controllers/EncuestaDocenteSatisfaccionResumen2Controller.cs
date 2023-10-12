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
    public class EncuestaDocenteSatisfaccionResumen2Controller : Controller
    {
        public FileResult ExportarExcelReporteEncuestaDocenteSatisfaccionResumen2Lista(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            var url = $"" + Configuracion.url + "/api/encuestaDocenteSatisfaccionResumen2Lista/" + cinstitucion_p.ToString() + "/" + cprograma_p.ToString() + "/" + cperiodo_p.ToString() + "/" + ccarrera_p.ToString();
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            List<EncuestaDocenteSatistaccionResumenDTO> resultado = new List<EncuestaDocenteSatistaccionResumenDTO>();

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

                            List<EncuestaDocenteSatistaccionResumenDTO> lista = JsonConvert.DeserializeObject<List<EncuestaDocenteSatistaccionResumenDTO>>(json);

                            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                            string fileName = "DocenteSatisfaccionResumenLista.xlsx";
                            try
                            {
                                using (var workbook = new XLWorkbook())
                                {
                                    IXLWorksheet worksheet =
                                    workbook.Worksheets.Add("DocenteSatisfaccionResumenLista");
                                    worksheet.Cell(1, 1).Value = "ENCUETA DE DOCENTE A SATISFACCIÓN RESUMEN F2 - LISTA";
                                    worksheet.Cell(2, 1).Value = "SEDE";
                                    worksheet.Cell(2, 2).Value = "PROGRAMA";
                                    worksheet.Cell(2, 3).Value = "PERIODO";
                                    worksheet.Cell(2, 4).Value = "CARRERA";
                                    worksheet.Cell(2, 5).Value = "NRO. PREGUNTA";
                                    worksheet.Cell(2, 6).Value = "PREGUNTA DESCRIPCIÓN";
                                    worksheet.Cell(2, 7).Value = "CANT. RESP1";
                                    worksheet.Cell(2, 8).Value = "CANT. RESP2";
                                    worksheet.Cell(2, 9).Value = "CANT. RESP3";
                                    worksheet.Cell(2, 10).Value = "CANT. RESP4";
                                    worksheet.Cell(2, 11).Value = "CANT. RESP5";
                                    worksheet.Cell(2, 12).Value = "ITEM";
                                    worksheet.Cell(2, 13).Value = "DIMENSIÓN";

                                    var rangoT = worksheet.Range("A1:M1");
                                    rangoT.Style.Font.FontColor = XLColor.Blue;
                                    rangoT.Style.Font.Bold = true;
                                    rangoT.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    rangoT.Merge(true);

                                    var rango = worksheet.Range("A2:M2");
                                    rango.Style.Font.FontColor = XLColor.Blue;
                                    rango.Style.Font.Bold = true;
                                    rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                    for (int index = 1; index <= lista.Count; index++)
                                    {
                                        worksheet.Cell(index + 2, 1).Value = lista[index - 1].dinstitucion;
                                        worksheet.Cell(index + 2, 2).Value = lista[index - 1].dprograma;
                                        worksheet.Cell(index + 2, 3).Value = lista[index - 1].dperiodo + "_";
                                        worksheet.Cell(index + 2, 4).Value = lista[index - 1].dcarrera;
                                        worksheet.Cell(index + 2, 5).Value = lista[index - 1].preguntanumero;
                                        worksheet.Cell(index + 2, 6).Value = lista[index - 1].preguntadescripcion;
                                        worksheet.Cell(index + 2, 7).Value = lista[index - 1].cant_resp1;
                                        worksheet.Cell(index + 2, 8).Value = lista[index - 1].cant_resp2;
                                        worksheet.Cell(index + 2, 9).Value = lista[index - 1].cant_resp3;
                                        worksheet.Cell(index + 2, 10).Value = lista[index - 1].cant_resp4;
                                        worksheet.Cell(index + 2, 11).Value = lista[index - 1].cant_resp5;
                                        worksheet.Cell(index + 2, 12).Value = lista[index - 1].item;
                                        worksheet.Cell(index + 2, 13).Value = lista[index - 1].dimension;
                                    }
                                    worksheet.Columns(1, 13).AdjustToContents();

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
