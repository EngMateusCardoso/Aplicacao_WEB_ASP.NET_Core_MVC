function exibir_estes(tipo){
    let Destinos = document.getElementsByClassName('col-md');
    if ( tipo == 'Todos'){
        for (var i = 0; i < Destinos.length; i++){
            Destinos[i].style = "display: block;"

        }
    }else{
        for (var i = 0; i < Destinos.length; i++){
            if ( tipo == Destinos[i].id)
                Destinos[i].style = "display: block;"
            else
                Destinos[i].style = "display: none;"
        }
    }
}

function editarmodal(nome) {
    let destinotitulo = document.getElementById('DestinoTitulo');
    destinotitulo.innerHTML = nome;
    let destinoinput = document.getElementById('DestinoInput');
    destinoinput.innerHTML = nome;
}

function alerta() {
    alert('Sua mensagem foi enviada!');
}