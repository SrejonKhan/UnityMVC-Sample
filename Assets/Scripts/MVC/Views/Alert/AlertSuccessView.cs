using UnityEngine.UI;
using UnityMVC;

public class AlertSuccessView : ViewContainer
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
