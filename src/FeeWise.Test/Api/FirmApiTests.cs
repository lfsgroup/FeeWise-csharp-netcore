/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.81
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
        /// Test CreateFirm
        /// </summary>
        [Fact]
        public void CreateFirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFirm createFirm = null;
            //var response = instance.CreateFirm(createFirm);
            //Assert.IsType<FirmDetails>(response);
        }

        /// <summary>
        /// Test CreatePaymentToken
        /// </summary>
        [Fact]
        public void CreatePaymentTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //PaymentTokenBody paymentTokenBody = null;
            //var response = instance.CreatePaymentToken(firmId, paymentTokenBody);
            //Assert.IsType<PaymentTokenResponse>(response);
        }

        /// <summary>
        /// Test DeletePaymentToken
        /// </summary>
        [Fact]
        public void DeletePaymentTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //Guid paymentToken = null;
            //instance.DeletePaymentToken(firmId, paymentToken);
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
        /// Test GetFirmCustomers
        /// </summary>
        [Fact]
        public void GetFirmCustomersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //var response = instance.GetFirmCustomers(firmId);
            //Assert.IsType<CustomersResponse>(response);
        }

        /// <summary>
        /// Test GetFirms
        /// </summary>
        [Fact]
        public void GetFirmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetFirms();
            //Assert.IsType<FirmsResponse>(response);
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
        /// Test PostUpload
        /// </summary>
        [Fact]
        public void PostUploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //string filePurpose = null;
            //Guid? personId = null;
            //System.IO.Stream fwUploadFile = null;
            //var response = instance.PostUpload(firmId, filePurpose, personId, fwUploadFile);
            //Assert.IsType<PostUpload200Response>(response);
        }

        /// <summary>
        /// Test SearchChargesByMetadata
        /// </summary>
        [Fact]
        public void SearchChargesByMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //MetadataSearch metadataSearch = null;
            //var response = instance.SearchChargesByMetadata(firmId, metadataSearch);
            //Assert.IsType<List<ChargeResponse>>(response);
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
