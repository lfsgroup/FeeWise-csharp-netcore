/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.93
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FeeWise.Client.OpenAPIDateConverter;
using System.Reflection;

namespace FeeWise.Model
{
    /// <summary>
    /// WebhookEventEvent
    /// </summary>
    [JsonConverter(typeof(WebhookEventEventJsonConverter))]
    [DataContract(Name = "WebhookEvent_event")]
    public partial class WebhookEventEvent : AbstractOpenAPISchema, IEquatable<WebhookEventEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventEvent" /> class
        /// with the <see cref="Invoice" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Invoice.</param>
        public WebhookEventEvent(Invoice actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventEvent" /> class
        /// with the <see cref="TrustDeposit" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TrustDeposit.</param>
        public WebhookEventEvent(TrustDeposit actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventEvent" /> class
        /// with the <see cref="Payment" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Payment.</param>
        public WebhookEventEvent(Payment actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventEvent" /> class
        /// with the <see cref="Payout" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Payout.</param>
        public WebhookEventEvent(Payout actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventEvent" /> class
        /// with the <see cref="PaymentAuthorisedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentAuthorisedEvent.</param>
        public WebhookEventEvent(PaymentAuthorisedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventEvent" /> class
        /// with the <see cref="FirmStatusUpdatedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FirmStatusUpdatedEvent.</param>
        public WebhookEventEvent(FirmStatusUpdatedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(FirmStatusUpdatedEvent))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Invoice))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Payment))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentAuthorisedEvent))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Payout))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TrustDeposit))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: FirmStatusUpdatedEvent, Invoice, Payment, PaymentAuthorisedEvent, Payout, TrustDeposit");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Invoice`. If the actual instance is not `Invoice`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Invoice</returns>
        public Invoice GetInvoice()
        {
            return (Invoice)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TrustDeposit`. If the actual instance is not `TrustDeposit`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TrustDeposit</returns>
        public TrustDeposit GetTrustDeposit()
        {
            return (TrustDeposit)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Payment`. If the actual instance is not `Payment`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Payment</returns>
        public Payment GetPayment()
        {
            return (Payment)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Payout`. If the actual instance is not `Payout`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Payout</returns>
        public Payout GetPayout()
        {
            return (Payout)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentAuthorisedEvent`. If the actual instance is not `PaymentAuthorisedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentAuthorisedEvent</returns>
        public PaymentAuthorisedEvent GetPaymentAuthorisedEvent()
        {
            return (PaymentAuthorisedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `FirmStatusUpdatedEvent`. If the actual instance is not `FirmStatusUpdatedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of FirmStatusUpdatedEvent</returns>
        public FirmStatusUpdatedEvent GetFirmStatusUpdatedEvent()
        {
            return (FirmStatusUpdatedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEventEvent {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, WebhookEventEvent.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of WebhookEventEvent
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of WebhookEventEvent</returns>
        public static WebhookEventEvent FromJson(string jsonString)
        {
            WebhookEventEvent newWebhookEventEvent = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newWebhookEventEvent;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FirmStatusUpdatedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<FirmStatusUpdatedEvent>(jsonString, WebhookEventEvent.SerializerSettings));
                }
                else
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<FirmStatusUpdatedEvent>(jsonString, WebhookEventEvent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FirmStatusUpdatedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FirmStatusUpdatedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Invoice).GetProperty("AdditionalProperties") == null)
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<Invoice>(jsonString, WebhookEventEvent.SerializerSettings));
                }
                else
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<Invoice>(jsonString, WebhookEventEvent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Invoice");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Invoice: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Payment).GetProperty("AdditionalProperties") == null)
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<Payment>(jsonString, WebhookEventEvent.SerializerSettings));
                }
                else
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<Payment>(jsonString, WebhookEventEvent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Payment");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Payment: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentAuthorisedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<PaymentAuthorisedEvent>(jsonString, WebhookEventEvent.SerializerSettings));
                }
                else
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<PaymentAuthorisedEvent>(jsonString, WebhookEventEvent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentAuthorisedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentAuthorisedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Payout).GetProperty("AdditionalProperties") == null)
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<Payout>(jsonString, WebhookEventEvent.SerializerSettings));
                }
                else
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<Payout>(jsonString, WebhookEventEvent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Payout");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Payout: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TrustDeposit).GetProperty("AdditionalProperties") == null)
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<TrustDeposit>(jsonString, WebhookEventEvent.SerializerSettings));
                }
                else
                {
                    newWebhookEventEvent = new WebhookEventEvent(JsonConvert.DeserializeObject<TrustDeposit>(jsonString, WebhookEventEvent.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TrustDeposit");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TrustDeposit: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newWebhookEventEvent;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookEventEvent);
        }

        /// <summary>
        /// Returns true if WebhookEventEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEventEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventEvent input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for WebhookEventEvent
    /// </summary>
    public class WebhookEventEventJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(WebhookEventEvent).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return WebhookEventEvent.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
