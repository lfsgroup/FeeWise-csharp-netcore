/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.105
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
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountsApiTests : IDisposable
    {
        private AccountsApi instance;

        public AccountsApiTests()
        {
            instance = new AccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AccountsApi
            //Assert.IsType<AccountsApi>(instance);
        }

        /// <summary>
        /// Test CreateFirmBankAccount
        /// </summary>
        [Fact]
        public void CreateFirmBankAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //BankAccount bankAccount = null;
            //var response = instance.CreateFirmBankAccount(firmId, bankAccount);
            //Assert.IsType<BankAccount>(response);
        }
    }
}
