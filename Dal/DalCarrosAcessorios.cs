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
    public class DalCarrosAcessorios
    {
        private string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString;

		public IEnumerable<CarrosAcessorios> ListaTodos()
		{
			using (IDbConnection connection = new SqlConnection(connectionstring))
			using (IDbCommand command = connection.CreateCommand())
			{
				try
				{
					command.CommandText =   "SELECT  TbCarro.IdCarro, TbCarro.Nome AS Carro, " +
											"	     TbAcessorios.IdAcessorios, TbAcessorios.Nome AS Acessorio, "+
											"		 TbCarrosAcessorios.IdCarrosAcessorios    " +
											"FROM    TbCarro INNER JOIN  " +
											"		 TbCarrosAcessorios ON TbCarro.IdCarro = TbCarrosAcessorios.IdCarro INNER JOIN  " +
											"		 TbAcessorios ON TbCarrosAcessorios.IdAcessorios = TbAcessorios.IdAcessorios";

					connection.Open();
					IDataReader dr = command.ExecuteReader();

					List<CarrosAcessorios> listCarrosAcessorios = new List<CarrosAcessorios>();

					while (dr.Read())
					{
						var carrosAcessorios = new CarrosAcessorios();

						carrosAcessorios.IdCarrosAcessorios = Convert.ToInt32(dr["IdCarrosAcessorios"]); 
						carrosAcessorios.Carro.IdCarro = Convert.ToInt32(dr["IdCarro"]);
						carrosAcessorios.Carro.Nome = dr["Carro"].ToString();
						carrosAcessorios.Acessorio.IdAcessorios = Convert.ToInt32(dr["IdAcessorios"]);
						carrosAcessorios.Acessorio.Nome = dr["Acessorio"].ToString();

						listCarrosAcessorios.Add(carrosAcessorios);
					}

					//var listCarrosEAcessorios = new List<Carros>();

					//var carroAcessorio = new Carros();

					//foreach (var item in listCarrosAcessorios)
     //               {
					//	if (carroAcessorio.IdCarro == item.IdCarro)
					//	{
					//		foreach (var itemAcessorio in item.ListaAcessorios)
					//		{
					//			carroAcessorio.ListaAcessorios.Add(itemAcessorio);
					//		}
					//	}
     //                   else
     //                   {
					//		carroAcessorio = new Carros();
					//		carroAcessorio.IdCarro = item.IdCarro;
					//		carroAcessorio.Nome = item.Nome;

					//		foreach (var itemAcessorio in item.ListaAcessorios)
					//		{
					//			if (carroAcessorio.IdCarro == item.IdCarro)
     //                           {
					//				carroAcessorio.ListaAcessorios.Add(itemAcessorio);
					//			}
									
					//		}

					//		listCarrosEAcessorios.Add(carroAcessorio);
					//	}						
					//}

					connection.Close();

					return listCarrosAcessorios;
				}
				catch (Exception ex)
				{
					connection.Close();
					throw ex;
				}
			}
		}

	}
}