using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebService
{
    /// <summary>
    /// Summary description for WebS
    /// </summary>
    [WebService(Namespace = "http://localhost/11111", Name = "Biblioteca")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class WebS
    {
        [WebMethod]
        public string registrarUsuario(int carnet, string nombre, int dpi, string direccion, int telefono)
        {
            string conexion = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            SqlCommand CMD = new SqlCommand("insert into Cliente values (" + carnet + ",'" + nombre + "'," + dpi + ",'" + direccion + "'," + telefono + ")", con);
            CMD.ExecuteNonQuery();

            return "Agregado!";
        }

        [WebMethod]
        public string registrarLibro(int isbn, string nombre, int noexi, int nopag, string autor, string tema)
        {
            string conexion = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            SqlCommand CMD = new SqlCommand("insert into Libro values (" + isbn + ",'" + nombre + "'," + noexi + "," + nopag + ",'" + autor + "','" + tema + "'," + noexi + ", 0, 0)", con);
            CMD.ExecuteNonQuery();

            return "Agregado!";
        }

        [WebMethod]
        public string servicioLibro(int carnet, int tipo, int libro)
        {
            string conexion = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            SqlCommand CMD = new SqlCommand("insert into Transaccion values (" + carnet + "," + tipo + "," + libro + ")", con);
            SqlCommand MCD = new SqlCommand("UPDATE Libro SET Disponibles = Disponibles - 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
            SqlCommand DMC = new SqlCommand("UPDATE Libro SET Prestados = Prestados + 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
            CMD.ExecuteNonQuery();
            MCD.ExecuteNonQuery();
            DMC.ExecuteNonQuery();

            return "Agregado!";
        }

        [WebMethod]
        public string buscarLibros()
        {
            string conexion = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            SqlDataAdapter CMD = new SqlDataAdapter("select Nombre, Autor, Existencias, Disponibles, Prestados, Reservados from Libro;", con);
            DataSet DS = new DataSet();
            CMD.Fill(DS, "Libro");

            return "Listo!";
        }
    }
}

