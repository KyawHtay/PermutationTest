using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermutationTest.Controllers
{
    public class WebAPIController:ControllerBase
    {
       
            private readonly ILogger<WebAPIController> _logger;

            public WebAPIController(ILogger<WebAPIController> logger = null)
            {
                _logger = logger;
            }
            private string RemoveWhitespace(string input)
            {
                return new string(input.ToCharArray()
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray());
            }
            [HttpGet]
            [Route("api/GetPermute")]
            public bool GetPermute(string permute, string checking)
            {
                string str = RemoveWhitespace(permute);

                int n = str.Length;
                Permutation _permute = new Permutation(false);
                return _permute.permute(str, 0, n - 1, checking);

            }
        
    }
}
