$("#btnFechaNacimiento").on("click", function () {
    console.log("I'm working");
    $('.fechaNacimiento-date').datepicker({
        format: "dd/mm/yyyy",
        startDate: $("#FechaNacimiento").val(),
    });
});

