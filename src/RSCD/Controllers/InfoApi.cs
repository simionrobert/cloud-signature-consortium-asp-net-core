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
    public class InfoApiController : ControllerBase
    { 
        /// <summary>
        /// Returns several information about the Remote Service and the list of the API methods implemented and supported by it.
        /// </summary>
        /// <param name="body">Info request object</param>
        /// <response code="200">Info response object</response>
        [HttpPost]
        [Route("/csc/v1/info")]
        [ValidateModelState]
        [SwaggerOperation("Info")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputInfo), description: "Info response object")]
        public virtual IActionResult Info([FromBody]InputInfo body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputInfo));
            string exampleJson = null;
            exampleJson = "{\n  \"specs\" : \"1.0.2.3\",\n  \"name\" : \"ACME Trust Services\",\n  \"logo\" : \"https://service.domain.org/images/logo.png\",\n  \"region\" : \"IT\",\n  \"lang\" : \"en-US\",\n  \"authType\" : [ \"basic\", \"oauth2code\", \"oauth2implicit\" ],\n  \"oauth2\" : \"https://www.domain.org/\",\n  \"methods\" : [ \"auth/login\", \"auth/revoke\", \"credentials/list\", \"credentials/info\", \"credentials/authorize\", \"credentials/sendOTP\", \"signatures/signHash\" ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputInfo>(exampleJson)
                        : default(OutputInfo);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
