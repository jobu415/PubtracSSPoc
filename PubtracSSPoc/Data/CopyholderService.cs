using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PubtracSSPoc.Data
{
    public class CopyholderService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public CopyholderService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Copyholders
        public async Task<List<Copyholder>> GetAllCopyholdersAsync()
        {
            return await _appDBContext.Copyholders.ToListAsync();
        }
        #endregion

        #region Insert Copyholder
        public async Task<bool> InsertCopyholderAsync(Copyholder copyholder)
        {
            await _appDBContext.Copyholders.AddAsync(copyholder);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Copyholder by Id
        public async Task<Copyholder> GetCopyholderAsync(int Id)
        {
            Copyholder copyholder = await _appDBContext.Copyholders.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return copyholder;
        }
        #endregion

        #region Update Copyholder
        public async Task<bool> UpdateCopyholderAsync(Copyholder copyholder)
        {
            _appDBContext.Copyholders.Update(copyholder);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteCopyholder
        public async Task<bool> DeleteCopyholderAsync(Copyholder copyholder)
        {
            _appDBContext.Remove(copyholder);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
