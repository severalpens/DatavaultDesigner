using DatavaultDesignerStar.Models;
using DatavaultDesignerStar.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DatavaultDesignerStar.Data
{
    public class KeyMappingService
    {
        public List<Release?> Releases = new List<Release?>();
        public List<ReleaseTblCol> ReleaseTblCols = new List<ReleaseTblCol>();
        public List<ColType> ColTypes = new List<ColType>();
        public List<Tbl?> Tbls = new List<Tbl?>();
        public List<ReleaseTblCol> FilteredRTCs = new List<ReleaseTblCol>();
        public string SaveText { get; set; } = "Save";
        private int releaseId;
        public int ReleaseId
        {
            get { return releaseId; }
            set
            {
                releaseId = value;

                //Release = Releases.Where(x => x.ReleaseId == value).FirstOrDefault();

                UpdateFilters();


            }
        }

        private Release release;
        public Release Release
        {
            get { return release; }
            set
            {
                release = value;

                //Tbls = DbContext.ReleaseTblCols
                //    .Where(x => x.ReleaseId == value.ReleaseId)
                //    .Select(x => x.Tbl)
                //    .Distinct()
                //    .ToList();



            }
        }



        private int tblId;
        public int TblId
        {
            get { return tblId; }
            set
            {
                tblId = value;

                //Tbl = Tbls.Where(x => x.TblId == value).FirstOrDefault();
                UpdateFilters();



            }
        }
        private Tbl tbl;
        public Tbl Tbl
        {
            get { return tbl; }
            set
            {
                tbl = value;

            }
        }


        //---------------------------------------------------------------------------------------------------
        //ON INITIALIZED-------------------------------------------------------------------------------------


        public DatavaultDesignerStarDbContext DbContext { get; set; }
        public KeyMappingService(DatavaultDesignerStarDbContext dbContext)
        {
            DbContext = dbContext;
            UpdateFilters();


        }

        public void UpdateFilters()
        {
            ColTypes = DbContext.ColTypes.ToList();
            Releases = DbContext.Releases.Where(x => x.IsActive).ToList();
            Release = Releases.FirstOrDefault();
            ReleaseTblCols = DbContext.ReleaseTblCols.ToList();

            Tbls = DbContext.ReleaseTblCols
                  .Where(x => x.ReleaseId == ReleaseId)
                  .Select(x => x.Tbl)
                  .Distinct()
                  .ToList();

            Tbl = Tbls.FirstOrDefault();

            FilteredRTCs = DbContext.ReleaseTblCols
                .Where(x => x.TblId == TblId)
                .Where(x => x.CandidateField == true)
                .OrderBy(x => x.OrderId).ToList();
        }



        public async Task Save()
        {
            
            DbContext.UpdateRange(ReleaseTblCols);
            await DbContext.SaveChangesAsync();
            UpdateFilters();


        }

    }

}
