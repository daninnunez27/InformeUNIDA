document.getElementById('btn_procesar').style.visibility = 'hidden';

function ExportarExcel() {
    mensaje = validar()

    if (mensaje != "") {
        //alert(mensaje);
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: mensaje
        })       
        return false;
    }
    valor = $('input:radio[name=reporte]:checked').val();

    //  1   alumno_docente_grafico
    //  2   alumno_docente_resumen
    //  3   Alumno_biblioteca_grafico
    //  4   Alumno_sga_grafico
    //  5   Alumno_coordinador_resumen
    //  6   Alumno_cafeteria_grafico
    //  7   Alumno_infraestructura_grafico
    //  8   Alumno_libreria_grafico
    //  9   Alumno_laboratorio_grafico
    //  10  Docente_Autoevaluacion_grafico
    //  12  Docente_cafeteria_grafico
    //  11  Docente_biblioteca_grafico
    //  13  Docente_infraestructura_grafico
    //  14  Docente_laboratorio_grafico
    //  15  Docente_libreria_grafico
    //  16  Docente_sgp_grafico
    //  17  Docente_alumno_grafico
    //  18  Docente_coordinador_resumen
    //  19  funcionario_autoevaluacion_del_desempenio_grafico
    //  20  funcionario_autoevaluacion_del_desempenio_resumen
    //  21 coordinador_autoevaluacion_resumen
    //  22 coordinador_docente_resumen
    //  23 alumno_satisfaccion_grafico
    //  24 docente_satisfaccion_grafico
    //  25 docente_satisfaccion_resumen
    //  26 decano_coordinador_resumen
    //  27 docente_satisfaccion_grafico2
    //  28 docente_satisfaccion_resumen2

    $("#cinstitucion_p").val($("#Institucion").val());
    $("#cprograma_p").val($("#Programa").val());
    $("#cperiodo_p").val($("#Periodo").val());
    $("#ccarrera_p").val($("#Carrera").val());
    $("#cprofesor_p").val($("#Profesor").val());
    $("#opcion_p").val(valor);

    var frmReporte = document.getElementById("frmReporte");
    frmReporte.submit();
}

function validar() {
    if ($("#Institucion").val() == 0 || $("#Institucion").val() == "null" || $("#Institucion").val() == null || $("#Institucion").val() == "-3") {
        return "Tiene que seleccionar una Institución.";
    }

    if ($("#Programa").val() == 0 || $("#Programa").val() == "null" || $("#Programa").val() == null) {
        return "Tiene que seleccionar un Programa.";
    }

    if ($("#Periodo").val() == 0 || $("#Periodo").val() == "null" || $("#Periodo").val() == null) {
        return "Tiene que seleccionar un Periodo.";
    }

    if ($("#Carrera").val() == "null" || $("#Carrera").val() == null || $("#Carrera").val() == -3) {
        return "Tiene que seleccionar una Carrera.";
    }

    if ($("#Profesor").val() == "null" || $("#Profesor").val() == null || $("#Profesor").val() == -3) {
        return "Tiene que seleccionar un Profesor.";
    }
    return "";
}

$('#btn_reporte_pdf').click(function () {

    mensaje = validar();
    if (mensaje != "") {
        //alert(mensaje);
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: mensaje
        });
        return false;
    }

    valor = $('input:radio[name=reporte]:checked').val();
    urlEncuesta = "";

    //alert(valor);

    switch (valor) {
        case "1":
            //urlEncuesta = '@Url.Action("ReporteEncuestaAlumnoDocenteGrafico")';
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoDocenteGrafico';
            break;
        case "2":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoDocenteResumen';
            break;
        case "3":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoBibliotecaGrafico';
            break;
        case "4":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoSgaGrafico';
            break;
        case "5":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoCoordinadorResumen';
            break;
        case "6":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoCafeteriaGrafico';
            break;
        case "7":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoInfraestructuraGrafico';
            break;
        case "8":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoLibreriaGrafico';
            break;
        case "9":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoLaboratorioGrafico';
            break;
        case "10":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteAutoevaluacionGrafico';
            break;
        case "11":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteBibliotecaGrafico';
            break;
        case "12":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteCafeteriaGrafico';
            break;
        case "13":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteInfraestructuraGrafico';
            break;
        case "14":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteLaboratorioGrafico';
            break;
        case "15":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteLibreriaGrafico';
            break;
        case "16":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteSgpGrafico';
            break;
        case "17":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteAlumnoGrafico';
            break;
        case "18":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteCoordinadorResumen';
            break;
        case "19":
            urlEncuesta = 'Encuesta/ReporteEncuestaFuncionarioAutoevaluacionGrafico';
            break;
        case "20":
            urlEncuesta = 'Encuesta/ReporteEncuestaEgresadoRetroalimentacionResumen';
            break;
        case "21":
            urlEncuesta = 'Encuesta/ReporteEncuestaCoordinadorAutoevaluacionGrafico';
            break;
        case "22":
            urlEncuesta = 'Encuesta/ReporteEncuestaCoordinadorDocenteGrafico';
            break;
        case "23":
            urlEncuesta = 'Encuesta/ReporteEncuestaAlumnoSatisfaccionGrafico';
            break;
        case "24":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteSatisfaccionGrafico';
            break;
        case "25":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteSatisfaccionResumen';
            break;
        case "26":
            urlEncuesta = 'Encuesta/ReporteEncuestaDecanoCoordinadorResumen';
            break;
        case "27":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteSatisfaccionGrafico2';
            break;
        case "28":
            urlEncuesta = 'Encuesta/ReporteEncuestaDocenteSatisfaccionResumen2';
            break;
        default:
        // code block
    }

    //$("#btn_reporte_pdf").attr("disabled", true);
    document.getElementById('btn_procesar').style.visibility = 'visible';
   
    $.ajax({
        type: 'POST',

        url: urlEncuesta,

        data: { cinstitucion: $("#Institucion").val(), cprograma: $("#Programa").val(), cperiodo: $("#Periodo").val(), ccarrera: $("#Carrera").val(), cprofesor: $("#Profesor").val() },

        success: function(nombreArchivo) {

            cadena = "reporte/" + nombreArchivo;

            $("#DisplayPDF").html(
                $('<iframe>', {
                    src: cadena,
                    width: '100%',
                    height: "1500px"
                })
            );

            //$("#btn_reporte_pdf").attr("disabled", false);
            document.getElementById('btn_procesar').style.visibility = 'hidden';
        },
        error: function(ex) {
            //alert('Error al recuperar el reporte. ' + ex.text);
            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Error al recuperar el reporte. ' + ex.text
            });
            //$("#btn_reporte_pdf").attr("disabled", true);
            document.getElementById('btn_procesar').style.visibility = 'hidden';
        }
    });
    return false;
})

$('input[type=radio][name=reporte]').change(function () {
    $("#Institucion option[value=-3]").attr("selected", true);

    //if (this.value == '2') {
    //    alert("2");
    //}
    //if (this.value == '3') {
    //    alert("3");
    //}
});

$("#Institucion").change(function () {
    $("#Programa").empty();
    $("#Periodo").empty();
    $("#Carrera").empty();
    $("#Profesor").empty();
    $("#DisplayPDF").empty();

    $("#Institucion option[value=-3]").attr("selected", false);  

    $.ajax({
        type: 'GET',

        //url: '@Url.Action("ObtenerListarPrograma")',
        url: 'Encuesta/ObtenerListarPrograma',

        data: { cinstitucion: $("#Institucion").val(), valor: $('input:radio[name=reporte]:checked').val(), cusuario: $("#cusuario").val() },

        success: function(programas) {

            $.each(programas, function(i, programa) {

                $("#Programa").append('<option value="' + programa.value + '">' +
                    programa.text + '</option>');

            });
        },
        error: function(ex) {
            alert('Error al actualizar los programas de la institucion.' + ex.text);
        }
    });
    return false;
})
  
$("#Programa").change(function () {
    $("#Periodo").empty();
    $("#Carrera").empty();
    $("#Profesor").empty();
    $("#DisplayPDF").empty();

    $.ajax({
        type: 'GET',

        //url: '@Url.Action("ObtenerListarPeriodo")',
        url: 'Encuesta/ObtenerListarPeriodo',

        data: { cinstitucion: $("#Institucion").val(), cprograma: $("#Programa").val(), valor: $('input:radio[name=reporte]:checked').val() },

        success: function(periodos) {

            $.each(periodos, function(i, periodo) {

                $("#Periodo").append('<option value="' + periodo.value + '">' +
                    periodo.text + '</option>');

            });
        },
        error: function(ex) {
            alert('Error al actualizar los periodos del programa.' + ex.text);
        }
    });
    return false;
})
  
$("#Periodo").change(function () {
    $("#Carrera").empty();
    $("#Profesor").empty();
    $("#DisplayPDF").empty();

    $.ajax({
    type: 'GET',

    url: 'Encuesta/ObtenerListarCarrera',

        data: { cinstitucion: $("#Institucion").val(), cprograma: $("#Programa").val(), cperiodo: $("#Periodo").val(), valor: $('input:radio[name=reporte]:checked').val() },

    success: function(carreras) {

        $.each(carreras, function(i, carrera) {

            $("#Carrera").append('<option value="' + carrera.value + '">' +
                carrera.text + '</option>');

        });
    },
    error: function(ex) {
        alert('Error al actualizar las carreras del periodo.' + ex.text);
    }
    });
    return false;
})
 
$("#Carrera").change(function () {
    $("#Profesor").empty();
    $("#DisplayPDF").empty();

    $.ajax({
        type: 'GET',

        url: 'Encuesta/ObtenerListarProfesor',

        data: { cinstitucion: $("#Institucion").val(), cprograma: $("#Programa").val(), cperiodo: $("#Periodo").val(), ccarrera: $("#Carrera").val(), valor: $('input:radio[name=reporte]:checked').val() },

        success: function(profesores) {

            $.each(profesores, function(i, profesor) {

                $("#Profesor").append('<option value="' + profesor.value + '">' +
                    profesor.text + '</option>');

            });
        },
        error: function(ex) {
            alert('Error al actualizar los docentes de la carrera.' + ex.text);
        }
    });
    return false;
})