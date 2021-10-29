using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PubtracSSPoc.Data
{
    public class ManualToCopyHolderService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ManualToCopyHolderService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of ManualToCopyHolders
        public async Task<List<ManualToCopyHolder>> GetAllManualToCopyHoldersAsync()
        {
            return await _appDBContext.ManualToCopyHolders.ToListAsync();
        }

        public async Task<List<ManualToCopyHolder>> GetAllManualsForCopyHoldersAsync(string userId)
        {
            List<ManualToCopyHolder> returnList = new List<ManualToCopyHolder>();

            if (_appDBContext.ManualToCopyHolders != null && _appDBContext.ManualToCopyHolders.ToList().Count > 0)
            {

                returnList = await _appDBContext.ManualToCopyHolders.Where(x => x.Copyholder.UserId.Equals(userId)).ToListAsync();
            }
            return returnList;
        }
        #endregion

        #region Insert ManualToCopyHolder
        public async Task<bool> InsertManualToCopyHolderAsync(ManualToCopyHolder manual)
        {
            await _appDBContext.ManualToCopyHolders.AddAsync(manual);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get ManualToCopyHolder by Id
        public async Task<ManualToCopyHolder> GetManualToCopyHolderAsync(int Id)
        {
            ManualToCopyHolder manual = await _appDBContext.ManualToCopyHolders.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return manual;
        }
        #endregion

        #region Update ManualToCopyHolder
        public async Task<bool> UpdateManualToCopyHolderAsync(ManualToCopyHolder manual)
        {
            _appDBContext.ManualToCopyHolders.Update(manual);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteManualToCopyHolder
        public async Task<bool> DeleteManualToCopyHolderAsync(ManualToCopyHolder manual)
        {
            _appDBContext.Remove(manual);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
