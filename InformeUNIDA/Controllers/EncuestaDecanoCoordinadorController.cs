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
    public class EncuestaDecanoCoordinadorController : Controller
    {
        public FileResult ExportarExcelReporteEncuestaDecanoCoordinadorResumenLista(Int32 cinstitucion_p, Int32 cprograma_p, Int32 cperiodo_p, Int32 ccarrera_p, Int32 cprofesor_p)
        {
            var url = $"" + Configuracion.url + "/api/encuestaDecanoCoordinadorResumenLista/" + cinstitucion_p.ToString() + "/" + cprograma_p.ToString() + "/" + cperiodo_p.ToString() + "/" + ccarrera_p.ToString() + "/" + cprofesor_p.ToString();
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            List<EncuestaDecanoCoordinadorDTO> resultado = new List<EncuestaDecanoCoordinadorDTO>();

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

                            List<EncuestaDecanoCoordinadorDTO> lista = JsonConvert.DeserializeObject<List<EncuestaDecanoCoordinadorDTO>>(json);

                            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                            string fileName = "DecanoCoordinadorResumenLista.xlsx";
                            try
                            {
                                using (var workbook = new XLWorkbook())
                                {
                                    IXLWorksheet worksheet =
                                    workbook.Worksheets.Add("DecanoCoordinadorResumenLista");
                                    worksheet.Cell(1, 1).Value = "ENCUETA DE DECANO A COORDINADOR RESUMEN - LISTA";
                                    worksheet.Cell(2, 1).Value = "SEDE";
                                    worksheet.Cell(2, 2).Value = "AÑO";
                                    worksheet.Cell(2, 3).Value = "GRUPO";
                                    worksheet.Cell(2, 4).Value = "NRO. PREGUNTA";
                                    worksheet.Cell(2, 5).Value = "PREGUNTA DESCRIPCIÓN";
                                    worksheet.Cell(2, 6).Value = "DECANO";
                                    worksheet.Cell(2, 7).Value = "COORDINADOR";
                                    worksheet.Cell(2, 8).Value = "CANT. RESP1";
                                    worksheet.Cell(2, 9).Value = "CANT. RESP2";
                                    worksheet.Cell(2, 10).Value = "CANT. RESP3";
                                    worksheet.Cell(2, 11).Value = "CANT. RESP4";
                                    worksheet.Cell(2, 12).Value = "CANT. RESP5";


                                    var rangoT = worksheet.Range("A1:l1");
                                    rangoT.Style.Font.FontColor = XLColor.Blue;
                                    rangoT.Style.Font.Bold = true;
                                    rangoT.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    rangoT.Merge(true);

                                    var rango = worksheet.Range("A2:l2");
                                    rango.Style.Font.FontColor = XLColor.Blue;
                                    rango.Style.Font.Bold = true;
                                    rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                    for (int index = 1; index <= lista.Count; index++)
                                    {
                                        worksheet.Cell(index + 2, 1).Value = lista[index - 1].dinstitucion;
                                        worksheet.Cell(index + 2, 2).Value = lista[index - 1].anio;
                                        worksheet.Cell(index + 2, 3).Value = lista[index - 1].dgrupo;
                                        worksheet.Cell(index + 2, 4).Value = lista[index - 1].preguntanumero;
                                        worksheet.Cell(index + 2, 5).Value = lista[index - 1].preguntadescripcion;
                                        worksheet.Cell(index + 2, 6).Value = lista[index - 1].ddecano;
                                        worksheet.Cell(index + 2, 7).Value = lista[index - 1].dcoordinador;
                                        worksheet.Cell(index + 2, 8).Value = lista[index - 1].resp1;
                                        worksheet.Cell(index + 2, 9).Value = lista[index - 1].resp2;
                                        worksheet.Cell(index + 2, 10).Value = lista[index - 1].resp3;
                                        worksheet.Cell(index + 2, 11).Value = lista[index - 1].resp4;
                                        worksheet.Cell(index + 2, 12).Value = lista[index - 1].resp5;

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
