<?php
session_start();
$UsuarioId = $_SESSION['id'];
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Mis pedidos</title>
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

    <!--Aqui empieza el video-->
    <div class="container-fluid p-0">
        <div class="row">
            <div class="embed-responsive embed-responsive-16by9  col-sm-12 col-12 p-0 m-0"> 
                <video loop autoplay muted>
                    <source src="images/pedidosRealizadosVideo.mp4" type="video/mp4" alt="video de muestra">
                </video>
            </div> 
        </div>
    </div>
    
   <!-- BARRA QUE NOS DICE DONDE ESTAMOS -->
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="../index.php" class="text-dark">Inicio</a></li>
            <li class="breadcrumb-item"><a href="../tienda.php" class="text-dark">Tienda</a></li>
            <li class="breadcrumb-item"><a href="#" class="text-dark">Mis pedidos</a></li>
        </ol>
    </nav>
    
     <!-- AQUI EMPIEZAN LAS IMAGENES DE LOS RELOJES-->
     <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            include("../conexion.php");
            
            $resultados = file_get_contents('http://localhost:50532/api/Transacciones?idUsuario='.$UsuarioId.'');
            $json = json_decode($resultados, true);

            foreach($json as $value){
                $Total = $value['Total'];
                $Estado = $value['Estado'];
                $FechaCreacion = $value['FechaCreacion'];
                $PedidoId = $value['PedidoId'];               
        ?>

        <!--PRODUCTO -->
        <div class="col-sm-6 col-md-4 col-12 border shadow p-3 mb-5 bg-white rounded m-2 hatch">
                <div class="thumbnail">
                  <div class="caption">
                    <p><b>Id del pedido: </b><?php echo $PedidoId;?></p>
                    <p><b>Fecha de compra: </b><?php echo $FechaCreacion;?></p>
                    <p><b>Estado del pedido: </b><?php echo $Estado;?></p>
                    Precio total: <p style="color:green;"><?php echo number_format($Total,2,",",".");?> €</p><!--Precio-->
                    <div style="display:flex;">
                        <FORM ACTION="controlListarDetalles.php">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="pedidoId"  value="<?php echo $PedidoId?>" style="display:none; position:absolute; top: 3000px" >
                            </div>
                            <input type="submit" value="Detalles" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:grey; color:white;">
                        </FORM> &nbsp; &nbsp;
                        <FORM ACTION="controlEliminarPedido.php">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="pedidoId2"  value="<?php echo $PedidoId?>" style="display:none; position:absolute; top: 3000px" >
                            </div>
                            <input type="submit" value="Eliminar pedido" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:red; color:white;">
                        </FORM> 
                    </div>
                  </div>
                </div>
              </div>
              <?php
                }
              ?>
        </div>   
    </div>



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
