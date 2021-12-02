using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula301121ADO
{
    /*create table Programadores(
        Id int not null identity primary key,
        Nome varchar(50) not null,
        Linguagem varchar(10),
        Banco varchar(10)
      )

      select * from programadores

      create login usuario with password='senha';
      create user usuario from login usuario;
      exec sp_addrolemember 'DB_DATAREADER', 'usuario';
      exec sp_addrolemember 'DB_DATAWRITER', 'usuario';
    */
    public class Banco
    {
        private string ConnectionString = "Data Source=DESKTOP-R9JFMSC\\SQLEXPRESS; Initial Catalog=AdoNet;User ID=usuario; password=senha";
        // "Integrated Security = SSPI;Persist Security Info=False;Initial Catalog=EstudoDDD;Data Source=DESKTOP-R9JFMSC\\SQLEXPRESS"
        private SqlConnection cn;

        private void Conexao() // Vincula a string com o cn e inicia o sqlconnection
        {
            cn = new SqlConnection(ConnectionString);
        }

        public SqlConnection AbrirConexao()
        {
            try 
            {
                Conexao();
                cn.Open();
                return cn;
            }
            catch(Exception e) 
            {
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch(Exception ex)
            {
                return;
            }
        }

        public DataTable ExecutarConsultaGenerica(string sql)
        {
            try
            {
                AbrirConexao();

                SqlCommand command = new(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new(command);

                DataTable dt = new();
                adapter.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
