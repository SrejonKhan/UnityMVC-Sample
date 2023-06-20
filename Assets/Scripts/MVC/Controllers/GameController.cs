using UnityMVC;

public class GameController : MonoController
{
    public ViewResult Single()
    {
        return View();
    }

    public ViewResult Multi(MultiplayerOptions options)
    {
        return View(options);
    }

    public ViewResult PauseMenu()
    {
        return View();
    }

    public ViewResult CreateRoom()
    {
        return View();
    }
}

