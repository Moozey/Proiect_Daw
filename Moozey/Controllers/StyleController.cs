using Microsoft.AspNetCore.Mvc;
using Moozey.Models;

namespace Moozey.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StyleController : ControllerBase
    {
        private static readonly string[] Styles = new[]
        {
            "Hip-Hop", "AfroHouse", "Dancehall", "Electro", "House", " Kuduro", "Salsa", "Bachata", "Tango", "Wacking"
        };

        [HttpGet(Name = "GetStyle")]
        public IEnumerable <Style> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Style
            {
                
                NameStyle = Styles[Random.Shared.Next(Styles.Length)],
                NrInstructor = Random.Shared.Next(1, 10),
                Price = Random.Shared.Next(100, 500)
            })
            .ToArray();
            
        }
    }
}
