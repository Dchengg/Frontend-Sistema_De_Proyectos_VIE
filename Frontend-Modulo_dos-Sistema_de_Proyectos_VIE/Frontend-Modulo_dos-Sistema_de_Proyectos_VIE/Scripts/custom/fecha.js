
function getDateObject(dateString) {
    const arreglo = dateString.split("/");
    const date = {
        year: arreglo[2] + "",
        month: arreglo[1] + "",
        day: arreglo[0] + ""
    }
    return date
}

$("#btnFechaNacimiento").on("click",
    function () {
        var date = getDateObject($("#campoFechaNacimiento").val().split(" ")[0])

        $('#fecha-nacimiento .input-group.date').datepicker({
            useCurrent: false,
            todayHighlight: false,
            format: "dd/mm/yyyy",
            defaultViewDate: {
                year: date.year,
                month: date.month,
                day: date.day
            },
        });
    }
);

