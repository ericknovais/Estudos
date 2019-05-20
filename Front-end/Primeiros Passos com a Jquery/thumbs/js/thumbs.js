$(document).ready(function () {
    const btn_thumb = $('#thumbs');
    const contator = $('#thumbs .contador span');

    btn_thumb.on('click', onClick);

    function onClick() {
        if (btn_thumb.hasClass('disable')) {
            return;
        }

        const contagem = parseInt(contator.text());
        contator.text(contagem + 1);

        btn_thumb.addClass('disable');
    };
});