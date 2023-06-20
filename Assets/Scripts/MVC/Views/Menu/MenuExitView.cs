using UnityMVC;

public class MenuExitView : ViewContainer
{
    public void Close()
    {
        Destroy(gameObject);
    }
}
