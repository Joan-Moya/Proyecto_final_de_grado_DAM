<?php
session_start();

//recibimos los datos del formulario 
$Id = $_GET['pedidoId2'];

//configuramos la url para enviar posteriormente el json que hemos generado con los datos de el formulario
$ch = curl_init('http://localhost:50532/api/Pedidos?idPedido='.$Id);
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "DELETE");
curl_setopt($ch, CURLOPT_POSTFIELDS, $array_a_json);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
$result = curl_exec($ch);


//redireccionamos a la pagina de login
header("Location: misPedidos.php");


?>      