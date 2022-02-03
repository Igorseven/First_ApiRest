using System.Collections.Generic;

namespace SaveCars.ApplicationService.Response
{
    public class SearchResponse<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Entities { get; set; }
        public int TotalEntities { get; set; }
    }
}
