// Funcion para cuando cambie el valor del combobox del inicio
function FiltroCampos() {
    Limpiar();
    var opcion = document.getElementById('cbOps').value; //Valor combobox

    // Esconde todos los inputs con sus labels
    document.getElementById('lbIdAutor').style.display = 'none';
    document.getElementById('id_autor').style.display = 'none';
    document.getElementById('lbNombre').style.display = 'none';
    document.getElementById('nombre').style.display = 'none';
    document.getElementById('lbApellido').style.display = 'none';
    document.getElementById('apellido').style.display = 'none';
    document.getElementById('lbGenero').style.display = 'none';
    document.getElementById('genero').style.display = 'none';
    document.getElementById('lbPhone').style.display = 'none';
    document.getElementById('telefono').style.display = 'none';

    // Para saber que opcion este seleccionada
    switch (opcion) {
        case "id": // Se hace visible los inputs/labels de ID
            document.getElementById('lbIdAutor').style.display = 'inline';
            document.getElementById('id_autor').style.display = 'inline';
            break;
        case "nombre": // Se hace visible los inputs/labels de nombre, apellidoy genero
            document.getElementById('lbNombre').style.display = 'inline';
            document.getElementById('nombre').style.display = 'inline';
            document.getElementById('lbApellido').style.display = 'inline';
            document.getElementById('apellido').style.display = 'inline';
            document.getElementById('lbGenero').style.display = 'inline';
            document.getElementById('genero').style.display = 'inline';
            break;
        case "telefono": // Se hace visible los inputs/labels de telefono
            document.getElementById('lbPhone').style.display = 'inline';
            document.getElementById('telefono').style.display = 'inline';
            break;
            
    }

}

// Limpiar los inputs del inicio
function Limpiar() {
    document.getElementById('id_autor').value = '';
    document.getElementById('nombre').value = '';
    document.getElementById('apellido').value = '';
    document.getElementById('genero').value = '';
    document.getElementById('telefono').value = '';
}