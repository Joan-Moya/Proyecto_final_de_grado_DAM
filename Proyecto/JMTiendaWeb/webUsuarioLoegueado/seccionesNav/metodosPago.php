<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Métodos de pago</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous">
    <link rel="stylesheet" href="css/transitions.css">
    <link rel="stylesheet" href="css/estilosPersonales.css">
    <link rel="icon" type="image/png" href="images/logo.png">
</head>

<body>
   
    <!--AQUI COMIENZA EL NAV SUPERIOR -->
    <?php include("nav.php");?>
    
    <p class="text-center pt-5 pb-5"><h1 class="text-center pt-5 pb-5" style="font-size:60px"><b>Mis formas de pago</b></h1></p>

    <!-- BARRA QUE NOS DICE DONDE ESTAMOS -->
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="../index.php" class="text-dark">Inicio</a></li>
            <li class="breadcrumb-item"><a href="../tienda.php" class="text-dark">Tienda</a></li>
            <li class="breadcrumb-item"><a href="#" class="text-dark">Métodos de pago</a></li>
        </ol>
    </nav>
        
    <!-- AQUI EMPIEZAN LAS IMAGENES DE Las tarjetas-->
    <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            include("../conexion.php"); //--Conexión
            
            $resultados = file_get_contents("http://localhost:50532/api/InformacionPago?userId=".$_SESSION['id']."");
            $json = json_decode($resultados, true);

            foreach($json as $value){
                $CodSeguridad = $value['CodSeguridad'];
                $FechaCaducidad = $value['FechaCaducidad'];
                $NumTarjeta = $value['NumTarjeta'];
                $Tipo = $value['Tipo'];
                $UsuarioId = $value['UsuarioId'];
                $InformacionPagoId = $value['InformacionPagoId'];
            
        ?>
        <!--PRODUCTO -->
        <div class="col-sm-6 col-md-4 col-12 border shadow p-3 mb-5 bg-white rounded m-2 hatch">
            <div class="thumbnail">
                <img src="images/tarjetaImagen.jpg" class="p-3 img-fluid" style="height:250px;">
                <div class="caption">
                <h3>Tipo de tarjeta: <?php echo $NumTarjeta?> <br>
                Numero: <?php echo $NumTarjeta?></h3>
                    <p><b>Tipo: </b><?php echo $Tipo;?></p>
                    <p><b>Codigo de seguridad: </b><?php echo $CodSeguridad;?></p>
                    
                    <FORM ACTION="controlEliminarPago.php">
                        <div>
                            <input type="text" class="form-control col-sm-4" name="numeroTarjeta"  value="<?php echo  $InformacionPagoId ?>" style="display:none;">
                        </div>
                        <input type="submit" value="Eliminar" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:red; color:white;">
                    </FORM>

                </div>
            </div>
        </div>
        <?php
        }
        ?>
    </div>  
</div>

    <center>
        <!--Añadir más -->
        <div class="col-sm-3 col-md-2 col-10 border shadow p-3 m-2 text-center">
            <a  href="anadirMetodoDePago.php"> <img src="images/plus.png" class="pr-1 img-fluid" style="height:200px;"></a>
                <div class="caption">
                    <h3>Añadir método</h3>
                </div>
        </div><br><br>
    </center>   

    <!--AQUI COMIENZA EL FOOTER -->
    <?php include("footer.php");?>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
    <script>
        $(function(){
            $('[data-toggle="popover"]').popover()
        });
    </script>

</body>
</html>
