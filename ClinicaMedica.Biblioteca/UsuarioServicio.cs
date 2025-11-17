using ClinicaMedica.Modelo;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Negocio
{
    public class UsuarioServicio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public List<UsuarioListado> Listar(string? rol = null)
        {
            var lista = new List<UsuarioListado>();

            using var cn = _conexion.CrearConexion();
            cn.Open();

            string sql = @"
                SELECT u.IdUsuario, u.Nombre, u.Apellido, u.Email, u.Rol
                FROM Usuario u
                /**where**/
                ORDER BY u.Apellido, u.Nombre;";

            if (!string.IsNullOrWhiteSpace(rol))
                sql = sql.Replace("/**where**/", "WHERE u.Rol = @Rol");
            else
                sql = sql.Replace("/**where**/", "");

            using var cmd = new SqlCommand(sql, cn);
            if (!string.IsNullOrWhiteSpace(rol))
                cmd.Parameters.AddWithValue("@Rol", rol);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lista.Add(new UsuarioListado
                {
                    IdUsuario = rd.GetInt32(0),
                    Nombre = rd.IsDBNull(1) ? string.Empty : rd.GetString(1),
                    Apellido = rd.IsDBNull(2) ? string.Empty : rd.GetString(2),
                    Email = rd.IsDBNull(3) ? string.Empty : rd.GetString(3),
                    Rol = rd.IsDBNull(4) ? string.Empty : rd.GetString(4)
                });
            }

            return lista;
        }
    }
}
