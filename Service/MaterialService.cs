using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface IMaterialService
    {
        bool Add(Material model);
        bool Update(Material model);
        IEnumerable<Material> ListarTodo();
        Material Listar(int id);
    }
    public class MaterialService : IMaterialService
    {
        private readonly SiguesCoreDbContext _dbContext;
        public MaterialService(SiguesCoreDbContext materialDbContext)
        {
            _dbContext = materialDbContext;
        }
        public bool Add(Material model)
        {
            try
            {
                _dbContext.Add(model);
                _dbContext.SaveChanges();
            }
            catch(System.Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Update(Material model)
        {
            try
            {
                var originalModel = _dbContext.Material.Single(x => x.MaterialID == model.MaterialID);
                originalModel.Clave = model.Clave;
                originalModel.Descripcion = model.Descripcion;
                originalModel.Dimensiones = model.Dimensiones;
                originalModel.UnidadMedida = model.UnidadMedida;
                originalModel.Existencia = model.Existencia;

                _dbContext.Update(originalModel);
                _dbContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Material> ListarTodo()
        {
            var result = new List<Material>();
            try
            {
                result = _dbContext.Material.ToList();
            }
            catch (System.Exception ex)
            {
                
            }
            return result;
        }
        public Material Listar(int id)
        {
            var result = new Material();
            try
            {
                result = _dbContext.Material.Single(x => x.MaterialID == id);
            }
            catch (System.Exception ex)
            {

            }
            return result;
        }
    }
}
