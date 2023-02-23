// Call the dataTables jQuery plugin
$(document).ready(function () {

    $("#btnModalSucesso").click();
    $("#btnModalErro").click();

    if (paginaAtual == "Edit") {
        $(".radio").get().map(function (item, v) {
            $(item)[0].type = 'radio';
            $(item).removeClass("check-box");
        }
        );

        $('.invisible').map(function () {
            if (this.value == '') {
                this.value = 0;
            }
        });

        setlistaRespostas();

        if ($('.respostas').children().get().length == 5) {
            $('.fa-plus').addClass('invisible');
            $('.fa-trash').removeClass('invisible');
        }

        if ($('.respostas').children().get().length == 2) {
            $('.fa-trash').addClass('invisible');
        }
    }

    if ((paginaAtual == "Quiz") && ($('#limparRadio')[0].checked == true)) {
        limparRadioBtn();
    }

    if (paginaAtual == "Quiz") {
        setListaElementos();

        $(".radio").click(function () {
            var idPai = $(this).parent().parent()[0].id;
            var idBtnRadio = $(this)[0].id;
            listaDeElementos.map(function (item) {
                if (item[0] == idPai) {
                    item[1].map(function (i) {
                        if (!(i == "c" || i == "d" || i == "e")) {
                            $("#" + i)[0].checked = false;
                            $("#" + i).removeClass('selecionado');
                        }
                    });
                    $("#" + idBtnRadio)[0].checked = true;
                    $("#" + idBtnRadio).addClass('selecionado');
                }
            });
            
            if ($(".selecionado").length == $(".pergunta").length) {
                $("#Responder").removeClass("btn-secondary");
                $("#Responder").addClass("btn-primary");
                $("#Responder")[0].disabled = false;
            }
        });
    }
});

function limparRadioBtn() {
    $(".radio").get().map(function (item) {
        $(item)[0].checked = false;
    });
}

function setListaElementos() {
    var indexAbc = 0;
    $(".pergunta").map(function (indexPai) {
        listaDeElementos.push(new Array(this.id, ["a", "b", "c", "d", "e"]));
        $(this).children().children().get().map(function (itemFilho) {
            if (itemFilho.type == "radio") {
                listaDeElementos[indexPai][1][indexAbc] = itemFilho.id;
                indexAbc++;
            }
        });
        indexAbc = 0;
    });
}

function maisResposta() {
    var elemento = $('.respostas').children().get().length;
    if (elemento < 5) {
        $('.respostas').append(listaRespostas[elemento][0]);
        $('.fa-plus').removeClass('invisible');
    }

    if ($('.respostas').children().get().length > 2) {
        $('.fa-trash').removeClass('invisible');
        
    }

    if ($('.respostas').children().get().length == 5) {
        $('.fa-plus').addClass('invisible');
    }
}

function menosResposta() {
    var idResposta = $('.respostas').children().find(".invisible").get(-1).value;

    if (idResposta != 0) {
        $.ajax(
            {
                type: "GET",
                url: "/Resposta/Delete",
                datatype: "json",
                data: { "ID": idResposta }
            }).done(function (mensagem) {
                console.log(mensagem);
            }).fail(function (mensagemErro) {
                console.log(mensagemErro)
            });
    }

    $('.respostas').children().get(-1).remove();
    $('.fa-plus').removeClass('invisible');
    if ($('.respostas').children().get().length == 2) {
        $('.fa-trash').addClass('invisible');
    }
}

function setlistaRespostas() {
    var resposta = "";

    for (var i = 0; i < 5; i++) {
        resposta = "<div class='form-row'>" +
            "<div class='col-md-9'>" +
            "<label class='small mb-1' for='Respostas_" + i + "__Descricao'>Resposta " + (i + 1) + "</label>" +
            "<div class='form-group'>" +
            "<input class='form-control py-6 text-box single-line' data-val='true' data-val-required='Descricao da resposta obrigatorio' id='Respostas_" + i + "__Descricao' name='Respostas[" + i + "].Descricao' type='text' value=''>" +
            "<span class='field-validation-valid text-danger' data-valmsg-for='Respostas[" + i + "].Descricao' data-valmsg-replace='true'></span>" +
            "</div>" +
            "</div>" +
            "<div class='col-md-1'>" +
            "<input class='invisible text-box single-line' data-val='true' data-val-number='The field ID must be a number.' data-val-required='O campo ID é obrigatório.' id='RespostaID" + i + "' name='Respostas[" + i + "].ID' type='number' value='0'>" +
            "</div>" +
            "<div class='col-md-2'>" +
            "<label class='small mb-1'>Correto</label>" +
            "<div class='form-group'>" +
            "<input class='radio' data-val='true' data-val-required='O campo Correto e obrigatorio.' id='correto" + i + "' name='Respostas[" + i + "].Correto' type='radio' value='true' onclick='seleciona(this)'><input name='Respostas[" + i + "].Correto' type='hidden' value='false'>" +
            "</div>" +
            "</div>" +
            "</div>"

        listaRespostas.push(new Array(resposta));
    }
}

function seleciona(elemento) {
    limparRadioBtn();
    $(elemento)[0].checked = true;
}