<?php
session_start();
$email = $_POST['email'];
$contraseña = $_POST['contraseña'];

$comprobarLogin = false;
$comprobarLogin = file_get_contents("http://localhost:50532/api/Usuarios?email=".$email."&pass=".$contraseña." ");
$recuperarUserId = file_get_contents("http://localhost:50532/api/Usuarios?email=".$email."");


    if($comprobarLogin == "false"){
        header("Location: inicioSesion.php?errorusuario=si");

    }else{
       
       $_SESSION['id'] = $recuperarUserId ;
       header("Location: webUsuarioLoegueado/index.php");

    }

?>      

        
   



       
