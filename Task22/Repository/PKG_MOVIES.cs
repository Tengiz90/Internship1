using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task22.Models;

namespace Task22.Packages
{
    internal class PKG_MOVIES : PKG_BASE
    {
        public void save_movie(Movie movie)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = ConnStr;

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "olerning.PK_MOVIES.save_movie";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("v_name", OracleDbType.Varchar2).Value = movie.Name;
                cmd.Parameters.Add("v_release_date", OracleDbType.Date).Value = movie.ReleaseDate;

                cmd.ExecuteNonQuery();

            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            finally
            {
                conn.Close();
            }

        }
        public bool update_movie(int id, Movie movie)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = ConnStr;

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "olerning.PK_MOVIES.update_movie";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("v_name", OracleDbType.Varchar2).Value = movie.Name;
                cmd.Parameters.Add("v_release_date", OracleDbType.Date).Value = movie.ReleaseDate;

                int affectedRowsCounnt = cmd.ExecuteNonQuery();
                return affectedRowsCounnt > 0;

            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            finally
            {
                conn.Close();
            }
            return false;

        }
        public Movie GetMovieById(int id) {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = ConnStr;

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "olerning.PK_MOVIES.get_movie_by_id";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("v_result", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Movie movie = new Movie();
                    //movie.Id = int.Parse(reader["ID"].ToString());
                    //movie.Name = reader["NAME"].ToString();
                    //movie.ReleaseDate = DateTime.Parse(reader["RELEASE_DATE"].ToString());
                    movie.Id = reader.GetInt32(0);
                    movie.Name = reader.GetString(1);
                    movie.ReleaseDate = reader.GetDateTime(2);
                    return movie;

                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            finally
            {
                conn.Close();
            }

            return null;

        }
        public bool DeleteMovie(int id)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = ConnStr;

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "olerning.PK_MOVIES.delete_movie";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            finally
            {
                conn.Close();
            }
            return false;
        }
    }

}
