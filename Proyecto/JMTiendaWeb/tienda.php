<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Tienda</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous">
    <link rel="stylesheet" href="css/transitions.css">
    <link rel="stylesheet" href="css/estilosPersonales.css">
     <link rel="icon" type="image/png" href="images/logo.png">
</head>

<body>
    
    
    
       <!-- CONTAINER DE LOGIN/REGISTER, CORREO/TLF !-->
       <div class="container-fluid p-0 fixed-top col-12 fondoNegro">
                <div class="row border-bottom">
                <nav class="nav offset-sm-1 offset-1">
                        <a class="nav-link disabled" href="#!">
                            <i class="far fa-envelope-open pl-1 text-white"></i>
                            <span class="d-none d-sm-inline text-white p-1">M&J@onlineshop.com</span>
                        </a>
                            
                        <a class="nav-link disabled" href="#!">
                            <i class="fas fa-phone pl-1 text-white"></i>
                            <span class="d-none d-sm-inline text-white p-1">+34 000000000</span>
                        </a>
                    </nav>

                    <nav class="nav offset-2 offset-sm-5">
                        <a class="nav-link text-white" href="registro.php">Entrar</a>
                        <a class="nav-link text-white" href="registro.php">Registrarse</a>
                    </nav>
                </div>
            </div>
    
    
    
    <div class="container-fluid pt-5">
        <div class="row">
            <h1 class="col-12">
                   <p class="font-weight-bold pt-5 offset-3 offset-sm-5 pb-sm-5">SECCIONES</p>
               </h1>
        </div>
    </div>

    <!-- BARRA QUE NOS DICE DONDE ESTAMOS -->
    <nav aria-label="breadcrumb ">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="index.php" class="text-dark">Inicio</a></li>
                <li class="breadcrumb-item"><a href="tienda.php" class="text-dark">Tienda</a></li>
            </ol> 
    </nav>

     <!--VAMOS A CREAR LA CONEXIÓN CON LA BASE DE DATOS PARA RECOGER LOS PRODUCTOS QUE TENEMOS EN STOCK DE CADA SECCIÓN-->

        <?php
            include("conexion.php");

             //creamos las consultas en la base de datos
             $cantidad_montblanc = file_get_contents("http://localhost:50532/api/Productos?marca=Montblanc");
             $cantidad_luisMoinet = file_get_contents("http://localhost:50532/api/Productos?marca=Luis+Moinet");
             $cantidad_breitling = file_get_contents("http://localhost:50532/api/Productos?marca=Breitling");
             $cantidad_seiko = file_get_contents("http://localhost:50532/api/Productos?marca=Seiko");
             $cantidad_omega = file_get_contents("http://localhost:50532/api/Productos?marca=Omega");
             $cantidad_rolex = file_get_contents("http://localhost:50532/api/Productos?marca=Rolex");
             $cantidad_patekPhilipe = file_get_contents("http://localhost:50532/api/Productos?marca=Patek+Phillipe");
             $cantidad_chopard = file_get_contents("http://localhost:50532/api/Productos?marca=Chopard");

            include("desconexion.php"); 
     ?>

     <!-- AQUI EMPIEZA LA PRIMERA FILA DE LAS IMAGENES-->
     <div class="container-fluid pt-5">
        <div class="row">
            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/montblanc.jpg"  style="height: 200px">
                <div class="card-img-overlay">
                    <h3>
                        <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/montblanc.php" class="text-white">Montblanc</a></p>
                    </h3>
                        <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_montblanc; ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/luisMoinet.jpg"  style="height: 200px" alt=" imagen seccion porsche">
                <div class="card-img-overlay">
                    <h3>
                        <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/luisMoinet.php" class="text-white">Luis Moinet</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_luisMoinet; ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/breitling.jpg" style="height: 200px">
                <div class="card-img-overlay">
                    <h3>
                      <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/breitling.php" class="text-white">Breitling</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_breitling; ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6  p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/seiko.jpg" style="height: 200px" alt=" imagen seccion mercedes">
                <div class="card-img-overlay">
                    <h3>
                    <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/seiko.php" class="text-white">Seiko</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_seiko; ?> en Stock</p>
                </div>
            </div>
        </div>
    </div>
    
    
    <!--Fila 2 marcas -->
    <div class="container-fluid pt-0 pb-5">
        <div class="row">
            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/omega.jpg" alt="Card image" style="height: 200px" alt=" imagen seccion bmw">
                <div class="card-img-overlay">
                    <h3>
                      <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/omega.php" class="text-white">Omega</a></p>
                    </h3>
                   <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_omega; ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/rolex.jpg" alt="Card image" style="height: 200px" alt=" imagen seccion Aston Martin">
                <div class="card-img-overlay">
                    <h3>
                    <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/rolex.php" class="text-white">Rolex</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_rolex; ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/patek.jpg" alt="Card image" style="height: 200px" alt=" imagen seccion Tesla">
                <div class="card-img-overlay">
                    <h3>
                      <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/patek.php" class="text-white">Patek Philippe</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_patekPhilipe; ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6  p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid pullUp" src="images/chopard.jpg" alt="Card image" style="height: 200px" alt=" imagen seccion Lexus">
                <div class="card-img-overlay">
                    <h3>
                      <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/chopard.php" class="text-white">Chopard</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_chopard; ?> en Stock</p>
                </div>
            </div>
        </div>
    </div>
    
  
    <!--AQUI COMIENZA EL FOOTER -->
    <?php include("footer.php");?>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
</body>
</html>
