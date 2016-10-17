using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using Vendas.Control.Repository;
using Vendas.Model.Core;

namespace Vendas.View
{
    public class Services : MarshalByRefObject, ServicesInterface
    {

        Repository myRep = new Repository();

        #region Services@Cliente
        public Cliente GetBySpecification_Cliente(int codigo)
        {
            try
            {
                return myRep.GetBySpcification<Cliente>(c => c.codigo == codigo).SingleOrDefault();
            }
            catch { throw; }
        }

        public bool AddNew_Cliente(Cliente cli)
        {
            try
            {
                return myRep.Add<Cliente>(cli);
            }
            catch { throw; }
        }

        public bool Update_Cliente(Cliente cli)
        {
            try
            {
                return myRep.Update<Cliente>(cli);
            }
            catch { throw; }
        }

        public bool Delete_Cliente(Cliente cli)
        {
            try
            {
                return myRep.Delete<Cliente>(cli);
            }
            catch { throw; }
        }

        public List<Cliente> GetAll_Cliente()
        {
            try
            {
                return myRep.GetAll<Cliente>().ToList();
            }
            catch { throw; }
        }
        #endregion

        #region Services@Vendedor
        public Vendedor GetBySpecification_Vendedor(int codigo)
        {
            try
            {
                return myRep.GetBySpcification<Vendedor>(c => c.codigo == codigo).SingleOrDefault();
            }
            catch { throw; }
        }

        public bool AddNew_Vendedor(Vendedor vendedor)
        {
            try
            {
                return myRep.Add<Vendedor>(vendedor);
            }
            catch { throw; }
        }

        public bool Update_Vendedor(Vendedor vendedor)
        {
            try
            {
                return myRep.Update<Vendedor>(vendedor);
            }
            catch { throw; }
        }

        public List<Vendedor> GetAll_Vendedor()
        {
            try
            {
                return myRep.GetAll<Vendedor>().ToList();
            }
            catch { throw; }
        }

        public bool Delete_Vendedor(Vendedor vendedor)
        {
            try
            {
                return myRep.Delete<Vendedor>(vendedor);
            }
            catch { throw; }
        }
        #endregion

        #region Services@Produto
        public Produto GetBySpecification_Produto(int codigo)
        {
            try
            {
                return myRep.GetBySpcification<Produto>(c => c.codigo == codigo).SingleOrDefault();
            }
            catch { throw; }
        }

        public bool AddNew_Produto(Produto prod)
        {
            try
            {
                return myRep.Add<Produto>(prod);
            }
            catch { throw; }
        }

        public bool Update_Produto(Produto prod)
        {
            try
            {
                return myRep.Update<Produto>(prod);
            }
            catch { throw; }
        }

        public List<Produto> GetAll_Produto()
        {
            try
            {
                return myRep.GetAll<Produto>().ToList();
            }
            catch { throw; }
        }

        public bool Delete_Produto(Produto prod)
        {
            try
            {
                return myRep.Delete<Produto>(prod);
            }
            catch { throw; }
        }
        #endregion

        #region Services@Venda
        public Venda GetBySpecification_Venda(int codigo)
        {
            try
            {
                return myRep.GetBySpcification<Venda>(c => c.codigo == codigo).SingleOrDefault();
            }
            catch { throw; }
        }

        public bool AddNew_Venda(Venda vend)
        {
            try
            {
                return myRep.Add<Venda>(vend);
            }
            //catch { throw; }
            catch (DbEntityValidationException e)
            {
                foreach (var even in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation erros:", even.Entry.Entity.GetType().Name, even.Entry.State);
                    foreach (var ve in even.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\" ", ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public bool Update_Venda(Venda vend)
        {
            try
            {
                return myRep.Update<Venda>(vend);
            }
            catch { throw; }
        }

        public List<Venda> GetAll_Venda()
        {
            try
            {
                return myRep.GetAll<Venda>().ToList();
            }
            catch { throw; }
        }

        public bool Delete_Venda(Venda vend)
        {
            try
            {
                return myRep.Delete<Venda>(vend);
            }
            catch { throw; }
        }
        #endregion

        #region Services@Venda_Itens
        public bool AddNew_VendaItens(Venda_Itens vend_it)
        {
            try
            {
                return myRep.Add<Venda_Itens>(vend_it);
            }
            catch { throw; }
        }

        public bool Delete_VendaItens(Venda_Itens ent)
        {
            try
            {
                return myRep.Delete<Venda_Itens>(ent);
            }
            catch { throw; }
        }

        public List<Venda_Itens> GetAll_VendaItens()
        {
            try
            {
                return myRep.GetAll<Venda_Itens>().ToList();
            }
            catch { throw; }
        }
        #endregion

        public void ExecuteComand(string query)
        {
            try
            {
                myRep.ExecuteCommand(query);
            }
            catch { throw; }
        }

        public DataSet GetDataSet(string query)
        {
            try
            {
                return myRep.GetDataSet(query);
            }
            catch { throw; }
        }
    }
}

