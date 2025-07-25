﻿
using Microsoft.Extensions.AI;
using System.Text;


// dotnet add package Microsoft.Extensions.AI.Ollama --version 9.7.1

IChatClient client =
    new OllamaChatClient(new Uri("http://localhost:11434/"), "phi4-mini");

StringBuilder prompt = new StringBuilder();
prompt.AppendLine("You will analyze the sentiment of the following product reviews. Each line is its own review. Output the sentiment of each review in a bulleted list and then provide a generate sentiment of all reviews. ");
prompt.AppendLine("I bought this product and it's amazing. I love it!");
prompt.AppendLine("This product is terrible. I hate it.");
prompt.AppendLine("I'm not sure about this product. It's okay.");
prompt.AppendLine("I found this product based on the other reviews. It worked for a bit, and then it didn't.");

// send the prompt to the model and wait for the text completion
var response = await client.GetResponseAsync(prompt.ToString());

Console.WriteLine(response.Text);