<?php
session_start();
$UsuarioId = $_SESSION['id'];
$idDetallesPedidoRealizado= $_SESSION['detallesPedidoRealizado'];
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
  <br><br><br><br>
    <center><h1>Dirección de envío</h1></center>
     <!-- AQUI EMPIEZAN LAS IMAGENES DE LOS RELOJES-->
     <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            include("../conexion.php");
            
            $resultados = file_get_contents('http://localhost:50532/api/DireccionesEnvio?pedidoId='.$idDetallesPedidoRealizado.'');
            $json = json_decode($resultados, true);

          
                $Calle = $json['Calle'];
                $NumDomicilio = $json['NumDomicilio'];
                $Poblacion = $json['Poblacion'];
                $Provincia = $json['Provincia'];
                $CodPostal = $json['CodPostal'];                
        ?>

        <!--PRODUCTO -->
        <div class="col-sm-6 col-md-4 col-12 border shadow p-3 mb-5 bg-white rounded m-2 hatch">
                <div class="thumbnail">
                  <div class="caption">
                    <p><b>Calle:</b><?php echo $Calle;?></p>
                    <p><b>Número de domicilio: </b><?php echo $NumDomicilio;?></p>
                    <p><b>Poblacion: </b><?php echo $Poblacion;?></p>
                    <p><b>Provincia: </b><?php echo $Provincia;?></p>
                    <p><b>Cod.Postal: </b><?php echo $CodPostal;?></p>
                  </div>
                </div>
              </div>
        </div>   
    </div><br><br>

    <center><h1>Método de pago</h1></center>
     <!-- AQUI EMPIEZAN LAS IMAGENES DE LOS RELOJES-->
     <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            include("../conexion.php");
            
            $resultados = file_get_contents('http://localhost:50532/api/InformacionPago?pedidoId='.$idDetallesPedidoRealizado.'');
            $json = json_decode($resultados, true);

          
                $NumTarjeta = $json['NumTarjeta'];
                $Tipo = $json['Tipo'];
                $FechaCaducidad = $json['FechaCaducidad'];
                $CodSeguridad = $json['CodSeguridad'];        
        ?>

        <!--PRODUCTO -->
        <div class="col-sm-6 col-md-4 col-12 border shadow p-3 mb-5 bg-white rounded m-2 hatch">
                <div class="thumbnail">
                  <div class="caption">
                    <p><b>Número de tarjeta: </b><?php echo $NumTarjeta;?></p>
                    <p><b>Tipo de tarjeta: </b><?php echo $Tipo;?></p>
                    <p><b>Fecha de caducidad: </b><?php echo $FechaCaducidad;?></p>
                    <p><b>Cod.Seguridad: </b><?php echo $CodSeguridad;?></p>
                  </div>
                </div>
              </div>
        </div>   
    </div><br><br>



    <center><h1>Productos del pedido</h1></center>
     <!-- AQUI EMPIEZAN LAS IMAGENES DE LOS RELOJES-->
     <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            include("../conexion.php");
            
            $resultados = file_get_contents('http://localhost:50532/api/ProductosPedidos?pedidoId='.$idDetallesPedidoRealizado.'');
            $json = json_decode($resultados, true);

          
            foreach($json as $value){
                $Cantidad = $value['Cantidad'];
                $Total = $value['Total'];
                $Modelo = $value['Modelo'];
                $Marca = $value['Marca'];
                $Precio = $value['Precio'];   
        ?>

        <!--PRODUCTO -->
        <div class="col-sm-6 col-md-4 col-12 border shadow p-3 mb-5 bg-white rounded m-2 hatch">
                <div class="thumbnail">
                  <div class="caption">
                    <p><b>Cantidad de productos: </b><?php echo $Cantidad;?></p>
                    <p><b>Modelo: </b><?php echo $Modelo;?></p>
                    <p><b>Marca: </b><?php echo $Marca;?></p>
                    <p><b>Total precio: </b><?php echo $Total;?></p>
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
