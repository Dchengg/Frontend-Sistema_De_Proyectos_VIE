
$("#btnFechaNacimiento").on("click",
    function () {
        //$('.datepicker').datepicker();
        console.log("I'm working");
        $('#fecha-nacimiento .input-group.date').datepicker({
            format: "dd/mm/yyyy",
            todayHighlight: false,
            defaultViewDate: $("#campoFechaNacimiento").val()
        });
        
    }
);

