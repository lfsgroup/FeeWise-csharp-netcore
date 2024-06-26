/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.122
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
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentsApiTests : IDisposable
    {
        private PaymentsApi instance;

        public PaymentsApiTests()
        {
            instance = new PaymentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PaymentsApi
            //Assert.IsType<PaymentsApi>(instance);
        }

        /// <summary>
        /// Test AdjustInvoiceAmount
        /// </summary>
        [Fact]
        public void AdjustInvoiceAmountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid invoiceId = null;
            //AdjustInvoiceAmountRequest adjustInvoiceAmountRequest = null;
            //var response = instance.AdjustInvoiceAmount(invoiceId, adjustInvoiceAmountRequest);
            //Assert.IsType<InvoiceResponse>(response);
        }

        /// <summary>
        /// Test AdjustTrustDepositAmount
        /// </summary>
        [Fact]
        public void AdjustTrustDepositAmountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid trustDepositId = null;
            //AdjustTrustDepositAmountRequest adjustTrustDepositAmountRequest = null;
            //var response = instance.AdjustTrustDepositAmount(trustDepositId, adjustTrustDepositAmountRequest);
            //Assert.IsType<TrustDepositResponse>(response);
        }

        /// <summary>
        /// Test CreateCharge
        /// </summary>
        [Fact]
        public void CreateChargeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //Charge charge = null;
            //var response = instance.CreateCharge(firmId, charge);
            //Assert.IsType<ChargeResponse>(response);
        }

        /// <summary>
        /// Test CreateChargeAndPayWithCustomerPaymentToken
        /// </summary>
        [Fact]
        public void CreateChargeAndPayWithCustomerPaymentTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid paymentToken = null;
            //Guid firmId = null;
            //Charge charge = null;
            //var response = instance.CreateChargeAndPayWithCustomerPaymentToken(paymentToken, firmId, charge);
            //Assert.IsType<ChargeAndPayResponse>(response);
        }

        /// <summary>
        /// Test CreateInvoice
        /// </summary>
        [Fact]
        public void CreateInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Invoice invoice = null;
            //var response = instance.CreateInvoice(invoice);
            //Assert.IsType<InvoiceResponse>(response);
        }

        /// <summary>
        /// Test CreateMatter
        /// </summary>
        [Fact]
        public void CreateMatterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MatterRequest matterRequest = null;
            //var response = instance.CreateMatter(matterRequest);
            //Assert.IsType<MatterResponse>(response);
        }

        /// <summary>
        /// Test CreateSplitCharge
        /// </summary>
        [Fact]
        public void CreateSplitChargeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //SplitCharge splitCharge = null;
            //var response = instance.CreateSplitCharge(firmId, splitCharge);
            //Assert.IsType<SplitChargesResponse>(response);
        }

        /// <summary>
        /// Test CreateTrustDeposit
        /// </summary>
        [Fact]
        public void CreateTrustDepositTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TrustDeposit trustDeposit = null;
            //var response = instance.CreateTrustDeposit(trustDeposit);
            //Assert.IsType<TrustDepositResponse>(response);
        }

        /// <summary>
        /// Test GetChannelPartnerPayments
        /// </summary>
        [Fact]
        public void GetChannelPartnerPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? paymentId = null;
            //Guid? artifactId = null;
            //Guid? firmId = null;
            //DateTime? since = null;
            //var response = instance.GetChannelPartnerPayments(paymentId, artifactId, firmId, since);
            //Assert.IsType<Payments>(response);
        }

        /// <summary>
        /// Test GetDebtorMatterStatement
        /// </summary>
        [Fact]
        public void GetDebtorMatterStatementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid debtorId = null;
            //Guid matterId = null;
            //int? to = null;
            //int? from = null;
            //var response = instance.GetDebtorMatterStatement(debtorId, matterId, to, from);
            //Assert.IsType<MatterStatement>(response);
        }

        /// <summary>
        /// Test GetExternalDebtorMatterStatement
        /// </summary>
        [Fact]
        public void GetExternalDebtorMatterStatementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalDebtorId = null;
            //string externalMatterId = null;
            //var response = instance.GetExternalDebtorMatterStatement(externalDebtorId, externalMatterId);
            //Assert.IsType<GetExternalDebtorMatterStatement200Response>(response);
        }

        /// <summary>
        /// Test GetInvoiceByExternalId
        /// </summary>
        [Fact]
        public void GetInvoiceByExternalIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //string externalId = null;
            //var response = instance.GetInvoiceByExternalId(firmId, externalId);
            //Assert.IsType<InvoiceResponse>(response);
        }

        /// <summary>
        /// Test GetInvoiceById
        /// </summary>
        [Fact]
        public void GetInvoiceByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid invoiceId = null;
            //var response = instance.GetInvoiceById(invoiceId);
            //Assert.IsType<InvoiceResponse>(response);
        }

        /// <summary>
        /// Test GetMatterStatement
        /// </summary>
        [Fact]
        public void GetMatterStatementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid matterId = null;
            //int? to = null;
            //int? from = null;
            //var response = instance.GetMatterStatement(matterId, to, from);
            //Assert.IsType<MatterStatement>(response);
        }

        /// <summary>
        /// Test GetTrustDepositByExternalId
        /// </summary>
        [Fact]
        public void GetTrustDepositByExternalIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid firmId = null;
            //string externalId = null;
            //var response = instance.GetTrustDepositByExternalId(firmId, externalId);
            //Assert.IsType<TrustDepositResponse>(response);
        }

        /// <summary>
        /// Test GetTrustDepositById
        /// </summary>
        [Fact]
        public void GetTrustDepositByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid trustDepositId = null;
            //var response = instance.GetTrustDepositById(trustDepositId);
            //Assert.IsType<TrustDepositResponse>(response);
        }

        /// <summary>
        /// Test RecordExternalPayment
        /// </summary>
        [Fact]
        public void RecordExternalPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExternalPayment externalPayment = null;
            //var response = instance.RecordExternalPayment(externalPayment);
            //Assert.IsType<ExternalPaymentResponse>(response);
        }
    }
}
