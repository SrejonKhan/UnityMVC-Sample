using UnityMVC;

public class AlertController : MonoController
{
    public ViewResult Success(string message)
    {
        return View((object)message);
    }

    public ViewResult Error(string message)
    {
        return View((object)message);
    }
}

