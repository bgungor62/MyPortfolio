using MyPortfolio.CQRSPattern.Result.ExperienceResult;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.CQRSPattern.Handlers.ExperienceHandlers
{
    public class GetExperienceQueryHandler
    {
        private readonly Context _context;

        public GetExperienceQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetExperienceQueryResult> Handle()
        {
            var values = _context.Experiences.Select(x => new GetExperienceQueryResult
            {
                Head = x.Head,
                Title = x.Title,
                Date = x.Date,
                Description = x.Description,
            }).ToList();
            return values;
        }
    }
}
