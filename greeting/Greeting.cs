using Microsoft.AspNetCore.Mvc;

namespace greeting;

public class Greeting
{
    public static String Greet(String name)
    {
        if (name == "") {
            name = "World";
        }
        return $"Hello, {name}!";
    }
}
