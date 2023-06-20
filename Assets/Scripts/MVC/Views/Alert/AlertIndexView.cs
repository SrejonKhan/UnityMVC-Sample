// This is generated code by UnityMVC Scaffolder
// This can be added to any gameobject as Component
// ViewContainer derives from MonoBehaviour
// ViewContainer provides some property

using UnityEngine.UI;
using UnityMVC;

public class AlertIndexView : ViewContainer
{
    public Text messageText;

    [Invoke]
    public void ShowMessage()
    {
        messageText.text = (string)Model; 
    }

    public void Close()
    {
        Destroy(gameObject);
    }
}
