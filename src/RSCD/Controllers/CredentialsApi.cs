/*
 * CSC Api
 *
 * This document contains the API descriprion
 *
 * OpenAPI spec version: 1.0.3.0
 * Contact: info@cloudsignatureconsortium.org

 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using RSCD.Attributes;
using RSCD.Security;
using Microsoft.AspNetCore.Authorization;
using RSCD.Models;

namespace  RSCD.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class CredentialsApiController : ControllerBase
    { 
        /// <summary>
        /// Authorize the access to the credential for remote signing, according to the authorization mechanisms associated to it.
        /// </summary>
        /// <param name="body">Credentials authorize request object</param>
        /// <response code="200">Credentials authorize response object</response>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1/credentials/authorize")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CredentialsAuthorize")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputCredentialsAuthorize), description: "Credentials authorize response object")]
        public virtual IActionResult CredentialsAuthorize([FromBody]InputCredentialsAuthorize body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputCredentialsAuthorize));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"SAD\" : \"1/UsHDJ98349h9fgh9348hKKHDkHWVkl/8hsAW5usc8_5=\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputCredentialsAuthorize>(exampleJson)
                        : default(OutputCredentialsAuthorize);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Extends the validity of a multi-signature transaction authorization by obtaining a new SAD.
        /// </summary>
        /// <param name="body">Credentials authorize request object</param>
        /// <response code="200">Credentials authorize response object</response>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1/credentials/extendTransaction")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CredentialsExtendTransaction")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputCredentialsExtendTransaction), description: "Credentials authorize response object")]
        public virtual IActionResult CredentialsExtendTransaction([FromBody]InputCredentialsExtendTransaction body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputCredentialsExtendTransaction));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"SAD\" : \"1/UsHDJ98349h9fgh9348hKKHDkHWVkl/8hsAW5usc8_5=\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputCredentialsExtendTransaction>(exampleJson)
                        : default(OutputCredentialsExtendTransaction);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Retrieve the credential and return the main identity information and the public key certificate or the certificate chain associated to it.
        /// </summary>
        /// <param name="body">Credentials info request object</param>
        /// <response code="200">Credentials info response object</response>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1/credentials/info")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CredentialsInfo")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputCredentialsInfo), description: "Credentials info response object")]
        public virtual IActionResult CredentialsInfo([FromBody]InputCredentialsInfo body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputCredentialsInfo));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"key\" : {\n    \"status\" : \"enabled\",\n    \"algo\" : [ \"1.2.840.113549.1.1.1\", \"0.4.0.127.0.7.1.1.4.1.3\" ],\n    \"len\" : 2048\n  },\n  \"cert\" : {\n    \"status\" : \"valid\",\n    \"certificates\" : [ \"<Base64-encoded_X.509_end_entity_certificate>\", \"<Base64-encoded_X.509_intermediate_CA_certificate>\", \"<Base64-encoded_X.509_root_CA_certificate>\" ],\n    \"issuerDN\" : \"<X.500_issuer_DN_printable_string>\",\n    \"serialNumber\" : \"5AAC41CD8FA22B953640\",\n    \"subjectDN\" : \"<X.500_subject_DN_printable_string>\",\n    \"validFrom\" : \"20180101100000Z\",\n    \"validTo\" : \"20190101095959Z\",\n    \"authMode\" : \"explicit\",\n    \"PIN\" : {\n      \"presence\" : \"true\",\n      \"label\" : \"PIN\",\n      \"description\" : \"Please enter the signature PIN\"\n    },\n    \"OTP\" : {\n      \"presence\" : \"true\",\n      \"type\" : \"offline\",\n      \"ID\" : \"MB01-K741200\",\n      \"provider\" : \"totp\",\n      \"format\" : \"N\",\n      \"label\" : \"Mobile OTP\",\n      \"description\" : \"Please enter the 6 digit code you received by SMS\"\n    },\n    \"multisign\" : 5,\n    \"lang\" : \"en-US\"\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputCredentialsInfo>(exampleJson)
                        : default(OutputCredentialsInfo);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns the list of credentials associated with a user identifier
        /// </summary>
        /// <param name="body">Credentials list request object</param>
        /// <response code="200">Credentials list response object</response>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1/credentials/list")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CredentialsList")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputCredentialsList), description: "Credentials list response object")]
        public virtual IActionResult CredentialsList([FromBody]InputCredentialsList body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputCredentialsList));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"credentialIDs\" : [ \"GX0112348\", \"HX0224685\" ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputCredentialsList>(exampleJson)
                        : default(OutputCredentialsList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Start the online OTP generation mechanism associated with a credential and managed by the Remote Service.
        /// </summary>
        /// <param name="body">Credentials sendOTP request object</param>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1/credentials/sendOTP")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CredentialsSendOTP")]
        public virtual IActionResult CredentialsSendOTP([FromBody]InputCredentialsSendOTP body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            throw new NotImplementedException();
        }
    }
}
