using UnityEngine;
using UnityMVC;

public class GameSingleView : ViewContainer
{
    private ViewResult pauseMenuActionResult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !Global.IsPauseMenuOpened)
        {
            pauseMenuActionResult = (ViewResult)MVC.Navigate("Game/PauseMenu", true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Global.IsPauseMenuOpened)
        {
            ((GamePauseMenuView)pauseMenuActionResult.ViewContainerComponent).TryResume();
        }
    }
}
