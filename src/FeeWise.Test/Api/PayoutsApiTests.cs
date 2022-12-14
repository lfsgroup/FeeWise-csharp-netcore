/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.43
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
    ///  Class for testing PayoutsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PayoutsApiTests : IDisposable
    {
        private PayoutsApi instance;

        public PayoutsApiTests()
        {
            instance = new PayoutsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PayoutsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PayoutsApi
            //Assert.IsType<PayoutsApi>(instance);
        }

        /// <summary>
        /// Test GetChannelPartnerPayouts
        /// </summary>
        [Fact]
        public void GetChannelPartnerPayoutsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? payoutId = null;
            //GetChannelPartnerPayoutsAccountParameter account = null;
            //Guid? firmId = null;
            //Guid? sincePayoutId = null;
            //DateTime? since = null;
            //var response = instance.GetChannelPartnerPayouts(payoutId, account, firmId, sincePayoutId, since);
            //Assert.IsType<Payouts>(response);
        }
    }
}
