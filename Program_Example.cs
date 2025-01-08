// using System;
// using System.Collections.Generic;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Prompt the user for input
//         Console.WriteLine("Enter a notification title:");
//         string userInput = Console.ReadLine();

//         // Call the method with the user input and display the result
//         string output = ParseNotificationChannels(userInput);
//         Console.WriteLine(output);
//     }

//     static string ParseNotificationChannels(string title)
//     {
//         // Define valid notification channels
//         string[] validChannels = { "BE", "FE", "QA", "Urgent" };

//         // Regex to extract tags within square brackets
//       //   var regex = new Regex(@"\[(.*?)\]"); 
//         var regex = new Regex(@"\[(.*?)\]");
//         var matches = regex.Matches(title);

//         // List to store identified channels
//         List<string> channels = new List<string>();

//         // Iterate through matches and filter valid channels
//         foreach (Match match in matches)
//         {
//             string tag = match.Groups[1].Value;
//             foreach (var validChannel in validChannels)
//             {
//                 if (tag == validChannel && !channels.Contains(tag))
//                 {
//                     channels.Add(tag);
//                 }
//             }
//         }

//         // Format the output
//         if (channels.Count > 0)
//         {
//             return $"Receive channels: {string.Join(", ", channels)}";
//         }
//         else
//         {
//             return "No valid channels found.";
//         }
//     }
// }
