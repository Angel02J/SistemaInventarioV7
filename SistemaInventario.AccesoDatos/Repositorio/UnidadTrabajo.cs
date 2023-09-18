using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.AccesoDatos.Repositorio.IRespositorio;
using SistemaInventario.AccesoDatos.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;

        public IBodega Bodega { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Bodega = new BodegaRespositorio(_db);
        }



        public IBodega bodega => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Gaurdar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
