$(document).ready(function () {
    const contador = $('#quantidade .contador span');

    /* Incremento do contador */

    const btn_quantidade_mais = $('#quantidade-mais');

    btn_quantidade_mais.on('click', funcao_incrementa);

    /* Decremento do contador */

    const btn_quantidade_menos = $('#quantidade-menos');

    btn_quantidade_menos.on('click', funcao_decrementa);


    /* Funções de incremento e decremento */

    function funcao_incrementa() {
        var contagem = parseInt(contador.text());

        contador.text(contagem + 1);
    };

    function funcao_decrementa() {
        var contagem = parseInt(contador.text());

        if (contagem <= 0) {
            return;
        }

        contador.text(contagem - 1);
    };
});