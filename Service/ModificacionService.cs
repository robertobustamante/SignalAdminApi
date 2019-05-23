using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface IModificacionService
    {
        bool Add(Modificacion model);
        bool Update(Modificacion model);
        Modificacion Listar(int id);
    }
    public class ModificacionService : IModificacionService
    {
        private readonly SiguesCoreDbContext _dbContext;
        public ModificacionService(SiguesCoreDbContext modificacionDbContext)
        {
            _dbContext = modificacionDbContext;
        }
        public bool Add(Modificacion model)
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

        public Modificacion Listar(int id)
        {
            var result = new Modificacion();
            try
            {
                result = _dbContext.Modificacion.Single(x => x.ModificacionID == id);
            }
            catch(System.Exception ex) { }
            return result;
        }

        public bool Update(Modificacion model)
        {
            try
            {
                var originalModel = _dbContext.Modificacion.Single(x => x.ModificacionID == model.ModificacionID);
                originalModel.CreadoPor = model.CreadoPor;
                originalModel.FechaCreacion = model.FechaCreacion;
                originalModel.ModificadoPor = model.ModificadoPor;
                originalModel.FechaModificacion = model.FechaModificacion;
                originalModel.EliminadoPor = model.EliminadoPor;
                originalModel.FechaEliminacion = model.FechaEliminacion;
                originalModel.Activo = model.Activo;

                _dbContext.Update(originalModel);
                _dbContext.SaveChanges();
            }
            catch(System.Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
