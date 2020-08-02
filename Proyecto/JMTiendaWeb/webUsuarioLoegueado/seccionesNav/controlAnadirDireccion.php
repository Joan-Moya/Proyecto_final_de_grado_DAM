<?php
session_start();

//recibimos los datos del formulario 
$Calle = $_POST['calle'];
$Ciudad = $_POST['ciudad'];
$CodPostal = $_POST['codPostal'];
$NumDomicilio = $_POST['numDomicilio'];
$Poblacion = $_POST['poblacion'];
$Provincia = $_POST['provincia'];
$UsuarioId = $_SESSION['id'];


//creamos el array asociativo
$array = array(
    "Calle" => $Calle,
    "NumDomicilio" => $NumDomicilio,
    "Poblacion" => $Poblacion,
    "Ciudad"  => $Ciudad,
    "Provincia" => $Provincia,
    "CodPostal" => $CodPostal,
    "UsuarioId" => $UsuarioId
);

//convertimos el array en un objeto Json
$array_a_json = json_encode($array);

//configuramos la url para enviar posteriormente el json que hemos generado con los datos de el formulario
$ch = curl_init('http://localhost:50532/api/DireccionesEnvio');
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
curl_setopt($ch, CURLOPT_POSTFIELDS, $array_a_json);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
 'Content-Type: application/json',
 'Content-Length: ' . strlen($array_a_json))
); 
$result = curl_exec($ch);


//redireccionamos a la pagina de login
header("Location: misDirecciones.php");


?>      