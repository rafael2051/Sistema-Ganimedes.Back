﻿using Microsoft.Extensions.DependencyInjection;
using Sistema_Ganimedes.Application.Interfaces;
using Sistema_Ganimedes.Application.Services;

namespace Sistema_Ganimedes.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IFormularioService, FormularioService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IParecerService, ParecerService>();

            return services;
        }
    }
}