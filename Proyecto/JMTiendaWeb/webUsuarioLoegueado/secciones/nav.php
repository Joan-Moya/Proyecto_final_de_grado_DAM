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
</head>

<body>
    
    <!-- CONTAINER DE LOGIN/REGISTER, CORREO/TLF !-->
    <div class="container-fluid p-0 fixed-top col-12 fondoNegro">
        <div class="row border-bottom">
            <nav class="nav offset-sm-1 p-2">
                <a class="nav-link disabled" href="#!">
                    <i class="far fa-envelope-open pl-1 text-white"></i>
                    <span class="d-none d-sm-inline text-white p-1 d-sm-none">M&J@onlineshop.com</span>
                </a>
                <a class="nav-link disabled" href="#!">
                    <i class="fas fa-phone  text-white"></i>
                    <span class="d-none d-sm-inline text-white p-1">+34 000000000</span>
                </a>
            </nav>

            <nav class="nav offset-4 offset-sm-5">
            <!--Botón para acceder al carrito-->
            <button type="button" class="btn btn-default"  style="color:white;">
               <a href="../seccionesNav/carrito.php"> <i class="fas fa-shopping-cart" style="color:white;"></i> <span class="caret"></span></a><!--Icono del botón--> 
            </button>  
            <!--Botón desplegable con configuraciones de la cuenta de usuario-->
            <div class="btn-group">
                <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" style="color:white;">
                    <i class="fas fa-users-cog"></i> <span class="caret"></span><!--Icono del botón--> 
                </button>
                <ul class="dropdown-menu" role="menu">
                    <li><a href="../seccionesNav/misPedidos.php">Mis pedidos</a></li>
                    <li><a href="../seccionesNav/favoritos.php">Favoritos</a></li>
                    <li><a href="../seccionesNav/metodosPago.php">Método de pago</a></li>
                    <li><a href="../seccionesNav/misDirecciones.php">Direcciones</a></li>
                    <li class="divider"></li>
                    <li><a href="InicioSesion.php">Cerrar sesión</a></li>
                </ul>
            </div>
        </nav>
    </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>

</body>
</html>
