using System;
using System.Collections.Generic;

class Program 
{      
   // Define channels
   static string[] validChannels = {"BE", "FE", "Urgent"};
   static List<string> inputChannels = new List<string>();
   static List<string> receivedChannels = new List<string>();

   static void Main(string[] args)
   {
      // Get user input
      Console.Write("Enter the notification title: ");
      string input = Console.ReadLine();

      // Output
      string output = NotificationChannelsParser(input);
      Console.WriteLine(output);

   }

   static string NotificationChannelsParser(string input)
   {
      // Find the first '[' and last ']' of user input
      int firstBracket = input.IndexOf('[');
      int lastBracket = input.LastIndexOf(']');

      if (firstBracket == -1 || lastBracket == -1 || firstBracket >= lastBracket)
      {
         return "No input channels found.";
      } 
      else 
      {
         string content = input.Substring(firstBracket, lastBracket - firstBracket + 1);
         string[] extractedInput = content.Split('[');

         // Extract each channel title from user input
         foreach(String i in extractedInput) {
            if (i.Length > 0) 
            {
               char lastCharacter = i[i.Length -1];
               if (lastCharacter == ']')
               {
                  inputChannels.Add(i.Substring(0, i.Length -1));
               }
            }
         }

         // Check if the input channel title is match
         foreach(String i in inputChannels) {
            foreach(String j in validChannels) {
               if (i == j) {
                  receivedChannels.Add(i);
                  break;
               }
            }
         }

         // Return the output
         if (receivedChannels.Count > 0)
         {
            return "Received channels: " + string.Join(", ", receivedChannels);
         }
         else
         {
            return "No valid channels found.";
         }
      }
   }
}