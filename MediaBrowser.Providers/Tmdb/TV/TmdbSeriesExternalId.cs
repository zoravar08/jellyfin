using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Providers;

namespace MediaBrowser.Providers.Tmdb.TV
{
    public class TmdbSeriesExternalId : IExternalId
    {
        /// <inheritdoc />
        public string Name => TmdbUtils.ProviderName;

        /// <inheritdoc />
        public string Key => MetadataProviders.Tmdb.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType Type => ExternalIdMediaType.Series;

        /// <inheritdoc />
        public string UrlFormatString => TmdbUtils.BaseTmdbUrl + "tv/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item)
        {
            return item is Series;
        }
    }
}
