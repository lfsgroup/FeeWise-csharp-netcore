/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.90
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
    ///  Class for testing BankAccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BankAccountApiTests : IDisposable
    {
        private BankAccountApi instance;

        public BankAccountApiTests()
        {
            instance = new BankAccountApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BankAccountApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BankAccountApi
            //Assert.IsType<BankAccountApi>(instance);
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
    }
}
