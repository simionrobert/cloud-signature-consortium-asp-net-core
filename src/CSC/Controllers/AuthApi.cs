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
    public class AuthApiController : ControllerBase
    { 
        /// <summary>
        /// Obtain an access token for service authorization from the Remote Service using HTTP Basic Authentication or HTTP Digest authentication
        /// </summary>
        /// <param name="body">Auth login request object</param>
        /// <response code="200">Auth login response object</response>
        /// <response code="400">Invalid_request</response>
        /// <response code="401">Invalid_info</response>
        [HttpPost]
        [Route("/csc/v1/auth/login")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AuthLogin")]
        [SwaggerResponse(statusCode: 200, type: typeof(OutputAuthLogin), description: "Auth login response object")]
        public virtual IActionResult AuthLogin([FromBody]InputAuthLogin body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OutputAuthLogin));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);
            string exampleJson = null;
            exampleJson = "{\n  \"access_token\" : \"4/CKN69L8gdSYp5_pwH3XlFQZ3ndFhkXf9P2_TiHRG-bA\",\n  \"refresh_token\" : \"_TiHRG-bA-H3XlFQZ3ndFhkXf9P24/CKN69L8gdSYp5_pw\",\n  \"expires_in\" : 3600\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OutputAuthLogin>(exampleJson)
                        : default(OutputAuthLogin);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Revoke a service access token or refresh token that was obtained from the Remote Service or an associated Authorization Service.
        /// </summary>
        /// <param name="body">Revoke login request object</param>
        /// <response code="400">Invalid_request</response>
        [HttpPost]
        [Route("/csc/v1/auth/revoke")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AuthRevoke")]
        public virtual IActionResult AuthRevoke([FromBody]InputAuthRevoke body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            throw new NotImplementedException();
        }
    }
}
