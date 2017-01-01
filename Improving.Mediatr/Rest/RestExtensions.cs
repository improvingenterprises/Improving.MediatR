﻿namespace Improving.MediatR.Rest
{
    using System;
    using System.Threading.Tasks;
    using global::MediatR;
    using Get;
    using Post;
    using Put;
    using Delete;

    public static class RestExtensions
    {
        public static async Task<TResponse> GetAsync<TResponse>(
            this IMediator mediator,
            Action<GetRequest<Unit, TResponse>> configure = null)
        {
            var request = new GetRequest<Unit, TResponse>();
            configure?.Invoke(request);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> GetAsync<TResponse>(
            this IMediator mediator, string resourceUri, params object[] args)
        {
            var request = new GetRequest<Unit, TResponse>();
            request.SetResourceUri(resourceUri, args);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> GetAsync<TRequest, TResponse>(
            this IMediator mediator, TRequest resource,
            Action<GetRequest<TRequest, TResponse>> configure = null)
            where TRequest : class
        {
            var request = new GetRequest<TRequest, TResponse>(resource);
            configure?.Invoke(request);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> GetAsync<TRequest, TResponse>(
            this IMediator mediator, TRequest resource, string resourceUri, params object[] args)
            where TRequest : class
        {
            var request = new GetRequest<TRequest, TResponse>(resource);
            request.SetResourceUri(resourceUri, args);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> PostAsync<TRequest, TResponse>(
            this IMediator mediator, TRequest resource,
            Action<PostRequest<TRequest, TResponse>> configure = null)
            where TRequest : class
        {
            var request = new PostRequest<TRequest, TResponse>(resource);
            configure?.Invoke(request);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> PostAsync<TRequest, TResponse>(
            this IMediator mediator, TRequest resource, string resourceUri, params object[] args)
            where TRequest : class
        {
            var request = new PostRequest<TRequest, TResponse>(resource);
            request.SetResourceUri(resourceUri, args);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> PutAsync<TRequest, TResponse>(
             this IMediator mediator, TRequest resource,
             Action<PutRequest<TRequest, TResponse>> configure = null)
             where TRequest : class
        {
            var request = new PutRequest<TRequest, TResponse>(resource);
            configure?.Invoke(request);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> PutAsync<TRequest, TResponse>(
            this IMediator mediator, TRequest resource, string resourceUri, params object[] args)
            where TRequest : class
        {
            var request = new PutRequest<TRequest, TResponse>(resource);
            request.SetResourceUri(resourceUri, args);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> DeleteAsync<TRequest, TResponse>(
            this IMediator mediator, TRequest resource,
            Action<DeleteRequest<TRequest, TResponse>> configure = null)
            where TRequest : class
        {
            var request = new DeleteRequest<TRequest, TResponse>(resource);
            configure?.Invoke(request);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }

        public static async Task<TResponse> DeleteAsync<TRequest, TResponse>(
            this IMediator mediator, TRequest resource, string resourceUri, params object[] args)
            where TRequest : class
        {
            var request = new DeleteRequest<TRequest, TResponse>(resource);
            request.SetResourceUri(resourceUri, args);
            var response = await mediator.SendAsync(request);
            return response.Resource;
        }
    }
}
