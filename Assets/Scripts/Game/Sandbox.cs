using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityMVC;

public class Sandbox : MonoBehaviour
{
    public MvcInitializer mvcInitializer;

    // Start is called before the first frame update
    void Awake()
    {
        //MVC.ConfigureMiddleware().OnRoute("Game/Multi", (ctx, type) => 
        //{
        //    if (!Global.IsAuthenticated)
        //    {
        //        MVC.Navigate("Alert/Error", partialView: true, "You are not authenticated!");
        //        return false;
        //    }

        //    // some other works
        //    return true; 
        //});

        //mvcInitializer.onLayoutInstantiated.AddListener((go) =>
        //{
        //    MVC.Root = go.transform.GetChild(1).gameObject;
        //    Debug.Log(go.name);
        //});

        //MVC.BeforeNavigate += (actionResult, type) =>
        //{
        //    if (type == ActionType.View)
        //        Debug.Log("View");

        //    if (type == ActionType.PartialView)
        //        Debug.Log("Partial View");

        //    return false;
        //};


        //MVC.OnNavigated += (actionResult, type) =>
        //{
        //    if (type == ActionType.View)
        //        Debug.Log("View");

        //    if (type == ActionType.PartialView)
        //        Debug.Log("Partial View");
        //};

        //var home = MVC.Navigate("Home/Index/12", new Product("Polyfill"));
        //var about = MVC.Navigate("Home/About");
        //MVC.Navigate("Home/Analytics/");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Product
{
    public string name;
    public Product(string name)
    {
        this.name = name;
    }
}
