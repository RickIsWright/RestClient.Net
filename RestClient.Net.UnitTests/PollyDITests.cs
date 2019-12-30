﻿#if NETCOREAPP3_1

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestClient.Net.Polly;
using System;

namespace RestClientDotNet.UnitTests
{
    [TestClass]
    public class PollyDITests
    {
        [TestMethod]
        public void TestDIMapping()
        {
            var serviceCollection = new ServiceCollection();
            var baseUri = new Uri("http://www.test.com");
            serviceCollection.AddHttpClient("test", (c)=> { c.BaseAddress = baseUri; });
            serviceCollection.AddDependencyInjectionMapping();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var httpClient = httpClientFactory.CreateClient("test");
            Assert.AreEqual(baseUri, httpClient.BaseAddress);
        }
    }  
}
#endif