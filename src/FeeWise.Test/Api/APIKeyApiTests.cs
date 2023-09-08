/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.86
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FeeWise.Client;
using FeeWise.Api;
// uncomment below to import models
//using FeeWise.Model;

namespace FeeWise.Test.Api
{
    /// <summary>
    ///  Class for testing APIKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class APIKeyApiTests : IDisposable
    {
        private APIKeyApi instance;

        public APIKeyApiTests()
        {
            instance = new APIKeyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APIKeyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' APIKeyApi
            //Assert.IsType<APIKeyApi>(instance);
        }

        /// <summary>
        /// Test RotateApiKey
        /// </summary>
        [Fact]
        public void RotateApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiKeyRotation apiKeyRotation = null;
            //var response = instance.RotateApiKey(apiKeyRotation);
            //Assert.IsType<ApiKeyResponse>(response);
        }
    }
}
