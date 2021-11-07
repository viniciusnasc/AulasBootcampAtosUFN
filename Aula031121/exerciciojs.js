function mostrarDados(){
var nome = document.getElementById("nome");
var idade = document.getElementById("idade");

if(idade.value >= 18){
alert(nome.value + " é maior de idade.");
}
else{
    alert(nome.value + " é menor de idade.");
}
}

function realizarSoma(){
    var x = parseInt(document.getElementById("num1").value);
    var y = parseInt(document.getElementById("num2").value);

    var sum = (x) + (y);

    if(sum %2 ==0){
        var botao = document.getElementById("btn");
        botao.style.background = "#F00";
    }
    else{
        var botao = document.getElementById("btn");
        botao.style.background = "#00F";
    }
    alert(x + " + " + y + " = " + sum);
}