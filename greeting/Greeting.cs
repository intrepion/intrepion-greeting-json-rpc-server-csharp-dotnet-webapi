using Microsoft.AspNetCore.Mvc;

namespace greeting;

public class Greeting
{
    public static String Greet(String name)
    {
        name = name.Trim();
        if (name == "") {
            name = "World";
        }
        return $"Hello, {name}!";
    }
}
