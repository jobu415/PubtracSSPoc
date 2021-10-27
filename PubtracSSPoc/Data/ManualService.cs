using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PubtracSSPoc.Data
{
    public class ManualService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ManualService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Manuals
        public async Task<List<Manuals>> GetAllManualsAsync()
        {
            return await _appDBContext.Manuals.ToListAsync();
        }
        #endregion

        #region Insert Manual
        public async Task<bool> InsertManualAsync(Manuals manual)
        {
            await _appDBContext.Manuals.AddAsync(manual);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Manual by Id
        public async Task<Manuals> GetManualAsync(int Id)
        {
            Manuals manual = await _appDBContext.Manuals.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return manual;
        }
        #endregion

        #region Update Manual
        public async Task<bool> UpdateManualAsync(Manuals manual)
        {
            _appDBContext.Manuals.Update(manual);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteManual
        public async Task<bool> DeleteManualAsync(Manuals manual)
        {
            _appDBContext.Remove(manual);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
