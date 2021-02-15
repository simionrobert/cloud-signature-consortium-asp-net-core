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
using CSC.Attributes;
using CSC.Security;
using Microsoft.AspNetCore.Authorization;
using CSC.Models;

namespace CSC.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SignaturesApiController : ControllerBase
    { 
        /// <summary>
        /// Calculate the remote digital signature of one or multiple hash values provided as an input.
        /// </summary>
        /// <param name="body">Sign hash request object</param>
        /// <response code="200">Sign hash response object</response>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1//signatures/signHash")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("SignaturesSignHash")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputSignaturesSignhash), description: "Sign hash response object")]
        public virtual IActionResult SignaturesSignHash([FromBody]InputSignaturesSignhash body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputSignaturesSignhash));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"signatures\" : [ \"KedJuTob5gtvYx9qM3k3gm7kbLBwVbEQRl26S2tmXjqNND7MRGtoew==\", \"Idhef7xzgtvYx9qM3k3gm7kbLBwVbE98239S2tm8hUh85KKsfdowel==\" ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputSignaturesSignhash>(exampleJson)
                        : default(OutputSignaturesSignhash);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Generate a time-stamp token for the input hash value.
        /// </summary>
        /// <param name="body">Timestamp request object</param>
        /// <response code="200">Timestamp response object</response>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1//signatures/timestamp")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("SignaturesTimestamp")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputSignaturesTimestamp), description: "Timestamp response object")]
        public virtual IActionResult SignaturesTimestamp([FromBody]InputSignaturesTimestamp body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputSignaturesTimestamp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"timestamp\" : \"MGwCAQEGCSsGAQQB7U8CATAxMA0GCWCGSAFlAwQCAQUABCCrCqnrjH0VxXyQQlfnFJRx1jjrviTs7/GjKghr2AmluQIIVs5D8OUB4p4YDzIwMTQxMTE5MTEzMjM5WjADAgEBAgkAnWn2SSIWlXk=\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputSignaturesTimestamp>(exampleJson)
                        : default(OutputSignaturesTimestamp);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
