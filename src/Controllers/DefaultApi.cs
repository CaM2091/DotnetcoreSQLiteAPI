using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using App.Models;

namespace App.Controllers
{
    /// <summary>
    /// 
    /// </sumary>
    public class DefaultApiController : Controller
    {

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Creates a new account</remarks>
        /// <param name="account">Account to add to the store</param>
        /// <response code="200">account response</response>
        /// <response code="0">unexpected error</response>
        [HttpPost]
        [Route("/accounts")]
        [SwaggerOperation("AddAccount")]
        [SwaggerResponse(200, type: typeof(Account))]
        public virtual IActionResult AddAccount([FromBody]Account account)
        {
            string exampleJson = null;

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Account>(exampleJson)
            : default(Account);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>deletes a single account based on the ID supplied</remarks>
        /// <param name="id">ID of account to delete</param>
        /// <response code="204">account deleted</response>
        /// <response code="0">unexpected error</response>
        [HttpDelete]
        [Route("/accounts/{id}")]
        [SwaggerOperation("DeleteAccount")]
        public virtual void DeleteAccount([FromRoute]long? id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns all platforms</remarks>
        /// <response code="200">pet response</response>
        /// <response code="0">unexpected error</response>
        [HttpGet]
        [Route("/accounts")]
        [SwaggerOperation("FindPlatforms")]
        [SwaggerResponse(200, type: typeof(List<Account>))]
        public virtual IActionResult FindPlatforms()
        {
            var db = new BloggingContext();


            var list = new List<Account>();

            var dbEntry = db.Blogs.ToList();
            db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });

            dbEntry.ForEach(delegate (Models.Blog blog)
            {
                var account = new Account(null, blog.BlogId.ToString());
                list.Add(account);
            });


            Console.WriteLine();
            Console.WriteLine("All blogs in database:");

            return new ObjectResult(list);
        }
    }
}
