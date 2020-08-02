<?php
session_start();

//recibimos los datos del formulario 
$IdPago = $_GET['idPago'];
$_SESSION['idPagoSeleccionado'] = $IdPago;


header("Location: carrito.php");

?>      
