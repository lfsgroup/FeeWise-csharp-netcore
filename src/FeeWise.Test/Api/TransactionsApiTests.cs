/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.119
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
    ///  Class for testing TransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransactionsApiTests : IDisposable
    {
        private TransactionsApi instance;

        public TransactionsApiTests()
        {
            instance = new TransactionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransactionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TransactionsApi
            //Assert.IsType<TransactionsApi>(instance);
        }

        /// <summary>
        /// Test GetFirmTransactions
        /// </summary>
        [Fact]
        public void GetFirmTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //DateTime? from = null;
            //DateTime? to = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string order = null;
            //List<string> statusFilter = null;
            //List<Guid> accountIdFilter = null;
            //var response = instance.GetFirmTransactions(firmId, from, to, page, pageSize, sortBy, order, statusFilter, accountIdFilter);
            //Assert.IsType<TransactionsResponse>(response);
        }

        /// <summary>
        /// Test GetTransactionById
        /// </summary>
        [Fact]
        public void GetTransactionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid transactionId = null;
            //var response = instance.GetTransactionById(transactionId);
            //Assert.IsType<TransactionResponse>(response);
        }
    }
}
