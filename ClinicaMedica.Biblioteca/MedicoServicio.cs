using ClinicaMedica.Modelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ClinicaMedica.Negocio
{
    public class MedicoServicio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public List<MedicoListado> Listar()
        {
            var lista = new List<MedicoListado>();

            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();

                string sql = @"
                     SELECT 
                        m.IdMedico,
                        u.IdUsuario,
                        u.Nombre,
                        u.Apellido,
                        u.Email,
                        u.[Contraseña] AS Contraseña,
                        m.Especialidad
                     FROM Medico m
                     INNER JOIN Usuario u ON u.IdUsuario = m.IdUsuario
                     ORDER BY u.Apellido, u.Nombre;";

                using (var cmd = new SqlCommand(sql, cn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new MedicoListado
                        {
                            IdMedico = dr.GetInt32(0),
                            IdUsuario = dr.GetInt32(1),
                            Nombre = dr.IsDBNull(2) ? "" : dr.GetString(2),
                            Apellido = dr.IsDBNull(3) ? "" : dr.GetString(3),
                            Email = dr.IsDBNull(4) ? "" : dr.GetString(4),
                            Contraseña = dr.IsDBNull(5) ? "" : dr.GetString(5),
                            Especialidad = dr.IsDBNull(6) ? "" : dr.GetString(6),
                        });
                    }
                }
            }

            return lista;
        }

        public void Crear(string nombre, string apellido, string email, string contraseña, string especialidad)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();

                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        string sqlUsuario = @"
                            INSERT INTO Usuario (Nombre, Apellido, Email, Contraseña, Rol)
                            VALUES (@Nombre, @Apellido, @Email, @Contraseña, 'Medico');
                            SELECT CAST(SCOPE_IDENTITY() AS INT);
                        ";

                        int idUsuario;
                        using (var cmd = new SqlCommand(sqlUsuario, cn, tx))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", nombre);
                            cmd.Parameters.AddWithValue("@Apellido", apellido);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                            idUsuario = (int)cmd.ExecuteScalar();
                        }

                        string sqlMedico = @"
                            INSERT INTO Medico (IdUsuario, Especialidad)
                            VALUES (@IdUsuario, @Especialidad);
                        ";

                        using (var cmd2 = new SqlCommand(sqlMedico, cn, tx))
                        {
                            cmd2.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmd2.Parameters.AddWithValue("@Especialidad", especialidad);
                            cmd2.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public int CrearConUsuario(string nombre, string apellido, string email, string contrasena, string especialidad)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        string sqlUsuario = @"
                            INSERT INTO Usuario (Nombre, Apellido, Email, [Contraseña], Rol)
                            VALUES (@Nombre, @Apellido, @Email, @Contrasena, 'Medico');
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        int idUsuario;
                        using (var cmdU = new SqlCommand(sqlUsuario, cn, tx))
                        {
                            cmdU.Parameters.AddWithValue("@Nombre", (object?)nombre ?? DBNull.Value);
                            cmdU.Parameters.AddWithValue("@Apellido", (object?)apellido ?? DBNull.Value);
                            cmdU.Parameters.AddWithValue("@Email", (object?)email ?? DBNull.Value);
                            cmdU.Parameters.AddWithValue("@Contrasena", (object?)contrasena ?? DBNull.Value);
                            idUsuario = (int)cmdU.ExecuteScalar();
                        }

                        string sqlMedico = @"
                            INSERT INTO Medico (IdUsuario, Especialidad)
                            VALUES (@IdUsuario, @Especialidad);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        int idMedico;
                        using (var cmdM = new SqlCommand(sqlMedico, cn, tx))
                        {
                            cmdM.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdM.Parameters.AddWithValue("@Especialidad", (object?)especialidad ?? DBNull.Value);
                            idMedico = (int)cmdM.ExecuteScalar();
                        }

                        tx.Commit();
                        return idMedico;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool Editar(int idMedico, int idUsuario, string nombre, string apellido, string email, string contrasena, string especialidad)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        string sqlU = @"
                            UPDATE Usuario
                            SET Nombre=@Nombre, Apellido=@Apellido, Email=@Email, [Contraseña]=@Contrasena
                            WHERE IdUsuario=@IdUsuario;";

                        using (var cmdU = new SqlCommand(sqlU, cn, tx))
                        {
                            cmdU.Parameters.AddWithValue("@Nombre", (object?)nombre ?? DBNull.Value);
                            cmdU.Parameters.AddWithValue("@Apellido", (object?)apellido ?? DBNull.Value);
                            cmdU.Parameters.AddWithValue("@Email", (object?)email ?? DBNull.Value);
                            cmdU.Parameters.AddWithValue("@Contrasena", (object?)contrasena ?? DBNull.Value);
                            cmdU.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdU.ExecuteNonQuery();
                        }

                        string sqlM = @"UPDATE Medico SET Especialidad=@Esp WHERE IdMedico=@IdMedico;";
                        using (var cmdM = new SqlCommand(sqlM, cn, tx))
                        {
                            cmdM.Parameters.AddWithValue("@Esp", (object?)especialidad ?? DBNull.Value);
                            cmdM.Parameters.AddWithValue("@IdMedico", idMedico);
                            cmdM.ExecuteNonQuery();
                        }

                        tx.Commit();
                        return true;
                    }
                    catch
                    {
                        tx.Rollback();
                        return false;
                    }
                }
            }
        }

        public void Eliminar(int idMedico, int idUsuario)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();

                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        string sqlReceta = @"
                    DELETE r
                    FROM Receta r
                    INNER JOIN Cita c ON r.IdCita = c.IdCita
                    WHERE c.IdMedico = @idMedico";
                        using (var cmdR = new SqlCommand(sqlReceta, cn, tx))
                        {
                            cmdR.Parameters.AddWithValue("@idMedico", idMedico);
                            cmdR.ExecuteNonQuery();
                        }
                        string sqlCita = "DELETE FROM Cita WHERE IdMedico = @idMedico";
                        using (var cmdC = new SqlCommand(sqlCita, cn, tx))
                        {
                            cmdC.Parameters.AddWithValue("@idMedico", idMedico);
                            cmdC.ExecuteNonQuery();
                        }
                        string sqlHistorial = "DELETE FROM HistorialClinico WHERE IdMedico = @idMedico";
                        using (var cmdH = new SqlCommand(sqlHistorial, cn, tx))
                        {
                            cmdH.Parameters.AddWithValue("@idMedico", idMedico);
                            cmdH.ExecuteNonQuery();
                        }
                        string sqlMedico = "DELETE FROM Medico WHERE IdMedico = @idMedico";
                        using (var cmdM = new SqlCommand(sqlMedico, cn, tx))
                        {
                            cmdM.Parameters.AddWithValue("@idMedico", idMedico);
                            cmdM.ExecuteNonQuery();
                        }
                        string sqlUsuario = "DELETE FROM Usuario WHERE IdUsuario = @idUsuario";
                        using (var cmdU = new SqlCommand(sqlUsuario, cn, tx))
                        {
                            cmdU.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmdU.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
        public MedicoListado? ObtenerPorId(int idMedico)
        {
            using (var cn = _conexion.CrearConexion())
            {
                cn.Open();
                string sql = @"
                    SELECT m.IdMedico, u.IdUsuario, u.Nombre, u.Apellido, u.Email, m.Especialidad
                    FROM Medico m
                    INNER JOIN Usuario u ON u.IdUsuario = m.IdUsuario
                    WHERE m.IdMedico=@Id;";

                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", idMedico);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read()) return null;
                        return new MedicoListado
                        {
                            IdMedico = dr.GetInt32(0),
                            IdUsuario = dr.GetInt32(1),
                            Nombre = dr.IsDBNull(2) ? "" : dr.GetString(2),
                            Apellido = dr.IsDBNull(3) ? "" : dr.GetString(3),
                            Email = dr.IsDBNull(4) ? "" : dr.GetString(4),
                            Especialidad = dr.IsDBNull(5) ? "" : dr.GetString(5),
                        };
                    }
                }
            }
        }
    }
}
