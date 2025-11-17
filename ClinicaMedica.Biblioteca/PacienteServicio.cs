using ClinicaMedica.Modelo;
using ClinicaMedica.Negocio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

#nullable enable

namespace ClinicaMedica.Biblioteca
{
    public class PacienteServicio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public List<Paciente1> Listar(string? filtro = null)
        {
            var lista = new List<Paciente1>();
            using var cn = _conexion.CrearConexion();
            cn.Open();

            string sql = @"SELECT IdPaciente, DNI, Nombre, Apellido, FechaNacimiento, Genero, Telefono, Direccion
                           FROM Paciente";

            if (!string.IsNullOrWhiteSpace(filtro))
                sql += " WHERE DNI LIKE @f OR Nombre LIKE @f OR Apellido LIKE @f";

            using var cmd = new SqlCommand(sql, cn);
            if (!string.IsNullOrWhiteSpace(filtro))
                cmd.Parameters.AddWithValue("@f", "%" + filtro + "%");

            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Paciente1
                {
                    IdPaciente = dr.GetInt32(0),
                    DNI = dr.IsDBNull(1) ? string.Empty : dr.GetString(1),
                    Nombre = dr.IsDBNull(2) ? string.Empty : dr.GetString(2),
                    Apellido = dr.IsDBNull(3) ? string.Empty : dr.GetString(3),
                    FechaNacimiento = dr.IsDBNull(4) ? null : dr.GetDateTime(4),
                    Genero = dr.IsDBNull(5) ? string.Empty : dr.GetString(5),
                    Telefono = dr.IsDBNull(6) ? string.Empty : dr.GetString(6),
                    Direccion = dr.IsDBNull(7) ? string.Empty : dr.GetString(7)
                });
            }

            return lista;
        }

        public int Crear(Paciente1 p)
        {
            using var cn = _conexion.CrearConexion();
            cn.Open();

            string sql = @"INSERT INTO Paciente (DNI, Nombre, Apellido, FechaNacimiento, Genero, Telefono, Direccion)
                           VALUES (@DNI, @Nombre, @Apellido, @FN, @Genero, @Tel, @Dir);
                           SELECT SCOPE_IDENTITY();";

            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@DNI", p.DNI);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@FN", (object?)p.FechaNacimiento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Genero", p.Genero);
            cmd.Parameters.AddWithValue("@Tel", p.Telefono);
            cmd.Parameters.AddWithValue("@Dir", p.Direccion);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Editar(Paciente1 p)
        {
            using var cn = _conexion.CrearConexion();
            cn.Open();

            string sql = @"UPDATE Paciente
                           SET DNI=@DNI, Nombre=@Nombre, Apellido=@Apellido,
                               FechaNacimiento=@FN, Genero=@Genero, Telefono=@Tel, Direccion=@Dir
                           WHERE IdPaciente=@Id";

            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@DNI", p.DNI);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@FN", (object?)p.FechaNacimiento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Genero", p.Genero);
            cmd.Parameters.AddWithValue("@Tel", p.Telefono);
            cmd.Parameters.AddWithValue("@Dir", p.Direccion);
            cmd.Parameters.AddWithValue("@Id", p.IdPaciente);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var cn = _conexion.CrearConexion();
            cn.Open();

            string sql = "DELETE FROM Paciente WHERE IdPaciente=@Id";
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public Paciente1? ObtenerPorId(int id)
        {
            using var cn = _conexion.CrearConexion();
            cn.Open();

            string sql = @"SELECT IdPaciente, DNI, Nombre, Apellido, FechaNacimiento, Genero, Telefono, Direccion
                           FROM Paciente WHERE IdPaciente=@Id";

            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", id);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new Paciente1
            {
                IdPaciente = dr.GetInt32(0),
                DNI = dr.IsDBNull(1) ? string.Empty : dr.GetString(1),
                Nombre = dr.IsDBNull(2) ? string.Empty : dr.GetString(2),
                Apellido = dr.IsDBNull(3) ? string.Empty : dr.GetString(3),
                FechaNacimiento = dr.IsDBNull(4) ? null : dr.GetDateTime(4),
                Genero = dr.IsDBNull(5) ? string.Empty : dr.GetString(5),
                Telefono = dr.IsDBNull(6) ? string.Empty : dr.GetString(6),
                Direccion = dr.IsDBNull(7) ? string.Empty : dr.GetString(7)
            };
        }
    }
}
