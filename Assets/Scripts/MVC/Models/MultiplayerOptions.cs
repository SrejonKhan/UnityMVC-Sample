using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is Model Class
/// </summary>
public class MultiplayerOptions
{
    public int totalPlayersRequired;
    public string roomName;
    public string gameType;

    public MultiplayerOptions(int totalPlayersRequired, string roomName, string gameType)
    {
        this.totalPlayersRequired = totalPlayersRequired;
        this.roomName = roomName;
        this.gameType = gameType;
    }
}
