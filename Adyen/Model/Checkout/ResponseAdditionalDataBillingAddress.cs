#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ResponseAdditionalDataBillingAddress
    /// </summary>
    [DataContract]
    public partial class ResponseAdditionalDataBillingAddress : IEquatable<ResponseAdditionalDataBillingAddress>,
        IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataBillingAddress" /> class.
        /// </summary>
        /// <param name="billingAddressCity">The billing address city passed in the payment request..</param>
        /// <param name="billingAddressCountry">The billing address country passed in the payment request.  Example: NL.</param>
        /// <param name="billingAddressHouseNumberOrName">The billing address house number or name passed in the payment request..</param>
        /// <param name="billingAddressPostalCode">The billing address postal code passed in the payment request.  Example: 1011 DJ.</param>
        /// <param name="billingAddressStateOrProvince">The billing address state or province passed in the payment request.  Example: NH.</param>
        /// <param name="billingAddressStreet">The billing address street passed in the payment request..</param>
        public ResponseAdditionalDataBillingAddress(string billingAddressCity = default(string),
            string billingAddressCountry = default(string), string billingAddressHouseNumberOrName = default(string),
            string billingAddressPostalCode = default(string), string billingAddressStateOrProvince = default(string),
            string billingAddressStreet = default(string))
        {
            this.BillingAddressCity = billingAddressCity;
            this.BillingAddressCountry = billingAddressCountry;
            this.BillingAddressHouseNumberOrName = billingAddressHouseNumberOrName;
            this.BillingAddressPostalCode = billingAddressPostalCode;
            this.BillingAddressStateOrProvince = billingAddressStateOrProvince;
            this.BillingAddressStreet = billingAddressStreet;
        }

        /// <summary>
        /// The billing address city passed in the payment request.
        /// </summary>
        /// <value>The billing address city passed in the payment request.</value>
        [DataMember(Name = "billingAddress.city", EmitDefaultValue = false)]
        public string BillingAddressCity { get; set; }

        /// <summary>
        /// The billing address country passed in the payment request.  Example: NL
        /// </summary>
        /// <value>The billing address country passed in the payment request.  Example: NL</value>
        [DataMember(Name = "billingAddress.country", EmitDefaultValue = false)]
        public string BillingAddressCountry { get; set; }

        /// <summary>
        /// The billing address house number or name passed in the payment request.
        /// </summary>
        /// <value>The billing address house number or name passed in the payment request.</value>
        [DataMember(Name = "billingAddress.houseNumberOrName", EmitDefaultValue = false)]
        public string BillingAddressHouseNumberOrName { get; set; }

        /// <summary>
        /// The billing address postal code passed in the payment request.  Example: 1011 DJ
        /// </summary>
        /// <value>The billing address postal code passed in the payment request.  Example: 1011 DJ</value>
        [DataMember(Name = "billingAddress.postalCode", EmitDefaultValue = false)]
        public string BillingAddressPostalCode { get; set; }

        /// <summary>
        /// The billing address state or province passed in the payment request.  Example: NH
        /// </summary>
        /// <value>The billing address state or province passed in the payment request.  Example: NH</value>
        [DataMember(Name = "billingAddress.stateOrProvince", EmitDefaultValue = false)]
        public string BillingAddressStateOrProvince { get; set; }

        /// <summary>
        /// The billing address street passed in the payment request.
        /// </summary>
        /// <value>The billing address street passed in the payment request.</value>
        [DataMember(Name = "billingAddress.street", EmitDefaultValue = false)]
        public string BillingAddressStreet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataBillingAddress {\n");
            sb.Append("  BillingAddressCity: ").Append(BillingAddressCity).Append("\n");
            sb.Append("  BillingAddressCountry: ").Append(BillingAddressCountry).Append("\n");
            sb.Append("  BillingAddressHouseNumberOrName: ").Append(BillingAddressHouseNumberOrName).Append("\n");
            sb.Append("  BillingAddressPostalCode: ").Append(BillingAddressPostalCode).Append("\n");
            sb.Append("  BillingAddressStateOrProvince: ").Append(BillingAddressStateOrProvince).Append("\n");
            sb.Append("  BillingAddressStreet: ").Append(BillingAddressStreet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseAdditionalDataBillingAddress);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataBillingAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataBillingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataBillingAddress input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BillingAddressCity == input.BillingAddressCity ||
                    this.BillingAddressCity != null &&
                    this.BillingAddressCity.Equals(input.BillingAddressCity)
                ) &&
                (
                    this.BillingAddressCountry == input.BillingAddressCountry ||
                    this.BillingAddressCountry != null &&
                    this.BillingAddressCountry.Equals(input.BillingAddressCountry)
                ) &&
                (
                    this.BillingAddressHouseNumberOrName == input.BillingAddressHouseNumberOrName ||
                    this.BillingAddressHouseNumberOrName != null &&
                    this.BillingAddressHouseNumberOrName.Equals(input.BillingAddressHouseNumberOrName)
                ) &&
                (
                    this.BillingAddressPostalCode == input.BillingAddressPostalCode ||
                    this.BillingAddressPostalCode != null &&
                    this.BillingAddressPostalCode.Equals(input.BillingAddressPostalCode)
                ) &&
                (
                    this.BillingAddressStateOrProvince == input.BillingAddressStateOrProvince ||
                    this.BillingAddressStateOrProvince != null &&
                    this.BillingAddressStateOrProvince.Equals(input.BillingAddressStateOrProvince)
                ) &&
                (
                    this.BillingAddressStreet == input.BillingAddressStreet ||
                    this.BillingAddressStreet != null &&
                    this.BillingAddressStreet.Equals(input.BillingAddressStreet)
                );
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
                if (this.BillingAddressCity != null)
                    hashCode = hashCode * 59 + this.BillingAddressCity.GetHashCode();
                if (this.BillingAddressCountry != null)
                    hashCode = hashCode * 59 + this.BillingAddressCountry.GetHashCode();
                if (this.BillingAddressHouseNumberOrName != null)
                    hashCode = hashCode * 59 + this.BillingAddressHouseNumberOrName.GetHashCode();
                if (this.BillingAddressPostalCode != null)
                    hashCode = hashCode * 59 + this.BillingAddressPostalCode.GetHashCode();
                if (this.BillingAddressStateOrProvince != null)
                    hashCode = hashCode * 59 + this.BillingAddressStateOrProvince.GetHashCode();
                if (this.BillingAddressStreet != null)
                    hashCode = hashCode * 59 + this.BillingAddressStreet.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}