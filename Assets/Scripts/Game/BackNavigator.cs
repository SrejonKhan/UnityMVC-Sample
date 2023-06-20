using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using UnityEngine;
using UnityMVC;

public class BackNavigator : MonoBehaviour
{
    public List<string> excludedRoutes = new List<string>();
    public List<string> excludedPartialRoutes = new List<string>();
    public ActionResult lastPartialView;

    private void Awake()
    {
        MVC.ConfigureMiddleware().OnRoute("*", (ctx, type) =>
        {
            if (excludedRoutes.Contains(ctx.RouteUrl))
                return true;

            if (type != ActionType.PartialView)
                return true;

            if (excludedPartialRoutes.Contains(ctx.RouteUrl))
                return true;

            ((PendingViewResult)ctx).OnFulfilled += (actionResult) => lastPartialView = actionResult;
            return true;
        });
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            ExecuteBackNavigation();
    }

    private void ExecuteBackNavigation()
    {
        if (excludedRoutes.Contains(MVC.GetCurrentHistory().RouteUrl))
            return;

        if (lastPartialView != null && lastPartialView.InstantiatedObject == null)
            lastPartialView = null;

        if (lastPartialView != null) 
        {
            /*
            ViewContainer viewComp = ((ViewResult)lastPartialView).ViewContainerComponent;
            Type viewType = viewComp.GetType();
            MethodInfo destroyMethod = viewType.GetMethod("DestroySelf");
            if (destroyMethod != null) destroyMethod.Invoke(lastPartialView, null);
            else
                Destroy(lastPartialView.InstantiatedObject);
            */

            // it's enough though, previous one is written for a possible hack
            Destroy(lastPartialView.InstantiatedObject);
            lastPartialView.ReleaseAddressableReference();
            lastPartialView = null;
            return;
        }

        MVC.NavigateBackward(1);
    }
}
