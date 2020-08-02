<?php
session_start();

//recibimos los datos del formulario 
$IdDireccion = $_GET['idDirección'];
$_SESSION['idDireccionSeleccionada'] = $IdDireccion;


header("Location: carrito.php");

?>      
