<?php
session_start();
$UsuarioId = $_SESSION['id'];
$totalPedido = 0;
$PedidoId = 0;
$notaEntrega = "";

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Carrito</title>
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
    
    <p class="text-center pt-5 pb-5"><h1 class="text-center pt-5 pb-5" style="font-size:60px"><b>Carrito de compra</b></h1></p>
    
    <!-- BARRA QUE NOS DICE DONDE ESTAMOS -->
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="../index.php" class="text-dark">Inicio</a></li>
            <li class="breadcrumb-item"><a href="../tienda.php" class="text-dark">Tienda</a></li>
            <li class="breadcrumb-item"><a href="#" class="text-dark">Carrito</a></li>
        </ol>
    </nav>
        
       
    <!--CONTAINER CON OS ARTICULOS AÑADIDOS AL CARRITO-->
    <p class="text-center pt-1 pb-1"><h1 class="text-center" style="font-size:40px"><b>Artículos añadidos</b></h1></p>

    <!-- AQUI EMPIEZAN LAS IMAGENES DE LOS RELOJES-->
    <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            include("../conexion.php");
            
            $resultados = file_get_contents('http://localhost:50532/api/ProductosPedidos?userId='.$UsuarioId.'');
            $json = json_decode($resultados, true);

            foreach($json as $value){
                $Cantidad = $value['Cantidad'];
                $Marca = $value['Marca'];
                $Modelo = $value['Modelo'];
                $ProductoId = $value['ProductoId'];
                $Precio = $value['Precio'];
                $PrecioPorCantidad = $value['Total']; 
                $ProductoPedidoId = $value['ProductoPedidoId'];
                $PedidoId = $value['PedidoId'];
                $totalPedido = $totalPedido + $PrecioPorCantidad;
        ?>

        <!--PRODUCTO -->
        <div class="col-sm-4 col-md-4 col-12 shadow p-1 mb-5 bg-white rounded m-2 border border-secondary" >
                <div class="thumbnail">
                  <div class="caption">
                    <h3><?php echo $Marca." ".$Modelo;?></h3>
                  
                    <p style="color:green;">Precio por unidad: <?php echo number_format($Precio,2,",",".");?> €</p><!--Precio-->

                    <div style="display:flex;">
                      <!--Botón SumarCantidad-->
                      <FORM ACTION="controlSumarCantidad.php">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="ProductoPedidoId"  value="<?php echo $ProductoPedidoId?>" style="display:none; position:absolute;  top: 3000px">
                            </div>
                            <input type="submit" value="+" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:green; color:white;" ></input>
                        </FORM>  
                        &nbsp;
                         <!--Botón RestarCantidad-->
                        <FORM ACTION="controlRestarCantidad.php">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="ProductoPedidoId"  value="<?php echo $ProductoPedidoId?>" style="display:none; position:absolute; top: 3000px" >
                            </div>
                            <input type="submit" value="-" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:red; color:white;">
                        </FORM> 
                        &nbsp;Cantidad: <?php echo $Cantidad ?>
                    </div>
                    <p style="color:green;">Total: <?php echo number_format($PrecioPorCantidad,2,",",".");?> €</p><!--Precio-->
                        
                        </a>   
                    </div>
                </div>
            </div>
            <?php
                }

               
            ?>
        </div>   
    </div>



    <!--CONTAINER CON LAS DIRECCIONES DISPONIBLES-->
    <p class="text-center pt-1 pb-1"><h1 class="text-center" style="font-size:40px"><b>Direcciones de envío</b></h1></p>


  <!-- AQUI EMPIEZAN LAS IMAGENES DE LAS DIRECCIONES-->
  <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            
            include("../conexion.php"); //--Conexión
            
            $resultados = file_get_contents("http://localhost:50532/api/DireccionesEnvio?userId=".$_SESSION['id']."");
            $json = json_decode($resultados, true);

            foreach($json as $value){
                $IdDireccion = $value['DireccionEnvioId'];
                $Calle = $value['Calle'];
                $Ciudad = $value['Ciudad'];
                $CodPostal = $value['CodPostal'];
                $NumDomicilio = $value['NumDomicilio'];
                $Poblacion = $value['Poblacion'];
                $Provincia = $value['Provincia'];

            
        ?>

            <!--Dirección -->
            <div class="col-sm-6 col-md-3 col-12 border shadow p-3 mb-5 bg-white rounded m-2 hatch">
                <div class="thumbnail">
                    <img src="images/direccion.png" class="p-3 img-fluid" style="height:250px;">
                    <div class="caption">
                    <h3>Calle <?php echo $Calle;?>, puerta: <?php echo $NumDomicilio;?></h3>
                        <p><b>Población: </b><?php echo $Poblacion;?></p>
                        <p><b>Ciudad: </b><?php echo $Ciudad;?></p>
                        <p><b>Provincia: </b><?php echo $Provincia;?></p>
                        <p><b>Cod.Postal: </b><?php echo $CodPostal?></p>  
                        <!--Botón seleccionarDirección-->
                        <FORM ACTION="controlSeleccionarDireccion.php">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="idDirección"  value="<?php echo $IdDireccion?>" style="display:none;">
                            </div>
                            <input type="submit" value="Seleccionar" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:green; color:white;"></input>
                        </FORM>  
                        
                         
                    </div>
                </div>
            </div>
            <?php
            }
            ?>
        </div>  
    </div> 





    <!--CONTAINER CON LAS TARJETAS-->
    <p class="text-center pt-1 pb-1"><h1 class="text-center" style="font-size:40px"><b>Métodos de pago</b></h1></p>






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
                    <!--Botón seleccionarPago-->
                    <FORM ACTION="controlSeleccionarPago.php">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="idPago"  value="<?php echo $InformacionPagoId?>" style="display:none;">
                            </div>
                            <input type="submit" value="Seleccionar" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:green; color:white;"></input>
                        </FORM> 
                </div>
            </div>
        </div>
        <?php
            }
        ?>
    </div>  
</div>



    <!-- AQUI EMPIEZA EL CONTAINER DE EL RESUMEN DE EL PRECIO Y DEL TIPO DE ENVÍO-->
    <div class="container-fluid">
            <div class="row col-sm-12 d-flex justify-content-center col-12">

            <!--PRODUCTO -->
            <div class="col-sm-6 col-md-2 col-12  border shadow  p-3 mb-5 bg-white rounded">
                <p class="text-center pb-5"><h1 class="text-center" style="font-size:40px; margin-top:-20%;"><b>Resumen</b></h1></p>
                    <div class="thumbnail">
                        <div class="caption">

                    <FORM ACTION="controlTramitarPedido.php">
                       <input type="text" class="form-control col-sm-12 col-12" name="notaEntrega"  value="" placeholder="Pon una nota de entrega">
                       <input type="text" class="form-control col-sm-4" name="PedidoId"  value="<?php echo $PedidoId?>" style="display:none;">
                      <center> <input type="submit" value="Tramitar Pedido" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:green; color:white;"> </center>
                    </Form>
                            </div><br>
                            <center><p style="color:green;"><b>PVP: <?php echo $totalPedido ?></b></p></center>
                            
                        </div>
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
            $('[data-toggle="popover"]').popover()
        });
    </script>

</body>
</html>
