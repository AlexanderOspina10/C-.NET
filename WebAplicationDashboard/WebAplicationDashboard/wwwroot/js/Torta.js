

   $(document).ready(function(){
    //Peticion API con AJAX
    //Aqui colocamos los datos a probar
    $.ajax({
        type: "GET",
        contentType: "application/json; charset utf-8",
        dataType: "json",
        url: urlBase + '/DataTorta',
        error: function(){
        alert("Error al consultar los datos :");
    },
        success: function(data){
            console.log(data);
            GraficoPastel(data);
        }
    })
});
//Construccion del grafico

function GraficoPastel(data){ 
    Highcharts.chart('torta', {
        chart: {
        plotBackgroundColor: null,
    plotBorderWidth: null,
    plotShadow: false,
    type: 'pie'
            },
    title: {
        text: 'Frameworks, 2022',
    align: 'left'
            },
    tooltip: {
        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
            },
    accessibility: {
        point: {
        valueSuffix: '%'
                }
            },
    plotOptions: {
        pie: {
        allowPointSelect: true,
    cursor: 'pointer',
    dataLabels: {
        enabled: false
                    },
    showInLegend: true
                }
            },
    series: [{
        name: 'Brands',
    colorByPoint: true,
    data: data }]
        });
}