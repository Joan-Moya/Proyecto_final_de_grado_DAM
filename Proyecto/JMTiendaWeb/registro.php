<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Registro</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous">
    <link rel="stylesheet" href="css/estilosPersonales.css">
    <link rel="stylesheet" href="css/transitions.css">
    <link rel="icon" type="image/png" href="images/logo.png">
</head>

<body>

    <!-- CONTAINER DE LOGIN/REGISTER, CORREO/TLF !-->
    <div class="container-fluid p-0 fixed-top fondoNegro">
        <div class="row border-bottom">
           <nav class="nav  offset-sm-1 ">
                <a class="nav-link text-white" href="../index.php">
                    <i class="fas fa-home pl-3"></i>
                    <span class="d-none d-sm-inline p-1">Inicio</span>
                </a>
            </nav>
        </div>
    </div>
    
    <!--AQUI EMPIEZA LA IMAGEN DONDE ESTA EL LOGIN-->
    <div class="container-fluid p-0  fondoNegro">
        <div class="row pt-2">
            <div class="card col-sm-12 col-12 p-0">
                <img class="card-img img-fluid mx-auto imagen800"  alt="imagen de fondo" src="images/black.jpg"><!--IMAGEN DE FONDO-->
                <div class="card-img-overlay">
                    <h1>
                        <p class="card-text text-white text-center pt-5">Registrarme</p>
                    </h1>
                    <!-- AQUI HACEMOS EL LOGIN PARA ENTRAR A ADMINISTRADOR-->
                    <center>
                        <FORM ACTION="ControlRegistro.php" METHOD="POST" style="color:white; margin-top:5%;">
                        <div>
                            <input type="text" class="form-control col-sm-4" name="nombre" aria-describedby="emailHelp" placeholder="Pon tu nombre">
                        </div><br>
                        <div>
                            <input type="text" class="form-control col-sm-4" name="apellidos" aria-describedby="emailHelp" placeholder="Pon tus apellidos">
                        </div><br>
                        <div>
                            <input type="email" class="form-control col-sm-4" name="correo" aria-describedby="emailHelp" placeholder="Pon tu correo (obligatorio)">
                        </div><br>
                        <div>
                            <input type="password" class="form-control col-sm-4" name="contraseña" aria-describedby="emailHelp" placeholder="Pon tu contraseña (obligatorio)">
                        </div><br>
                        <div>
                            <input type="text" class="form-control col-sm-4" name="telefono" aria-describedby="emailHelp" placeholder="Pon tu telefono">
                        </div><br>
                        <div>
                            <input type="date" class="form-control col-sm-4" name="fechaNacimiento" aria-describedby="emailHelp" placeholder="Pon tu fecha de nacimiento">
                        </div><br>
                           <a href="inicioSesion.php"> <input type="submit" value="Registrarme" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:#28A645; color:white;"></a><br>
                            <a href="inicioSesion.php"><span class='hatch' style='color:green;'>También puedes iniciar sesión</span></a><br>
                        </FORM>
                    </center>
                        
                    <!--AQUI MOSTRAMOS MENSAJE DE ERROR EN EL CASO DE QUE NO SE HAYAN PUESTO BIEN LOS DATOS-->
                    <?php
                     if(isset($_GET['errorusuario'])){
                            echo "
                            <center>
                                <span> 
                                    <span class='hatch' style='color:red;'>No se ha podido registrar el usuario</span><br>
                                    <img src='images/error.png' style='width:50px; height:50px;'>
                                </span> 
                            </center>";
                        }else{
                            
                        }
                    ?>
                </div>
            </div>
        </div>
     </div>
    

     <!--AQUI COMIENZA EL FOOTER -->
     <?php include("footer.php");?>


    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
    <script>
    $(function(){
        $('[data-toggle="tooltip"]').tooltip();
    });
    </script>

</body>
</html>
