<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Insertar pago</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous">
    <link rel="stylesheet" href="css/estilosPersonales.css">
    <link rel="stylesheet" href="css/transitions.css">
    <link rel="icon" type="image/png" href="images/logo.png">
</head>

<body>

    <!--AQUI COMIENZA EL NAV SUPERIOR -->
    <?php include("nav.php");?>
    
    <!--AQUI EMPIEZA LA IMAGEN DONDE ESTA EL LOGIN-->
    <div class="container-fluid p-0  fondoNegro">
        <div class="row pt-2">
            <div class="card col-sm-12 col-12 p-0">
                <img class="card-img img-fluid mx-auto imagen800"  alt="imagen de fondo" src="images/white.jpg">
                <div class="card-img-overlay">
                    <h1>
                        <p class="card-text text-center pt-5"><b>Añadir método de pago</b></p>
                    </h1>
                    <center>
                        <div class="col-md-6 col-12">
                            <img src="images/metodosDePago.png" style="width:70%">
                        </div>
                    </center>
                    <!-- AQUI HACEMOS EL LOGIN PARA ENTRAR A ADMINISTRADOR CON EL FORMUMARIO FUNCIONANDO-->
                    <center>
                        <FORM ACTION="controlAnadirPago.php" METHOD="POST" style="color:white;">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="numeroTarjeta"  placeholder="Número de tarjeta">
                            </div><br>
                            <div>
                                <p style="color:black">Fecha de caducidad:</p>
                                <input type="date" class="form-control col-sm-4" name="fecha"  placeholder="Pon la fecha">
                            </div><br>
                            <div>
                                <input type="text" class="form-control col-sm-4" name="tipo"  placeholder="Tipo: visa, mastercard...">
                            </div><br>
                            <div>
                                <input type="text" class="form-control col-sm-4" name="codigo"  placeholder="Código de seguridad">
                            </div>
                            
                            <input type="submit" value="Añadir método de pago" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:#28A645; color:white;">
                        </FORM>
                    </center>

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
