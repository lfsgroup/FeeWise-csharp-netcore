/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.56
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
    ///  Class for testing WebhookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookApiTests : IDisposable
    {
        private WebhookApi instance;

        public WebhookApiTests()
        {
            instance = new WebhookApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhookApi
            //Assert.IsType<WebhookApi>(instance);
        }

        /// <summary>
        /// Test CreateWebhook
        /// </summary>
        [Fact]
        public void CreateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Webhook webhook = null;
            //var response = instance.CreateWebhook(webhook);
            //Assert.IsType<WebhookResponse>(response);
        }

        /// <summary>
        /// Test DeleteWebhook
        /// </summary>
        [Fact]
        public void DeleteWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid webhookId = null;
            //instance.DeleteWebhook(webhookId);
        }

        /// <summary>
        /// Test GetChannelPartnerEventTopics
        /// </summary>
        [Fact]
        public void GetChannelPartnerEventTopicsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetChannelPartnerEventTopics();
            //Assert.IsType<EventTopics>(response);
        }

        /// <summary>
        /// Test GetChannelPartnerWebhookEvents
        /// </summary>
        [Fact]
        public void GetChannelPartnerWebhookEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string topic = null;
            //Guid? sinceWebhookEventId = null;
            //DateTime? since = null;
            //WebhookSendStatus? status = null;
            //var response = instance.GetChannelPartnerWebhookEvents(topic, sinceWebhookEventId, since, status);
            //Assert.IsType<Events>(response);
        }

        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Fact]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWebhooks();
            //Assert.IsType<WebhookList>(response);
        }

        /// <summary>
        /// Test ReceiveWebhook
        /// </summary>
        [Fact]
        public void ReceiveWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhookEvent webhookEvent = null;
            //instance.ReceiveWebhook(webhookEvent);
        }

        /// <summary>
        /// Test UpdateWebhook
        /// </summary>
        [Fact]
        public void UpdateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Webhook webhook = null;
            //var response = instance.UpdateWebhook(webhook);
            //Assert.IsType<WebhookResponse>(response);
        }
    }
}
