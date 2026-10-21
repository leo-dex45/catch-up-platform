using CatchUpPlatform.API.News.Application.Services;
using CatchUpPlatform.API.News.Domain.Model.Aggregate;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.Shared;

namespace CatchUpPlatform.API.News.Application.Internal.QueryService;

public class FavoriteSourceQueryService(IFavoriteSourceRepository favoriteSourceRepository) : IFavoriteSourceQueryService
{
    public async Task<IEnumerable<FavoriteSource>> Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query, CancellationToken cancellationToken = default)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAsync(query.NewsApiKey, cancellationToken);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query, CancellationToken cancellationToken = default)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(query.NewsApiKey, query.SourceId, cancellationToken);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query, CancellationToken cancellationToken = default)
    {
        return await favoriteSourceRepository.FindByIdAsync(query.Id, cancellationToken);
    }
}