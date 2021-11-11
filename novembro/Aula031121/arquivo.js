function minhafuncao(){
    alert("Hello!");
}

function mostrarSomatorio(){
    var count = 0;
    for(let i = 1; i <= 100; i++){
    count += i;
    }
    alert(count);
}

function mostrarPares(){
    for(var i = 1; i <= 10; i++)
    {
        if(i % 2 == 0)
        alert(i);
    }
}

function deixarCaixaAlta(){
    var x = document.getElementById("nome");
    x.value = x.value.toUpperCase();
}