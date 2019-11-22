﻿using System.Threading.Tasks;
using AspNetCore.ApiGateway;
using Microsoft.AspNetCore.Http;

namespace ApiGateway.API
{
    public interface IWeatherService
    {
        HttpClientConfig GetClient();
        Task<object> GetTypes(ApiInfo apiInfo, RouteInfo routeInfo, HttpRequest request);
    }
}