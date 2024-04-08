$(document).ready(fuction(), {
    //Peticion API con AJAX
    //Aqui colocamos los datos a probar
    $, : .ajax({
        type: "GET",
        contentType: "application/json; charset utf-8",
        dataType: "json",
        url: "",
        error: fuction()
    }, {
        alert();
    },
        success, fuction(data), {
        console, : .log(data),
        GraficoPastel(data);
    })
});
