<?php
session_start();

//recibimos los datos del formulario 
$IdProducto = $_GET['idProducto'];
$UsuarioId = $_SESSION['id'];

//creamos el array asociativo
$array = array(
    "Default" => "Default"
);

//convertimos el array en un objeto Json
$array_a_json = json_encode($array);

//configuramos la url para enviar posteriormente el json que hemos generado con los datos de el formulario
$ch = curl_init('http://localhost:50532/api/ProductosPedidos?idProd='.$IdProducto.'&idUser='.$UsuarioId.'');
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
curl_setopt($ch, CURLOPT_POSTFIELDS, $array_a_json);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
 'Content-Type: application/json',
 'Content-Length: ' . strlen($array_a_json))
); 
$result = curl_exec($ch);

//redireccionamos a la pagina de login
header("Location: ../seccionesNav/carrito.php");

?>      
