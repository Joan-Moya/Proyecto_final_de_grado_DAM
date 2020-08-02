<?php
$insertado = false;

//recibimos los datos del formulario de registro
$nombre_usuario = $_POST['nombre'];
$apellidos_usuario = $_POST['apellidos'];
$correo_usuario = $_POST['correo'];
$contraseña_usuario = $_POST['contraseña'];
$telefono_usuario = $_POST['telefono'];
$nacimiento_usuario = $_POST['fechaNacimiento'];

//creamos el array asociativo
$array = array(
    "Nombre" => $nombre_usuario,
    "Apellidos" => $apellidos_usuario,
    "Email" => $correo_usuario,
    "Password"  => $contraseña_usuario,
    "Telefono" => $telefono_usuario,
    "FechaNacimiento" => $nacimiento_usuario
);

//convertimos el array en un objeto Json
$array_a_json = json_encode($array);


//configuramos la url para enviar posteriormente el json que hemos generado con los datos de el formulario
$ch = curl_init('http://localhost:50532/api/Usuarios');
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
curl_setopt($ch, CURLOPT_POSTFIELDS, $array_a_json);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
 'Content-Type: application/json',
 'Content-Length: ' . strlen($array_a_json))
); 
$result = curl_exec($ch);


//redireccionamos a la pagina de login
header("Location: inicioSesion.php");


?>      