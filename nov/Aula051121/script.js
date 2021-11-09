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

// Exercicio 5:
function habilitarCheckbox(){
    var c1 = document.getElementsByName("check"); // Cria uma lista de elementos
    var numElementos = c1.length; 

    for(let i = 0; i < numElementos; i++)
    {
        c1[i].onclick = function(){
            var count = document.querySelectorAll("input[name='check']:checked").length;
            if(count >= 2){
                document.getElementById("check3").removeAttribute("disabled");
            }
            else{
                document.getElementById("check3").setAttribute("disabled", "disabled");
                document.getElementById("check3").checked = false;
            }
        }
    }
}

// Exercicio 6:
function alterarCorFonteBranco(){
    document.getElementById("paragrafo").style.color = "white";
}

function alterarCorFontePreto(){
    document.getElementById("paragrafo").style.color = "black";
}

function alterarCorFundoPreto(){
    document.getElementById("paragrafo").style.backgroundColor = "black";
}

function alterarCorFundoBranco(){
    document.getElementById("paragrafo").style.backgroundColor = "white";
}

// Exercicio 7
var tamanho = 16;

function aumentarTamLetra(){
    tamanho++;
    document.getElementById("paragrafo").style.fontSize = tamanho + "px";
}

function diminuirTamLetra(){
    tamanho--;
    document.getElementById("paragrafo").style.fontSize = tamanho + "px";
}

// Exercicio 8
function deixarMaiuscula(){
    var element = document.getElementById("paragrafo");
    element.style.textTransform = "uppercase";
}

function deixarMinuscula(){
    var element = document.getElementById("paragrafo");
    element.style.textTransform = "lowercase";
}