$(document).ready(function () {

    $('body').on('click', '.ajax-link', function () {
        var url = $(this).data('url');
        $.get(url, function (data) {

            $('.content').html(data);
        });
    });

    $('body').on('click', '.ajax-sublink', function () {
        var url = $(this).data('url');
        $.get(url, function (data) {

            $('.active').html(data);
        });
    });
});