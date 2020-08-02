 
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Joyería M&J</title>
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
                            <span class="d-none d-sm-inline text-white p-1 d-sm-none">M&J@onlineshop.com</span>
                        </a>
                            
                        <a class="nav-link disabled" href="#!">
                            <i class="fas fa-phone pl-1 text-white"></i>
                            <span class="d-none d-sm-inline text-white p-1">+34 000000000</span>
                        </a>
                    </nav>

                    <nav class="nav offset-2 offset-sm-5">
                        <a class="nav-link text-white" href="InicioSesion.php">Entrar</a>
                        <a class="nav-link text-white" href="registro.php">Registrarse</a>
                    </nav>
                </div>
            </div>


    <!-- AQUI EMPIEZAN LOS LINKS DEL NAV !-->
    <div class="container-fluid pt-1" style="margin-top: 50px; margin-left: -2%;">
        <div class="row col-sm-12 ">
            <nav class="navbar navbar-expand-lg navbar-light text-left col-4 col-sm-3">
               
               <!--Este es el botón que saldrá en formato movil--> 
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#boton-desplegable" aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
                <span></span> Menu
                </button>
                <div class="collapse navbar-collapse" id="boton-desplegable">
                    <ul class="navbar-nav ml-auto">
                        <li class="nav-item active"><a href="index.php" class="nav-link">Inicio</a></li>
                        <li class="nav-item"><a href="tienda.php" class="nav-link">Tienda</a></li>
                        <li class="nav-item"><a href="contactanos.html" class="nav-link">Contactanos</a></li>
                        <li class="d-none d-sm-none d-md-block"><img src="images/instagram.png" style="width: 25px; margin-top: 30%;"></li><!--SOLO VISIBLE EN ESCRITORIO-->
                        <li class="d-none d-sm-none d-md-block"><img src="images/facebook.png" style="width: 40px; margin-top: 1%;"></li><!--SOLO VISIBLE EN ESCRITORIO-->
                        <li class="d-none d-sm-none d-md-block"><img src="images/youtube.png" style="width: 35px; margin-top: 10%;"></li><!--SOLO VISIBLE EN ESCRITORIO-->
                        <div style="display:flex;">
                            <img src="images/instagram.png" style="width: 25px; height:25px;"  class="d-block d-sm-block d-md-none"><!--SOLO VISIBLE EN MOVIL-->
                            <img src="images/facebook.png" style="width: 40px; height:40px; margin-top: -7%;"  class="d-block d-sm-block d-md-none"><!--SOLO VISIBLE EN MOVIL-->
                            <img src="images/youtube.png" style="width: 30px; height:30px; margin-top: -1%" class="d-block d-sm-block d-md-none"><!--SOLO VISIBLE EN MOVIL-->
                        </div>
                    </ul>
                  
                </div>
            </nav>
        </div>
    </div>
   
   
    <!-- AQUI EMPIEZA EL CONTAINER DEL CARROUSEL !-->
    <div class="container-fluid pt-2">
        <div class="row">
           
            <!-- AQUI COMIENZAN LAS IMAGENES DEL SLIDER !-->
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
               
                <div class="carousel-inner" role="listbox">
                    <div class="carousel-item active">
                        <img class="d-block w-100" src="images/slider1.jpg"  data-holder-rendered="true" alt="Imagen FullHD reloj">
                    </div>

                    <div class="carousel-item">
                        <img class="d-block w-100" src="images/slider2.jpg" data-holder-rendered="true"  alt="Imagen FullHD reloj">
                    </div>
                </div>
                
                <!--Botones para pasar de imagen -->
                <ol class="carousel-indicators">
                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                </ol>

            </div>
        </div>
    </div>



    <!-- AQUI EMPIEZA EL CONTAINER DE LAS IMAGENES DE DEBAJO DEL SLIDER -->
    <div class="container-fluid pt-5">
        <div class="row">


          <!--CREAMOS LA CONEXION PARA COGER LOS REGISTROS DE LAS TABLAS PARA EL STOCK-->
                      <?php
                            include("conexion.php");

                            //creamos las consultas en la base de datos
                            $cantidad_montblanc = file_get_contents("http://localhost:50532/api/Productos?marca=Montblanc");
                            $cantidad_luisMoinet = file_get_contents("http://localhost:50532/api/Productos?marca=Luis+Moinet");
                            $cantidad_breitling = file_get_contents("http://localhost:50532/api/Productos?marca=Breitling");
                            $cantidad_seiko = file_get_contents("http://localhost:50532/api/Productos?marca=Seiko");
                             
                            
                           
                            include("desconexion.php"); 
                        ?>
           
            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid" src="images/montblanc.jpg" style="height: 200px">
                <div class="card-img-overlay">
                    <h3>
                        <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/montblanc.php" class="text-white">Montblanc</a></p>
                    </h3>
                        <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_montblanc ?> en Stock</p>
                </div>
            </div>

           
            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid" src="images/luisMoinet.jpg" alt="Seccion porsche" style="height: 200px">
                <div class="card-img-overlay">
                    <h3>
                  <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/luisMoinet.php" class="text-white">Luis Moinet</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_luisMoinet ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6 p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid" src="images/breitling.jpg" alt="Seccion emisoras" style="height: 200px">
                <div class="card-img-overlay">
                    <h3>
                  <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/breitling.php" class="text-white">Breitling</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_breitling ?> en Stock</p>
                </div>
            </div>

            <div class="col-12 col-sm-6  p-sm-1 col-md-3 p-1 d-flex">
                <img class="card-img img-fluid" src="images/seiko.jpg" alt="Seccion baterias" style="height: 200px">
                <div class="card-img-overlay">
                    <h3>
                    <p class="card-text text-white text-center font-weight-bold pt-5"><a href="secciones/seiko.php" class="text-white">Seiko</a></p>
                    </h3>
                    <p class="card-text text-white text-center pt-1 tossing"><?php echo $cantidad_seiko ?> en Stock</p>
                </div>
            </div>
        </div>
    </div>
    
    <!-- ESTE ES EL CONTAINER DONDE ESTA LA INFORMACION -->
    <div class="container-fluid pt-2" style="display: flex;">
        <div class="row pt-5">
            <div style="width: 50%;">
                <img class="card-img d-none d-sm-none d-md-block col-md-10" src="images/logo.jpg" style=" margin-left: 10%;" alt="Fondo del texto">
            </div>
            <div style="padding-right: 9%" class="col-12 col-md-6">
                <h1>
                    <p class="card-text  text-center pt-5">Quienes somos?</p>
                </h1>
                <p class="card-text text-left pt-5 p-3">-Somos una joyería de relojes de altas marcas donde podrás ver las últimas novedades de las marcas más exclusivas del mercado actual, así como técnicos relojeros autorizados de todas las marcas de la web.</p>
                <p class="card-text text-left pt-4 p-3">-Puedes entrar en las diferentes secciones y verás los coches que tenemos en nuestro stock, también puedes filtrar la busqueda para así encontrar el reloj que mejor se adapte a ti mucho mas rápido. </p>
                <p class="card-text  text-left pt-5 p-3  d-none d-sm-inline">-No encuentras el reloj que quieres? puedes llamarnos o enviarnos un correo para pedir &nbsp;&nbsp; el modelo de la marca que más te guste y te lo enviaremos a tu domicilio de la manera &nbsp;&nbsp;&nbsp;mas óptima posible, con 2 años de garantía y soporte tecnico físico en nuestros &nbsp;&nbsp;&nbsp;talleres.</p>
            </div>       
        </div>
    </div>
    
   
    <!--Aqui empieza el video-->
    <div class="container-fluid p-0 pt-5">
        <div class="row">
            <div class="embed-responsive embed-responsive-16by9  col-sm-12 col-12 p-0 m-0"> 
                 <video width="100%" height="240px" loop autoplay muted>
                     <source src="images/videoIndex.mp4" type="video/mp4" alt="video de muestra">
                 </video>
            </div> 
        </div>
    </div>
        

    <!--Aqui empieza el video-->
    <div class="container-fluid p-0">
        <div class="row">
            <div class="embed-responsive embed-responsive-16by9  col-sm-12 col-12 p-0 m-0"> 
                <img src="images/sponsors.jpg" style="width: 100%; margin-top: -50%;">
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
