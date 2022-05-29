using Microsoft.AspNetCore.Mvc;

namespace CertificateChain.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionsController : ControllerBase
{
    
    public TransactionsController()
    {
        
    }
    
    [HttpGet("first")]  
    public IActionResult First()
    {
        return new OkObjectResult("great job, Danya) Pososi, escho mnogo chego nuzhno sdelat");
    }
    
    [HttpGet("second/{id}")]  
    public IActionResult Second(string id)
    {
        return new OkObjectResult($"Great job, your id:{id}");
    }

    
    [HttpPost("third")]
    public IActionResult Third(SomeModel model)
    {
        return new OkObjectResult(new Response(){ProvidedModel = model, message = "wow, nice cock!" });
    }

    [HttpPost("fourth")]
    public IActionResult Fourth(SomeAggregatedModel model)
    {
        return new OkObjectResult(model);
    }

    public class SomeModel
    {
        public string Payload { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
    }

    public class SomeAggregatedModel
    {
        public string Name { get; set; }
        public SomeModel ProvidedModel { get; set; }
    }

    public class Response
    {
        public object ProvidedModel { get; set; }
        public string message { get; set; }
    }
}