using UnityEngine;
using UnityEngine.UI;
using UnityMVC;

public class MenuIndexView : ViewContainer
{
    public Toggle authenticationToggle;

    void Start()
    {
        authenticationToggle.isOn = Global.IsAuthenticated;
        authenticationToggle.onValueChanged.AddListener(OnAuthenticateToggleChanged);
    }

    void Update()
    {
        
    }

    public void OnAuthenticateToggleChanged(bool value)
    {
        Global.IsAuthenticated = value;
    }

    public void OnMultiplayerButtonClick()
    {
        MVC.Navigate("Game/CreateRoom", true);
    }
}
