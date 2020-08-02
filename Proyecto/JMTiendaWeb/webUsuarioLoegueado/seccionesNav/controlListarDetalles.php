<?php
session_start();

//recibimos los datos del formulario 
$IdPedido = $_GET['pedidoId'];
$_SESSION['detallesPedidoRealizado'] = $IdPedido;


header("Location: detalles.php");

?>      
