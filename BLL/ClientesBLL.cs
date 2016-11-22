using Entidades;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Insertar (Clientes nuevo)
        {
            bool retorno = false;
            using (var db = new Parcial2Db())
            {
                try
                {
                    db.Cliente.Add(nuevo);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }                
        }

        public static Clientes Buscar(int clienteId)
        {
            var cliente = new Clientes();
            using (var db = new Parcial2Db())
            {
                try
                {
                    cliente = db.Cliente.Find(clienteId);
                    cliente.TipoTelefono.Count();           
                }
                catch (Exception)
                {
                    throw;
                }
                return cliente;
            }
        }

        public static Clientes Eliminar(int id)
        {            
            var cliente = new Clientes();
            using (var db = new Parcial2Db())
            {
                try
                {
                    cliente = db.Cliente.Find(id);
                    db.Cliente.Remove(cliente);
                    db.SaveChanges();                    
                }
                catch (Exception)
                {
                    throw;
                }
                return cliente;
            }
        }

        public static List<Clientes> Getlist()
        {
            var lista = new List<Clientes>();
            using (var db = new Parcial2Db())
            {
                try
                {
                    lista = db.Cliente.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                return lista;
            }
        }

        public static List<Clientes> Getlist(List<ClientesTelefonos> ct)
        {
            var lista = new List<Clientes>();
            using (var db = new Parcial2Db())
            {
                try
                {
                    foreach (var Cliente in ct)
                    {
                        lista.Add(db.Cliente.Find(Cliente.ClientesId));
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return lista;
            }
        }
    }
}
