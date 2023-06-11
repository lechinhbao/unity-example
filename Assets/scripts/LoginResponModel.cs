using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LoginResponModel
{
    public LoginResponModel(int status, string id, string email, string name, int age, int score, string scene, float positionx, float positiony, float positionz)
    {
        //  this.status = status;
        //    this.notification = notification;
        //  this.username = username;
        //  this.score = score;
        //this.positionX = positionX;
        // this.positionY = positionY;
        // this.positionZ = positionZ;
        this.status = status;
        this.id = id;
        this.email = email;
        this.name = name;
        this.age = age;
        this.score = score;
        this.scene = scene;
        this.positionx = positionx;
        this.positiony = positiony;
        this.positionz = positionz;
    }

    //public int status { get; set; }
    //public string notification { get; set; }
    //public int username { get; set; }
   // public int score { get; set; }
   // public int positionX { get; set; }
   // public int positionY { get; set; }
   // public int positionZ { get; set; }



    public int status { get; set; }
    public string id { get; set; }
    public string email { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public int score { get; set; }
    public string scene { get; set; }
    public float positionx { get; set; }
    public float positiony { get; set; }
    public float positionz { get; set; }

}

   




