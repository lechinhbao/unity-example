using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class UserModel 
{
    public UserModel(string email, string password) {
        this.email = email;
        this.password = password;
    }
    public string email { get; set; }
    public string password { get; set; }
}
