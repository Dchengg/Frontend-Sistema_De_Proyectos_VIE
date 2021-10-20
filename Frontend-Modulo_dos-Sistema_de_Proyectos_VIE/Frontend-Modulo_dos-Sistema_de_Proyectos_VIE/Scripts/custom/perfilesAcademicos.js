
$("#btnEditarPerfilAcademico").on("click", function () {
    var row = $("this").parent();
    console.log(row);
    var tipoPerfilSeleccionado = row.find("td:first").val();
    console.log(tipoPerfilSeleccionado);
    $("#textboxTipoPerfilAcademico").val(tipoPerfilSeleccionado);
});
