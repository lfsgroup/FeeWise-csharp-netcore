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
    ///  Class for testing FirmApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FirmApiTests : IDisposable
    {
        private FirmApi instance;

        public FirmApiTests()
        {
            instance = new FirmApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FirmApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FirmApi
            //Assert.IsType<FirmApi>(instance);
        }

        /// <summary>
        /// Test GetFirm
        /// </summary>
        [Fact]
        public void GetFirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //var response = instance.GetFirm(firmId);
            //Assert.IsType<FirmResponse>(response);
        }

        /// <summary>
        /// Test GetFirmBankAccounts
        /// </summary>
        [Fact]
        public void GetFirmBankAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //var response = instance.GetFirmBankAccounts(firmId);
            //Assert.IsType<BankAccountsResponse>(response);
        }

        /// <summary>
        /// Test GetMagicLink
        /// </summary>
        [Fact]
        public void GetMagicLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //string destinationUrl = null;
            //var response = instance.GetMagicLink(firmId, destinationUrl);
            //Assert.IsType<GetMagicLink200Response>(response);
        }

        /// <summary>
        /// Test SetFirmsDefaultBankAccount
        /// </summary>
        [Fact]
        public void SetFirmsDefaultBankAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //Guid accountId = null;
            //var response = instance.SetFirmsDefaultBankAccount(firmId, accountId);
            //Assert.IsType<BankAccountResponse>(response);
        }

        /// <summary>
        /// Test SyncFirm
        /// </summary>
        [Fact]
        public void SyncFirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string connectId = null;
            //var response = instance.SyncFirm(connectId);
            //Assert.IsType<FirmResponse>(response);
        }
    }
}
