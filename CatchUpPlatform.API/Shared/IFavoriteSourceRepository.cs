using CatchUpPlatform.API.News.Domain.Model.Aggregate;
using CatchUpPlatform.API.News.Domain.Model.ValueObjects;
using CatchUpPlatform.API.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.Shared;

public interface IFavoriteSourceRepository : IBaseRepository<FavoriteSource>
{
    Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(NewsApiKey newsApiKey, CancellationToken cancellationToken = default);
    Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(NewsApiKey newsApiKey, SourceId sourceId, CancellationToken cancellationToken = default);
    
}