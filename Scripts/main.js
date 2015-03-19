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
    $('body').on('submit', '.ajax-sublink', function (event) {

        event.preventDefault();

        $.post($(this).data('posturl'), $(this).serialize(), function (data) {
            $('.contact-content').html(data);
        });
    });

});
