<?php
session_start();
$idDireccionSeleccionada= $_SESSION['idDireccionSeleccionada'];
$idPagoSelec= $_SESSION['idPagoSeleccionado'];

//recibimos los datos del formulario 
$notaEntrega = $_GET['notaEntrega'];
$PedidoId = $_GET['PedidoId'];

//creamos el array asociativo
$array = array(
    "Default" => "Default"
);

//convertimos el array en un objeto Json
$array_a_json = json_encode($array);

//configuramos la url para enviar posteriormente el json que hemos generado con los datos de el formulario
$ch = curl_init('http://localhost:50532/api/Transacciones?idPedido='.$PedidoId.'&idDirEnvio='.$idDireccionSeleccionada.'&idInfoPago='.$idPagoSelec.'&notasEntrega='.$notaEntrega.'');
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
curl_setopt($ch, CURLOPT_POSTFIELDS, $array_a_json);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
 'Content-Type: application/json',
 'Content-Length: ' . strlen($array_a_json))
); 
$result = curl_exec($ch);

//redireccionamos a la pagina de login
header("Location: ../graciasCompra.php");

?>      
