<?php
session_start();

//recibimos los datos del formulario 
$numeroTarjeta = $_POST['numeroTarjeta'];
$fecha = $_POST['fecha'];
$tipo = $_POST['tipo'];
$codigo = $_POST['codigo'];
$UsuarioId = $_SESSION['id'];


//creamos el array asociativo
$array = array(
    "CodSeguridad" => $codigo,
    "FechaCaducidad" => $fecha,
    "NumTarjeta" => $numeroTarjeta,
    "Tipo"  => $tipo,
    "UsuarioId" => $UsuarioId
);

//convertimos el array en un objeto Json
$array_a_json = json_encode($array);

//configuramos la url para enviar posteriormente el json que hemos generado con los datos de el formulario
$ch = curl_init('http://localhost:50532/api/InformacionPago');
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
curl_setopt($ch, CURLOPT_POSTFIELDS, $array_a_json);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
 'Content-Type: application/json',
 'Content-Length: ' . strlen($array_a_json))
); 
$result = curl_exec($ch);


//redireccionamos a la pagina de login
header("Location: carrito.php");


?>      