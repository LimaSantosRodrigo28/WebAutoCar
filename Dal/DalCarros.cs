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
	public class DalCarros
	{
		private string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString;

		public List<Carros> ListaTodos()
		{
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
			{
				try
				{
					command.CommandText = "select * from TbCarro";

					connection.Open();
					IDataReader dr = command.ExecuteReader();

					List<Carros> listCarros = new List<Carros>();
					while (dr.Read())
					{
						Carros carro = new Carros();
						carro.IdCarro = Convert.ToInt32(dr["IdCarro"]);
						carro.Nome = dr["Nome"].ToString();

						listCarros.Add(carro);
					}

					connection.Close();

					return listCarros;
				}
				catch (Exception ex)
				{
					connection.Close();
					throw ex;
				}
			}
		}

		public int Salvar(Carros carro)
		{
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
			try
			{
					command.CommandText = "insert into TbCarro (Nome) values ('"+carro.Nome+"')";

					connection.Open();
					return command.ExecuteNonQuery();
				}
			catch (Exception ex)
			{
				connection.Close();
				throw;
			}

		}
		public int Excluir (int id)
        {
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
				try
				{
					command.CommandText = "Delete from TbCarro where IdCarro =" + id.ToString() ;

					connection.Open();
					return command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					connection.Close();
					throw;
				}
		}
		public int Editar(Carros carro)
        {
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
			try
			{
				command.CommandText = "Update TbCarro set Nome = '" + carro.Nome + "'" +
										  "where IdCarro =" + carro.IdCarro.ToString();

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