using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Infrastructure.Attributes;

public class EmailRegEx : ValidationAttribute
{
    //create method to check if email is valid with a regular expression
    private readonly string _regEx = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*\.[a-zA-Z]{2,}$";

    public override bool IsValid(object? value)
    {
        return value is string s && new Regex(_regEx).IsMatch(s);
    }



}
