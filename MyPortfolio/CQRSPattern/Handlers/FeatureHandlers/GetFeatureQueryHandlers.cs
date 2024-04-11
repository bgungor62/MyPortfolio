using MyPortfolio.CQRSPattern.Result.FeatureResult;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.CQRSPattern.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandlers
    {
        private readonly Context _context;

        public GetFeatureQueryHandlers(Context context)
        {
            _context = context;
        }
        public List<GetFeatureQueryResult> Handle()
        {
            var values = _context.Features.Select(x => new GetFeatureQueryResult
            {
                Title = x.Title,
                Description = x.Description,
            }).ToList();
            return values;
        }
    }
}
