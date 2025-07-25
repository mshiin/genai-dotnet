
using Microsoft.Extensions.AI;

// dotnet add package Microsoft.Extensions.AI.Ollama --version 9.7.1

IChatClient client =
    new OllamaChatClient(new Uri("http://localhost:11434/"), "phi4-mini");

var response = client.GetStreamingResponseAsync("What is .NET?");
await foreach (var item in response)
{
    Console.Write(item);
}