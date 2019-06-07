using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface ICableadoService
    {
        bool Add(Cableado model, int usrId);
        bool Update(Cableado model, int usrId);
        IEnumerable<Cableado> ListarTodo();
        Cableado Listar(int id);
        bool Delete(int id, int usrId);
    }
    public class CableadoService : ICableadoService
    {
        private readonly SiguesCoreDbContext _dbContext;
        public CableadoService(SiguesCoreDbContext cableadoDbContext)
        {
            _dbContext = cableadoDbContext;
        }
        public bool Add(Cableado model, int usrId)
        {
            try
            {
                var mod = new Modificacion();
                mod.CreadoPor = usrId;
                mod.FechaCreacion = System.DateTime.UtcNow;
                mod.Eliminado = false;

                model.Modificacion = mod;
                
                _dbContext.Add(model);
                _dbContext.SaveChanges();
            }
            catch(System.Exception ex)
            {
                return false;
            }
            return true;
        }
        
                
        public Cableado Listar(int id)
        {
            var result = new Cableado();
            try
            {
                result = _dbContext.Cableado.Single(x => x.CableadoID == id && x.Modificacion.Eliminado == false);
            }
            catch (System.Exception ex)
            {

            }
            return result;
        }

        public IEnumerable<Cableado> ListarTodo()
        {
            var result = new List<Cableado>();
            try
            {
                result = _dbContext.Cableado.Where( c => c.Modificacion.Eliminado == false).ToList();
            }
            catch(System.Exception ex)
            {

            }
            return result;
        }

        public bool Update(Cableado model, int usrId)
        {
            try
            {
                var originalModel = _dbContext.Cableado.Single(x => x.CableadoID == model.CableadoID);
                var modif = _dbContext.Modificacion.Single(x => x.ModificacionID == originalModel.ModificacionID);
                originalModel.Descripcion = model.Descripcion;
                originalModel.NumParte = model.NumParte;

                modif.ModificadoPor = usrId;
                modif.FechaModificacion = System.DateTime.UtcNow;

                _dbContext.Update(originalModel);
                _dbContext.Update(modif);
                _dbContext.SaveChanges();
            }
            catch(System.Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Delete(int id, int usrId)
        {
            try
            {
                var cableado = _dbContext.Cableado.Single(x => x.CableadoID == id);
                var modif = _dbContext.Modificacion.Single(x => x.ModificacionID == cableado.ModificacionID);
                modif.EliminadoPor = usrId;
                modif.FechaEliminacion = System.DateTime.UtcNow;
                modif.Eliminado = true;

                _dbContext.Update(modif);
                _dbContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
