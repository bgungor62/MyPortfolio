using MyPortfolio.CQRSPattern.Result.AboutResult;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.CQRSPattern.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly Context _context;

        public GetAboutQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAboutQueryResult> Handle()
        {
            var values = _context.Abouts.Select(x => new GetAboutQueryResult
            {
                Title = x.Title,
                SubDescription = x.SubDescription,
                Details = x.Details,
            }).ToList();
            return values;
        }
    }
}
