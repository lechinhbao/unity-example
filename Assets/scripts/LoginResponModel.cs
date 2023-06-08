using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LoginResponModel
{
    public LoginResponModel(int status, string notification, int username, int score, int positionX, int positionY, int positionZ)
    {
        this.status = status;
        this.notification = notification;
        this.username = username;
        this.score = score;
        this.positionX = positionX;
        this.positionY = positionY;
        this.positionZ = positionZ;
    }

    public int status { get; set; }
    public string notification { get; set; }
    public int username { get; set; }
    public int score { get; set; }
    public int positionX { get; set; }
    public int positionY { get; set; }
    public int positionZ { get; set; }
    
}

   




