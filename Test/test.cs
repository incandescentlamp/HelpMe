using System;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Test;

public class test
{
    public static void Main(string[] args)
    {
        var postRequest = HttpRequestBuilder.Post("https://api.example.com/users");
        Console.WriteLine(postRequest);
    }
}
