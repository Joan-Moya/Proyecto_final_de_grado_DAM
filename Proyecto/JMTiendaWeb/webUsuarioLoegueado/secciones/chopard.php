<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Chopard</title>
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
                <video width="100%" height="240px" loop autoplay muted>
                    <source src="images/chopardVideo.mp4" type="video/mp4" alt="video de muestra">
                </video>
            </div> 
        </div>
    </div>

    <!-- BARRA QUE NOS DICE DONDE ESTAMOS -->
    <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="../index.php" class="text-dark">Inicio</a></li>
                <li class="breadcrumb-item"><a href="../tienda.php" class="text-dark">Tienda</a></li>
                <li class="breadcrumb-item"><a href="chopard.php" class="text-dark">Chopard</a></li>
            </ol>
    </nav>
        
      <!--Barra espaciadora-->
      <div class="container-fluid p-0 ">
          <nav class="navbar navbar-expand-sm navbar-dark fondoNegro justify-content-center">
           <br><br>
        </nav>
    </div>
    

     <!-- AQUI EMPIEZAN LAS IMAGENES DE LOS RELOJES-->
     <div class="container-fluid  pt-4">
        <div class="row col-sm-12 d-flex justify-content-center">
           
        <?php
            include("conexion.php");
            
            $resultados = file_get_contents("http://localhost:50532/api/Productos?mc=Chopard");
            $json = json_decode($resultados, true);

            foreach($json as $value){
                $Marca = $value['Marca'];
                $Modelo = $value['Modelo'];
                $Descripcion = $value['Descripcion'];
                $Precio = $value['Precio'];
                $Cristal = $value['Cristal'];
                $Diametro = $value['Diametro'];
                $TipoCorrea = $value['TipoCorrea'];
                $ImagenProducto = $value['ImagenProducto'];
                $Precio = $value['Precio'];
                $Id = $value['Id'];
                $UsuarioId = $_SESSION['id']
                
                
        ?>

        <!--PRODUCTO -->
        <div class="col-sm-6 col-md-4 col-12 border shadow p-3 mb-5 bg-white rounded m-2 hatch">
                <div class="thumbnail">
                  <img src="../../productImages/<?php echo $ImagenProducto;?>" class="p-3 img-fluid" alt="foto reloj" style="height:250px;">
                  <div class="caption">
                    <h3><?php echo $Marca." ".$Modelo;?></h3>
                    <p><b>Descripción: </b><?php echo $Descripcion;?></p>
                    
                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>Diametro</th>
                                <th class="d-none d-md-block">Tipo cristal</th>
                                <th>Correa</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td scope="row"><?php echo $Diametro;?></td>
                                <td class="d-none d-md-block"><?php echo $Cristal;?></td>
                                <td><?php echo $TipoCorrea;?></td>
                            </tr>
                        </tbody>
                    </table>
    
                    <p style="color:green;"><?php echo number_format($Precio,2,",",".");?> €</p><!--Precio-->
                

                        <!--Botón añadir al carrito-->
                        <FORM ACTION="controlAnadirCarrito.php">
                            <div>
                                <input type="text" class="form-control col-sm-4" name="idProducto"  value="<?php echo $Id?>" style="display:none;">
                            </div>
                            <input type="submit" value="Añadir al carrito" style="margin-top:3%; margin-bottom:5%; border:0px; background-color:green; color:white;"></input>
                        </FORM>   
                    </div>
                </div>
            </div>
            <?php
                }
            ?>
        </div>   
    </div>

    <div class="container-fluid">
        <div class="row col-12 offset-sm-5 offset-2">
            <nav aria-label="Page navigation example">
              <ul class="pagination">
                <li class="page-item">
                  <a class="page-link" href="#!" aria-label="Previous">
                    <span aria-hidden="true">&laquo;</span>
                    <span class="sr-only">Previous</span>
                  </a>
                </li>
                  <li class="page-item"><a class="page-link" href="#!">1</a></li>
                  <li class="page-item"><a class="page-link" href="#!">2</a></li>
                  <li class="page-item"><a class="page-link" href="#!">3</a></li>
                  <li class="page-item">
                  <a class="page-link" href="#!" aria-label="Next">
                    <span aria-hidden="true">&raquo;</span>
                    <span class="sr-only">Next</span>
                  </a>
                </li>
              </ul>
            </nav>
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
