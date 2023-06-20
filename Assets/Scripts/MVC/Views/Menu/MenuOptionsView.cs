// This is generated code by UnityMVC Scaffolder
// This can be added to any gameobject as Component
// ViewContainer derives from MonoBehaviour
// ViewContainer provides some property

using UnityEngine;
using UnityMVC;

public class MenuOptionsView : ViewContainer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// This view may instantiate as Partial View sometimes.
    /// In case of partial view, we cannot navigate backward,
    /// as partial view is not pushed to history. 
    /// So, we got to destroy it and release the ref.
    /// </summary>
    public void NavigateBackOrClose()
    {
        if(base.ViewResult.NavigationActionType == ActionType.PartialView) 
        {
            Destroy(gameObject);
            base.ReleaseAddressableReference();
        }
        else
        {
            MVC.NavigateBackward(1);
        }
    }
}
