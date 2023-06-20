using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityMVC;

public class Middlewares : MonoBehaviour
{
    private void Awake()
    {
        Configure();
    }

    private void Configure()
    {
        var middleware = MVC.ConfigureMiddleware();

        middleware.OnRoute("Game/Multi", (ctx, type) =>
        {
            if (!Global.IsAuthenticated)
            {
                MVC.Navigate("Alert/Error", partialView: true, "You are not authenticated!");
                return false;
            }
            return true;
        });

        middleware.OnRoute("Menu/Exit", (ctx, type) => 
        {
            Debug.Log("You better not go, because middleware works in partial view too!");
            return true;
        });
        
        // multiple configurations example
        middleware.OnRoute("Alert/*", (ctx, type) => 
        {
            Debug.Log("Config 1: Alert/* - This is alert for all!");
            return true;
        });

        middleware.OnRoute("Alert/*", (ctx, type) =>
        {
            Debug.Log("Config 2: Alert/* - This is alert for all!");
            return true;
        });
    }
}
