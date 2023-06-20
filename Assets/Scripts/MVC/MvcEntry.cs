using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityMVC;

public class MvcEntry : MonoBehaviour
{
    public string entryRoute = "Menu/Index";
    public bool testMode = false;
    public string testEntryRoute = "Game/Single";

    void Start()
    {
        if (testMode)
            MVC.Navigate(testEntryRoute);
        else
            MVC.Navigate(entryRoute);
    }
}
