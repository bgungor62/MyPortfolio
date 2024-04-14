using MyPortfolio.CQRSPattern.Result.SkillsResult;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.CQRSPattern.Handlers.SkillsHandlers
{
    public class GetSkillsQueryHandler
    {
        private readonly Context _context;
        public GetSkillsQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetSkillsQueryResult> Handle()
        {
            var values = _context.Skills.Select(x => new GetSkillsQueryResult
            {
                Title = x.Title,
                Value = x.Value,
            }).ToList();
            return values;
        }
    }
}
