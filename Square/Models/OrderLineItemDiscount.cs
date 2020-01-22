using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class OrderLineItemDiscount 
    {
        public OrderLineItemDiscount(string uid = null,
            string catalogObjectId = null,
            string name = null,
            string type = null,
            string percentage = null,
            Models.Money amountMoney = null,
            Models.Money appliedMoney = null,
            IDictionary<string, string> metadata = null,
            string scope = null)
        {
            Uid = uid;
            CatalogObjectId = catalogObjectId;
            Name = name;
            Type = type;
            Percentage = percentage;
            AmountMoney = amountMoney;
            AppliedMoney = appliedMoney;
            Metadata = metadata;
            Scope = scope;
        }

        /// <summary>
        /// Unique ID that identifies the discount only within this order.
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; }

        /// <summary>
        /// The catalog object id referencing [CatalogDiscount](#type-catalogdiscount).
        /// </summary>
        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; }

        /// <summary>
        /// The discount's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// Indicates how the discount is applied to the associated line item or order.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; }

        /// <summary>
        /// The percentage of the discount, as a string representation of a decimal number.
        /// A value of `7.25` corresponds to a percentage of 7.25%.
        /// `percentage` is not set for amount-based discounts.
        /// </summary>
        [JsonProperty("percentage")]
        public string Percentage { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("amount_money")]
        public Models.Money AmountMoney { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("applied_money")]
        public Models.Money AppliedMoney { get; }

        /// <summary>
        /// Application-defined data attached to this discount. Metadata fields are intended
        /// to store descriptive references or associations with an entity in another system or store brief
        /// information about the object. Square does not process this field; it only stores and returns it
        /// in relevant API calls. Do not use metadata to store any sensitive information (personally
        /// identifiable information, card details, etc.).
        /// Keys written by applications must be 60 characters or less and must be in the character set
        /// `[a-zA-Z0-9_-]`. Entries may also include metadata generated by Square. These keys are prefixed
        /// with a namespace, separated from the key with a ':' character.
        /// Values have a max length of 255 characters.
        /// An application may have up to 10 entries per metadata field.
        /// Entries written by applications are private and can only be read or modified by the same
        /// application.
        /// See [Metadata](https://developer.squareup.com/docs/build-basics/metadata) for more information.
        /// </summary>
        [JsonProperty("metadata")]
        public IDictionary<string, string> Metadata { get; }

        /// <summary>
        /// Indicates whether this is a line item or order level discount.
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Uid(Uid)
                .CatalogObjectId(CatalogObjectId)
                .Name(Name)
                .Type(Type)
                .Percentage(Percentage)
                .AmountMoney(AmountMoney)
                .AppliedMoney(AppliedMoney)
                .Metadata(Metadata)
                .Scope(Scope);
            return builder;
        }

        public class Builder
        {
            private string uid;
            private string catalogObjectId;
            private string name;
            private string type;
            private string percentage;
            private Models.Money amountMoney;
            private Models.Money appliedMoney;
            private IDictionary<string, string> metadata = new Dictionary<string, string>();
            private string scope;

            public Builder() { }
            public Builder Uid(string value)
            {
                uid = value;
                return this;
            }

            public Builder CatalogObjectId(string value)
            {
                catalogObjectId = value;
                return this;
            }

            public Builder Name(string value)
            {
                name = value;
                return this;
            }

            public Builder Type(string value)
            {
                type = value;
                return this;
            }

            public Builder Percentage(string value)
            {
                percentage = value;
                return this;
            }

            public Builder AmountMoney(Models.Money value)
            {
                amountMoney = value;
                return this;
            }

            public Builder AppliedMoney(Models.Money value)
            {
                appliedMoney = value;
                return this;
            }

            public Builder Metadata(IDictionary<string, string> value)
            {
                metadata = value;
                return this;
            }

            public Builder Scope(string value)
            {
                scope = value;
                return this;
            }

            public OrderLineItemDiscount Build()
            {
                return new OrderLineItemDiscount(uid,
                    catalogObjectId,
                    name,
                    type,
                    percentage,
                    amountMoney,
                    appliedMoney,
                    metadata,
                    scope);
            }
        }
    }
}