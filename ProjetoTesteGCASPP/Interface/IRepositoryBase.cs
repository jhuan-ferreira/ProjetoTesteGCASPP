using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteGCASPP.Interface
{
    public interface IRepositoryBase<T>  where T : class
    {
        /// <summary>
        /// Insere um objeto
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Insert(T data);
        /// <summary>
        /// atualiza um objeto
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update(T data);
        /// <summary>
        /// deleta um objeto pelo id
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Delete(T data);
        /// <summary>
        /// Retorna tudo
        /// </summary>
        /// <returns></returns>
        IList<T> FindAll();
        /// <summary>
        /// Salva
        /// </summary>
        /// 
        T Get(int id);
        void Commit();

        void Dispose();

    }
}
