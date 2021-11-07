// Exercicio 1:
function planoFundoAzul(){
    document.body.style = "background: blue;";
}
function planoFundoVerde(){
    document.body.style = "background: green;";
}
function planoFundoVermelho(){
    document.body.style = "background: red;";
}
function planoFundoAmarelo(){
    document.body.style = "background: yellow;";
}

// Exercicio 2:
function planoFundoDefault(){
    document.body.style = "background: default;";
}

// Exercicio 4:
function mostrarTexto(){
    let texto = document.getElementById("hiddenText");
    texto.hidden = !texto.hidden;
}