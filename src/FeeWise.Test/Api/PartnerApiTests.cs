/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.116
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
    ///  Class for testing PartnerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PartnerApiTests : IDisposable
    {
        private PartnerApi instance;

        public PartnerApiTests()
        {
            instance = new PartnerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PartnerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PartnerApi
            //Assert.IsType<PartnerApi>(instance);
        }

        /// <summary>
        /// Test GetPartnerBranding
        /// </summary>
        [Fact]
        public void GetPartnerBrandingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPartnerBranding();
            //Assert.IsType<GetPartnerBranding200Response>(response);
        }

        /// <summary>
        /// Test PostPartnerLogoUpload
        /// </summary>
        [Fact]
        public void PostPartnerLogoUploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream fwUploadFile = null;
            //var response = instance.PostPartnerLogoUpload(fwUploadFile);
            //Assert.IsType<PostPartnerLogoUpload200Response>(response);
        }
    }
}
