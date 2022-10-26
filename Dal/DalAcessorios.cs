using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAutoCar.Models;

namespace WebAutoCar.Dal
{
    public class DalAcessorios
    {
		private string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString;

		public List<Acessorios> ListaTodos()
		{
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
			{
				try
				{
					command.CommandText = "select * from TbAcessorios";

					connection.Open();
					IDataReader dr = command.ExecuteReader();

					List<Acessorios> listAcessorios = new List<Acessorios>();
					while (dr.Read())
					{
						Acessorios acessorios = new Acessorios() 
						{
							IdAcessorios = Convert.ToInt32(dr["IdAcessorios"]),
							Nome = dr["Nome"].ToString()
						};
							
						listAcessorios.Add(acessorios);
					}

					connection.Close();

					return listAcessorios;
				}
				catch (Exception ex)
				{
					connection.Close();
					throw ex;
				}
			}
		}

        public int Salvar(Acessorios acessorios)
		{
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
				try
				{
					command.CommandText = "insert into TbAcessorios (Nome) values ('" + acessorios.Nome + "')";

					connection.Open();
					return command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					connection.Close();
					throw ex;
				}

		}
		public int Excluir(int id)
		{
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
				try
				{
					command.CommandText = "Delete from TbAcessorios where IdAcessorios =" + id.ToString();

					connection.Open();
					return command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					connection.Close();
					throw;
				}
		}
        public int Editar(Acessorios acessorios)
		{
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
				try
				{
					command.CommandText = "Update TbAcessorios set Nome = '" + acessorios.Nome + "'" +
											  "where IdAcessorios =" + acessorios.IdAcessorios.ToString();

					connection.Open();
					return command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					connection.Close();
					throw;
				}
		}
	}
}