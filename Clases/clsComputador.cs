using ComputadoresITM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ComputadoresITM.Clases
{
	public class clsComputador
	{

		private ITM_ComputadoresEntities dbPC = new ITM_ComputadoresEntities();

		public Computador computador { get; set; }

		public string Insertar()
		{
			try
			{
				dbPC.Computadors.Add(computador);
				dbPC.SaveChanges();
				return "computador ingresado correctamente";

			}
			catch (Exception ex)
			{
				return "Error al ingresar el computador" + ex.Message;
			}
		}

		public Computador ConsultarXCodigo( int Codigo)
		{
			return dbPC.Computadors.FirstOrDefault(c => c.IDComputador == Codigo);
				
		}

		public string Actualizar()
		{
			try
			{
				Computador comp = ConsultarXCodigo(computador.IDComputador);
				if (comp == null)
				{
					return "El computador no existe, no se puede actualizar";
				}
				dbPC.Computadors.AddOrUpdate(computador);
				dbPC.SaveChanges();
				return "se actualizo el computador correctamente";
		    }
			catch(Exception ex)
			{
				return "No se puede actualizar el computador" + ex.Message;
			}
		}

		public List<Computador> ConsultarTodos()
		{
			return dbPC.Computadors
				.OrderBy(c => c.IDComputador)
				.ToList();
		}

		public string Eliminar()
		{
			try
			{
				Computador comp = ConsultarXCodigo(computador.IDComputador);
				if (comp == null)
				{
					return "El computador no existe en la base de datos";
				}
				dbPC.Computadors.Remove(comp);
				dbPC.SaveChanges();
				return "Computador eliminado correctamente";

			}
			catch(Exception ex)
			{
				return "error al eliminar prodcto " + ex.Message;
			}
		}

    }
}