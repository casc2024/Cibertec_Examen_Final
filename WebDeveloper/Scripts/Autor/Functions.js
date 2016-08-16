
var pageSize = 10;
function getSize(size) {
    pageSize = size;
    $('#firstPage').click();
}

var fullUrl;
function goToPage(url, page) {
    fullUrl = url + "?pagina=" + page + "&tamanio=" + pageSize;
    $.get(fullUrl, function (data) {       
        $('#ContenidoAutor').html(data);
    });
}

function reloadPartial() {
    if (fullUrl) {
        $.get(fullUrl, function (data) {
            $('#ContenidoAutor').html(data);
        });
    }
}
$(function () {
    $('#firstPage').click();
});