
function actualizaDrawZone() {
    $(".popover").remove();
    $.getJSON('/api/sala_data.aspx', { id: espValues.idEspectaculo, hora: $('#Content1_DropDownHorarios').val(), fecha: $('#Content1_DropDownFechas').val() }, function (data) {
        $("#drawZone").empty();
        for (i in data.secciones) {
            var fil = data.secciones[i].filas;
            var col = data.secciones[i].columnas;
            dibujar(fil, col);
        }


        for (i in data.ventas) {
            var datosPosVenta = data.ventas[i].split('-');
            var seccion = datosPosVenta[0] - 1;
            var fila = datosPosVenta[1] - 1;
            var asiento = datosPosVenta[2] - 1;
            $(".seccionBox:eq(" + seccion + ") .fila:eq(" + fila + ") .asiento:eq(" + asiento + ")").addClass('sold');
        }
        console.log(data);
        muestraReservasUsuario(data.preventas);
    });
};

actualizaDrawZone();
$('#Content1_DropDownHorarios, #Content1_DropDownFechas').on('change', actualizaDrawZone);

function dibujar(filas, colum) {
    var seccion = $("<div></div>", {
        class: "seccionBox"
    }).appendTo("#drawZone");

    for (var j = 0; j < filas; j++) {
        var fila = $("<div></div>", {
            class: "fila"
        }).appendTo(seccion);

        for (var k = 0; k < colum; k++) {
            var asiento = $("<div></div>", {
                class: "asiento",
                text: ""
            }).appendTo(fila);
        }
    }
}

// Evento click en asiento
$('.asiento').live('click', function (event) {
    $(".popover").remove();
    $(".asiento.selected").removeClass('selected');
    var posAsiento = "";
    posAsiento = $(this).parents(".seccionBox").index() + 1 + ":";
    posAsiento += $(this).parent(".fila").index() + 1 + ":";
    posAsiento += $(this).index() + 1;

    var contentPopover = '';
    if ($(this).hasClass('reserved')) {
        contentPopover = 'Ya la has seleccionado este asiento.';
    }
    else if ($(this).hasClass('sold')) {
        contentPopover = 'Lo siento, esta entrada está vendida.';
    }
    else {
        $(this).addClass("selected");
        contentPopover = '<a href="#" id="addVenta" class="btn btn-info"><i class="icon-plus icon-white"></i> Añadir a la compra</a>';
    }

    $(this).data('popover', null).popover({
        placement: 'right',

        trigger: 'manual',
        title: 'Asiento ' + posAsiento + '<span class="close closePopoverVenta"  data-dismiss="popover">×</span>',
        content: contentPopover
    });
    $(this).popover('show');
});

// Click en boton de compra
document.getElementById("btnComprar").onclick = function (e) {
    $("#especCompra").slideDown();
    this.style.display = "none";
    e.preventDefault();
};

// Click en boton cerrar zona de compra
$("#btnComprarClose").on('click', function () {
    // Quitamos cualquier popover que estuviese abierto
    $(".popover").remove();
    $("#especCompra").css('display', 'none');
    $("#btnComprar").fadeIn('slow');
});

// Click en boton cerrar popover
$("#btnComprarClose").on('click', function () {
    // Quitamos cualquier popover que estuviese abierto
    $(".popover").remove();
    $("#especCompra").css('display', 'none');
    $("#btnComprar").fadeIn('slow');
});


$(".starRate").on('click', function (e) {
    var valIndex = $(this).index();
    $('#ratingControler').css("width", (valIndex * 25) + "px");
    e.preventDefault();
    $.get('/api/esp_vote.aspx', { nota: valIndex, esp: espValues.idEspectaculo }, function (data) {
    });
});

$("#addVenta").live('click', function (e) {

    var posAsiento = "";
    posAsiento = $(".asiento.selected").parents(".seccionBox").index() + 1 + "-";
    posAsiento += $(".asiento.selected").parent(".fila").index() + 1 + "-";
    posAsiento += $(".asiento.selected").index() + 1;

    $.getJSON('/api/admin_venta.aspx', { accion: "add", asiento: posAsiento, esp: espValues.idEspectaculo, hora: $('#Content1_DropDownHorarios').val(), fecha: $('#Content1_DropDownFechas').val() }, function (data) {
        console.log(data);
        if (data.result == "ok") {
            $(".asiento.selected").addClass('reserved');
        }
        else if (data.result == "ocupada") {
            $(".asiento.selected").addClass('sold');
            alert("Este asiento ha sido vendido");
        }
        $(".asiento.selected").removeClass('selected');
        $(".popover").remove();

        muestraReservasUsuario(data.ventas);
    });
    e.preventDefault();
});

var b;

$(".closePopoverVenta").live('click', function (e) {
    $(".popover").remove();
    $(".asiento.selected").removeClass('selected');
    e.preventDefault();
});

$(".buttonReservaLista").live('click', function (e) {
    console.log($(this).data('asiento'));
    console.log($(this).data('precio'));
    console.log($(this).data('hora'));
    console.log($(this).data('fecha'));

    var button = $(this);



    $.getJSON('/api/admin_venta.aspx', { accion: "remove", asiento: button.data('asiento'), esp: espValues.idEspectaculo, hora: button.data('hora'), fecha: button.data('fecha') }, function (data) {
        console.log(data);
        if (data.result == "eliminada") {
            
            var datosPosVenta = button.data('asiento').split('-');
            var seccion = datosPosVenta[0] - 1;
            var fila = datosPosVenta[1] - 1;
            var asiento = datosPosVenta[2] - 1;
            $(".seccionBox:eq(" + seccion + ") .fila:eq(" + fila + ") .asiento:eq(" + asiento + ")").removeClass('reserved').css('backgroundColor', '');
            button.remove();
        }
        else if (data.result == "noeliminada") {
            alert("No se encontró el asiento");
        }
        $(".tooltip").remove();
        muestraReservasUsuario(data.ventas);

    });
    e.preventDefault();
});


$(".buttonReservaLista").live('mouseenter', function (e) {

    var button = $(this);
    $(this).data('tooltip', null).tooltip({
        trigger: 'manual',
        title: "Asiento: " + button.data('asiento') + "<br/>Dia: " + button.data('fecha') + " | Hora: " + button.data('hora')
    });
    $(this).tooltip("show");

    if (button.data('fecha')==$('#Content1_DropDownFechas').val() && button.data('hora')==$('#Content1_DropDownHorarios').val())
    {
        var datosPosVenta = $(this).data('asiento').split('-');
        var seccion = datosPosVenta[0] - 1;
        var fila = datosPosVenta[1] - 1;
        var asiento = datosPosVenta[2] - 1;
        $(".seccionBox:eq(" + seccion + ") .fila:eq(" + fila + ") .asiento:eq(" + asiento + ")").css('backgroundColor', 'orange');
    }

});

$(".buttonReservaLista").live('mouseleave', function (e) {
    var datosPosVenta = $(this).data('asiento').split('-');
    var seccion = datosPosVenta[0] - 1;
    var fila = datosPosVenta[1] - 1;
    var asiento = datosPosVenta[2] - 1;
    $(".seccionBox:eq(" + seccion + ") .fila:eq(" + fila + ") .asiento:eq(" + asiento + ")").css('backgroundColor', '');
    $(".tooltip").remove();
});

function muestraReservasUsuario(ventas) {
    $("#listaReservas").empty();
    var sumaImporte = 0;
    for (i in ventas) {

        if (ventas[i].espectaculo == espValues.idEspectaculo)
        {
            $("<button>").
                    html(ventas[i].asiento + ' (' + ventas[i].fecha + ' ' + ventas[i].hora + ') <i class="icon-remove icon-white"></i>').
                    addClass('btn btn-mini btn-warning buttonReservaLista').
                    data({
                        asiento: ventas[i].asiento,
                        precio: ventas[i].precio,
                        hora: ventas[i].hora,
                        fecha: ventas[i].fecha
                    }).appendTo("#listaReservas");
            sumaImporte += parseInt(ventas[i].precio);

            if (ventas[i].fecha == $('#Content1_DropDownFechas').val() && ventas[i].hora == $('#Content1_DropDownHorarios').val()) {
                var datosPosVenta = ventas[i].asiento.split('-');
                var seccion = datosPosVenta[0] - 1;
                var fila = datosPosVenta[1] - 1;
                var asiento = datosPosVenta[2] - 1;
                $(".seccionBox:eq(" + seccion + ") .fila:eq(" + fila + ") .asiento:eq(" + asiento + ")").addClass('reserved');
            }
        }
    }
    $("#importeCompra").html(sumaImporte);
    $('#contReservas').html(ventas.length);
}