using UnityEngine;
using UnityMVC;

public class GamePauseMenuView : ViewContainer
{
    public GameObject holderGameObject;
    private GameObject previousMvcRoot;
    private ActionResult lastNestedSubMenu;

    private void OnEnable()
    {
        // we are setting MVC root to this view's holder.
        // just because we want partial views to be instantiated in the holder.
        previousMvcRoot = MVC.Root;
        MVC.Root = holderGameObject;
        Global.IsPauseMenuOpened = true;
    }

    private bool Restore()
    {
        // if any nested sub-menu in pause menu is active
        if(lastNestedSubMenu != null && lastNestedSubMenu.InstantiatedObject != null)
        {
            Destroy(lastNestedSubMenu.InstantiatedObject);
            lastNestedSubMenu.ReleaseAddressableReference();
            lastNestedSubMenu = null;
            return false;
        }

        return true; // indicates successful restoration
    }

    public bool TryResume()
    {
        bool restoreResult = Restore();
        if (!restoreResult) return false;
        
        Destroy(gameObject);
        return true;
    }

    public override void NavigatePartial(string route)
    {
        lastNestedSubMenu = base.NavigatePartialActionResult(route);
    }

    public void OnResumeButtonClick()
    {
        TryResume();
    }

    public void OnMainMenuButtonClick()
    {
        Restore();
        Destroy(gameObject);
        MVC.ClearHistory();
        MVC.Navigate("Menu/Index");
    }

    private void OnDisable()
    {
        MVC.Root = previousMvcRoot;
        Global.IsPauseMenuOpened = false;
    }
}
