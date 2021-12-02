using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula301121ADO
{
    public class Programadores
    {
        private readonly Banco banco;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Linguagem { get; set; }
        public string Banco { get; set; }


        public bool GravarProgramador()
        {
            Banco bd = new();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = $"insert into programadores values(@Nome, @Linguagem, @Banco)";
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Linguagem", SqlDbType.VarChar);
            command.Parameters.Add("@Banco", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Linguagem;
            command.Parameters[2].Value = Banco;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch(Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public bool ExcluirProgramador()
        {
            Banco bd = new();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from programadores where id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters[0].Value = Id;

            try 
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally 
            {
                bd.FecharConexao();
            }
        }

        public bool AtualizarProgramador()
        {
            Banco bd = new();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandText = "update programadores set nome = @nome, linguagem = @linguagem, banco = @banco where id = @id";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@linguagem", SqlDbType.VarChar);
            cmd.Parameters.Add("@banco", SqlDbType.VarChar);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = Nome;
            cmd.Parameters[1].Value = Linguagem;
            cmd.Parameters[2].Value = Banco;
            cmd.Parameters[3].Value = Id;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch(Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public Programadores ConsultaProgramador(int id)
        {
            Banco bd = new();
            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new("select * from programadores", cn);

                SqlDataReader rdr = command.ExecuteReader();

                while(rdr.Read())
                {
                    if (rdr.GetInt32(0) == id)
                    {
                        Id = rdr.GetInt32(0);
                        Nome = rdr.GetString(1);
                        Linguagem = rdr.GetString(2);
                        Banco = rdr.GetString(3);

                        return this;
                    }

                }

                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
