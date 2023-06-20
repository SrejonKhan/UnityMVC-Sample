// This is generated code by UnityMVC Scaffolder
// This can be added to any gameobject as Component
// ViewContainer derives from MonoBehaviour
// ViewContainer provides some property

using UnityEngine.UI;
using UnityMVC;

public class GameMultiView : ViewContainer
{
    public Text roomNameText;
    public Text gameTypeText;
    public Text playerStatsText;

    private MultiplayerOptions multiplayerOptions;

    [Invoke]
    private void OnViewInitialized()
    {
        multiplayerOptions = (MultiplayerOptions)Model;
        SetupUI();
    }

    private void SetupUI()
    {
        roomNameText.text = multiplayerOptions.roomName.ToUpper();
        gameTypeText.text = multiplayerOptions.gameType;
        playerStatsText.text = $"{multiplayerOptions.totalPlayersRequired} players required for this Game";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
