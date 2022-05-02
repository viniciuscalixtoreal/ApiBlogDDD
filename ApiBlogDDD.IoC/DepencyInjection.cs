using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Application.Services;
using ApiBlogDDD.Application.Services.Services;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using ApiBlogDDD.Domain.Services.Services;
using ApiBlogDDD.Infra.Data.Repository.Dapper;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBlogDDD.IoC
{
    public static class DepencyInjection
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterRepositories(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            // DEPENDENCY INJECT APP SERVICE
            //services.AddScoped<IAddressAppService, AddressAppService>();
            services.AddScoped<IAlbumAppService, AlbumAppService>();
            services.AddScoped<ICommentsAppService, CommentsAppService>();
            //services.AddScoped<ICompanyAppService, CompanyAppService>();
            //services.AddScoped<IGeoAppService, GeoAppService>();
            services.AddScoped<IPhotosAppService, PhotosAppService>();
            services.AddScoped<IPostAppService, PostAppService>();
            services.AddScoped<IUserAppService, UserAppService>();

            // DEPENDENCY INJECT SERVICE
            //services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAlbumService, AlbumsService>();
            services.AddScoped<ICommentsService, CommentsService>();
            //services.AddScoped<ICompanyService, CompanyService>();
            //services.AddScoped<IGeoService, GeoService>();
            services.AddScoped<IPhotosService, PhotosService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();


            // DEPENDENCY INJECT REPOSITORY
            services.AddScoped<IAddressRepositoryDapper, AddressRepositoryDapper>();
            services.AddScoped<IAlbumRepositoryDapper, AlbumRepositoryDapper>();
            services.AddScoped<IAuthenticateRepositoryDapper, AuthenticateRepositoryDapper>();
            services.AddScoped<ICommentsRepositoryDapper, CommentsRepositoryDapper>();
            services.AddScoped<ICompanyRepositoryDapper, CompanyRepositoryDapper>();
            services.AddScoped<IGeoRepositoryDapper, GeoRepositoryDapper>();
            services.AddScoped<IPhotosRepositoryDapper, PhotoRepositoryDapper>();
            services.AddScoped<IPostRepositoryDapper, PostRepositoryDapper>();
            services.AddScoped<IUserRepositoryDapper, UserRepositoryDapper>();
            
        }
    }
}
