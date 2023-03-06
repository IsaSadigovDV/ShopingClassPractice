
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

internal class User
{
    private string _userName;
    private string _password;

    public string UserName { get => _userName;
        set { 
            if (value.Length > 0 &&
            value.Length < 30 && !string.IsNullOrWhiteSpace(value))
            {
                _userName = value;
            }
            else
            {
                Console.WriteLine("Username must be minimum 3 and maximum 30 charactes");
            }
          }
        }
    public string Password { get => _password; set { if(value.Length >=8 && 
                value.Length < 30 && !string.IsNullOrWhiteSpace(value))
            {
                _password = value;
               
            }
            else
            {
                Console.WriteLine("Password must be minimum 8 and maximum 30 characters");
            }
        } 
    }

    public User(string username, string password)
    {
        if (username == _userName && password == _password)
        {
            _userName = username;
            _password = password;
        }
        else
        {
            Console.WriteLine("Your username or password is wrong. Please try again");
        }
    }

    public void CheckPassword()
    {
        // constructorda islemelidir
        string UserPassword = Console.ReadLine();
        Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])" +
            "(?=.*?[0-9]).{8,}$");
        if(validateGuidRegex.IsMatch(UserPassword))
        {
            _password = UserPassword;
        }
        else
        {
            Console.WriteLine("Password must be at least 8 character, " +
                "one digit and one Uppercase character ");
        }
    }

    public void SetPassword()
    {
        //ncamsulationda cagrilmalidir
        if(Password != null) 
        {
            Password = _password;
        }
        else
        {
            Console.WriteLine("Please generate password correctly!");
        }

    }


}

