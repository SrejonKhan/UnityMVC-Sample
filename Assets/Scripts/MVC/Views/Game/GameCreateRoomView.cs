// This is generated code by UnityMVC Scaffolder
// This can be added to any gameobject as Component
// ViewContainer derives from MonoBehaviour
// ViewContainer provides some property

using System;
using UnityEngine.UI;
using UnityMVC;

public class GameCreateRoomView : ViewContainer
{
    public InputField roomNameInputField;
    public InputField gameTypeInputField;
    public InputField playerRequiredInputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
        base.ReleaseAddressableReference();
    }

    public void OnStartButtonClick()
    {
        int playerRequired = Convert.ToInt32(playerRequiredInputField.text);
        string roomName = roomNameInputField.text;
        string gameType = gameTypeInputField.text;

        MultiplayerOptions multiplayerOptions = new MultiplayerOptions(playerRequired, roomName, gameType);
        MVC.Navigate("Game/Multi", multiplayerOptions);
        DestroySelf();
    }

    public void OnCloseButtonClick()
    {
        DestroySelf();
    }
}
