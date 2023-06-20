using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityMVC;

public class NavLayoutView : ViewContainer
{
    public void ShowAlert()
    {
        string[] randomMsg = {
            @"Now is the winter of our discontent",
            "Made glorious summer by this sun of York;",
            "And all the clouds that lour'd upon our house",
            "In the deep bosom of the ocean buried.",
            "Now are our brows bound with victorious wreaths;",
            "Our bruised arms hung up for monuments;",
            "Our stern alarums changed to merry meetings,",
            "Our dreadful marches to delightful measures."
        };

        MVC.Navigate("Alert/Index", true, randomMsg[Random.Range(0, randomMsg.Length - 1)]);
    }
}
