using JMShopAdmin.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMShopAdmin.DataAccessLayer
{
    public static class MemoryObjectsDAO
    {
        private static List<Producto> ListaProductos;
        private static List<Pedido> ListaPedidos;
        private static List<ProductoPedido> ListaProductosPedidos;
        private static List<Usuario> ListaUsuarios;
        private static List<Transaccion> ListaTransacciones;
        private static List<InformacionPago> ListaInformacionPagos;
        private static List<DireccionEnvio> ListaDireccionesEnvio;
        private static List<Administrador> ListaAdministradores;

        static MemoryObjectsDAO()
        {
            ListaProductos = new List<Producto>();
            ListaPedidos = new List<Pedido>();
            ListaProductosPedidos = new List<ProductoPedido>();
            ListaUsuarios = new List<Usuario>();
            ListaTransacciones = new List<Transaccion>();
            ListaInformacionPagos = new List<InformacionPago>();
            ListaDireccionesEnvio = new List<DireccionEnvio>();
            ListaAdministradores = new List<Administrador>();
        }


        //Productos//
        /// <summary>
        /// Devuelve la lista de productos.
        /// </summary>
        /// <returns>Lista de productos</returns>
        public static List<Producto> GetListaProductos()
        {
            return ListaProductos;
        }
        /// <summary>
        /// Obtiene el objeto producto especificando su Id.
        /// </summary>
        /// <param name="id">Id producto</param>
        /// <returns>Producto</returns>
        public static Producto GetProductoById(int id)
        {
            foreach (Producto producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    return producto;
                }
            }
            return null;
        }
        /// <summary>
        /// Obtiene el modelo de un producto a partir de su id.
        /// </summary>
        /// <param name="id">Id producto</param>
        /// <returns>Modelo de producto</returns>
        public static string GetProductoModelById(int id)
        {
            foreach (Producto producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    return producto.Modelo;
                }
            }
            return null;
        }
        /// <summary>
        /// Obtiene la marca de un producto a partir de su id
        /// </summary>
        /// <param name="id">Id producto</param>
        /// <returns>Marca producto</returns>
        public static string GetProductoMarcaById(int id)
        {
            foreach (Producto producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    return producto.Marca;
                }
            }
            return null;
        }
        /// <summary>
        /// Obtiene el precio de un producto a partir de su Id
        /// </summary>
        /// <param name="id">Id producto</param>
        /// <returns>Precio producto</returns>
        public static double GetProductoPrecioById(int id)
        {
            foreach (Producto producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    return producto.Precio;
                }
            }
            return -1;
        }
        /// <summary>
        /// Elimina un producto de la memoria de la aplicación.
        /// </summary>
        /// <param name="id">Id producto</param>
        public static void DeleteProducto(int id)
        {
            foreach(Producto p in ListaProductos)
            {
                if(p.Id == id)
                {
                    ListaProductos.Remove(p);
                    break;
                }
            } 
        }

        /// <summary>
        /// Añade producto a la memoria de la aplicación.
        /// </summary>
        /// <param name="p">Objeto Producto</param>
        /// <returns>Boolean</returns>
        public static bool AddProducto(Producto p)
        {
            bool result = false;
            if (!ListaProductos.Contains(p))
            {
                result = true;
                ListaProductos.Add(p);
            }
            return result;
        }
        /// <summary>
        /// Limpia la lista de productos
        /// </summary>
        public static void ClearProductosList()
        {
            ListaProductos.Clear();
        }

        //Administradores//
        /// <summary>
        /// Devuelve la lista de administradores.
        /// </summary>
        /// <returns>Lista de administradores</returns>
        public static List<Administrador> GetListaAdministradores()
        {
            return ListaAdministradores;
        }

        //Usuarios//
        /// <summary>
        /// Devuelve la lista de usuarios.
        /// </summary>
        /// <returns>Lista usuarios</returns>
        public static List<Usuario> GetListaUsuarios()
        {
            return ListaUsuarios;
        }
        /// <summary>
        /// Limpiar lista usuarios.
        /// </summary>
        public static void ClearUsuariosList()
        {
            ListaUsuarios.Clear();
        }
        /// <summary>
        /// Obtener nombre de usuario.
        /// </summary>
        /// <param name="id">Id usuario</param>
        /// <returns>Nombre usuario</returns>
        public static string GetUserNameById(int id)
        {
            string nombre = "";
            foreach(Usuario usuario in ListaUsuarios)
            {
                if(usuario.UsuarioId == id)
                {
                    nombre = usuario.Nombre;
                }
            }
            return nombre;
        }
        /// <summary>
        /// Obtener Email de usuario.
        /// </summary>
        /// <param name="id">Id usuario</param>
        /// <returns>Email usuario</returns>
        public static string GetUserEmailById(int id)
        {
            string email = "";
            foreach (Usuario usuario in ListaUsuarios)
            {
                if (usuario.UsuarioId == id)
                {
                    email = usuario.Email;
                }
            }
            return email;
        }

        //Pedidos//
        /// <summary>
        /// Devuelve la lista de pedidos.
        /// </summary>
        /// <returns></returns>
        public static List<Pedido> GetListaPedidos()
        {
            return ListaPedidos;
        }
        /// <summary>
        /// Limpia lista pedidos.
        /// </summary>
        public static void ClearPedidosList()
        {
            ListaPedidos.Clear();
        }
        /// <summary>
        /// Borra un pedido de la memoria de ejecución del programa.
        /// </summary>
        /// <param name="id">Id pedido</param>
        public static void DeletePedido(int id)
        {
            foreach (Pedido p in ListaPedidos)
            {
                if (p.PedidoId == id)
                {
                    ListaPedidos.Remove(p);
                }
            }
        }
        /// <summary>
        /// Obtiene la Id de transacción a partir de la id del pedido al que pertenece.
        /// </summary>
        /// <param name="pedidoId">Id pedido</param>
        /// <returns>Id trabsacción</returns>
        public static int getTransaccionIdByPedidoId(int pedidoId)
        {
            int transaccionId = -1;
            foreach(Transaccion t in ListaTransacciones)
            {
                if (t.PedidoId == pedidoId)
                {
                    transaccionId = t.TransaccionId;
                }
            }
            return transaccionId;
        }

        //Transacciones//
        /// <summary>
        /// Obtiene la lista de transaccines.
        /// </summary>
        /// <returns>Lista transaccíones</returns>
        public static List<Transaccion> GetListaTransacciones()
        {
            return ListaTransacciones;
        }
        /// <summary>
        /// Limpiar lista de transaccinoes.
        /// </summary>
        public static void ClearTransaccionesList()
        {
            ListaTransacciones.Clear();
        }
        /// <summary>
        /// Obtiene el estado de una transacción a traves de la id del pedido al que pertenece.
        /// </summary>
        /// <param name="id">Id pedido</param>
        /// <returns>Estado transacción</returns>
        public static string GetEstadoTransaccionByIdPedido(int id)
        {
            string estado = "";
            foreach (Transaccion tran in ListaTransacciones)
            {
                if (tran.PedidoId == id)
                {
                    estado = tran.Estado;
                }
            }
            return estado;
        }
        /// <summary>
        /// Obtiene el total de una transacción a través de la id del pedido
        /// </summary>
        /// <param name="id">Id pedido</param>
        /// <returns>Total transacción</returns>
        public static double GetTotalTransaccionByIdPedido(int id)
        {
            double total = -1;
            foreach (Transaccion tran in ListaTransacciones)
            {
                if (tran.PedidoId == id)
                {
                    total = tran.Total;
                }
            }
            return total;
        }
        //Informacion de pago//
        /// <summary>
        /// Obtiene la lista de información de pagos.
        /// </summary>
        /// <returns>Lista información de pagos</returns>
        public static List<InformacionPago> GetListaListaInformacionPagos()
        {
            return ListaInformacionPagos;
        }
        /// <summary>
        /// Limpia la lista de información de pagos.
        /// </summary>
        public static void ClearInformacionPagosList()
        {
            ListaInformacionPagos.Clear();
        }

        //Direcciones de envio//
        /// <summary>
        /// Obtiene la lista de direcciones de envio
        /// </summary>
        /// <returns>Lista dirección de envio</returns>
        public static List<DireccionEnvio> GetListaListaDireccionesEnvio()
        {
            return ListaDireccionesEnvio;
        }
        /// <summary>
        /// Limpia la lista de direcciónes de envío.
        /// </summary>
        public static void ClearDireccionesEnvioList()
        {
            ListaDireccionesEnvio.Clear();
        }

        //Relacion NM productospedidos//
        /// <summary>
        /// Obtiene la lista de productospedidos
        /// </summary>
        /// <returns>Lista productospedidos</returns>
        public static List<ProductoPedido> GetListaProductosPedidos()
        {
            return ListaProductosPedidos;
        }
        /// <summary>
        /// Limpia la lista de productos pedidos
        /// </summary>
        public static void ClearProductosPedidosList()
        {
            ListaProductosPedidos.Clear();
        }
    }
}
