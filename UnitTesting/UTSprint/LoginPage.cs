﻿using System;
using System.Text.RegularExpressions;
using UTSprint;

namespace UTSprint
{
public class LoginPage   
{   
          public string UserRegistration(string username,string password)
{
           if(!Regex.Match(username, "^[A-Z][a-zA-Z]*$").Success)  
            {
                              
        throw new ArgumentNullException(username, "UserName should be characters only");

            }
        return("Registration is successful");

           }
       }
}
     
