using ClinicaMedica.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Negocio
{
    public class MedicamentoServicio
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Medicamento> Listar()
        {
            var lista = new List<Medicamento>();

            using (var cn = conexion.CrearConexion())
            {
                cn.Open();
                string sql = "SELECT IdMedicamento, Nombre, Descripcion, Stock FROM Medicamento";

                using (var cmd = new SqlCommand(sql, cn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Medicamento
                        {
                            IdMedicamento = dr.GetInt32(0),
                            Nombre = dr.GetString(1),
                            Descripcion = dr.GetString(2),
                            Stock = dr.GetInt32(3)
                        });
                    }
                }
            }

            return lista;
        }

        public void Crear(string nombre, string descripcion, int stock)
        {
            using (var cn = conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"INSERT INTO Medicamento (Nombre, Descripcion, Stock)
                               VALUES (@n, @d, @s)";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@n", nombre);
                    cmd.Parameters.AddWithValue("@d", descripcion);
                    cmd.Parameters.AddWithValue("@s", stock);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Editar(int id, string nombre, string descripcion, int stock)
        {
            using (var cn = conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"UPDATE Medicamento SET
                               Nombre=@n, Descripcion=@d, Stock=@s
                               WHERE IdMedicamento=@id";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@n", nombre);
                    cmd.Parameters.AddWithValue("@d", descripcion);
                    cmd.Parameters.AddWithValue("@s", stock);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var cn = conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"DELETE FROM Medicamento WHERE IdMedicamento=@id";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
