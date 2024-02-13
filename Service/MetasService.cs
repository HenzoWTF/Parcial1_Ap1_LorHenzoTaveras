using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_LorHenzoTaveras.DAL;
using Parcial1_Ap1_LorHenzoTaveras.Model;
using System.Linq.Expressions;

namespace Parcial1_Ap1_LorHenzoTaveras.Service
{
    public class MetasService
    {
        private readonly Context _contexto;

        public MetasService(Context contexto)
        {
            _contexto = contexto;
        }



        public async Task<bool> Existe(int id)
        {
            return await _contexto.Metas.AnyAsync(a => a.MetaId == id);
        }


        public async Task<bool> DescripcionRepetida(string descipcion)
        {
            return await _contexto.Metas.AnyAsync(a => a.Descripcion == descipcion);
        }

        public async Task<bool> Insertar(MetasFinancieras metas)
        {
            _contexto.Metas.Add(metas);
            return await _contexto.SaveChangesAsync() > 0;
        }


        public async Task<bool> Modificar(MetasFinancieras metas)
        {
            _contexto.Update(metas);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(MetasFinancieras metas)
        {
            if (!await Existe(metas.MetaId) && !await DescripcionRepetida(metas.Descripcion))

                return await Insertar(metas);
            else
                return await Modificar(metas);
        }


        public async Task<MetasFinancieras?> BuscarDescipcion(string descripcion)
        {
            return await _contexto.Metas
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Descripcion == descripcion);
        }


        public async Task<MetasFinancieras?> Buscar(int id)
        {
            return await _contexto.Metas
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.MetaId == id);
        }


        public async Task<bool> Eliminar(MetasFinancieras meta)
        {
            var cantidad = await _contexto.Metas
                .Where(c => c.MetaId == meta.MetaId)
                .ExecuteDeleteAsync();

            return cantidad > 0;
        }

        public async Task<List<MetasFinancieras>> Getist(Expression<Func<MetasFinancieras, bool>> expression)
        {
            return await _contexto.Metas.AsNoTracking().Where(expression).ToListAsync();
        }


    }
}
