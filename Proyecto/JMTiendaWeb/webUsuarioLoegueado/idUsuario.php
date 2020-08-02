<?php
$idUsuario = $_GET['idUsuario'];

        session_start();
        $_SESSION['id'] = $idUsuario;
        

header("Location: index.php");

?>      