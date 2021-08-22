using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameHolder : MonoBehaviour
{
    public static PlayerNameHolder Intance;
    public string PlayerName;

    void Awake()
    {
        if(Intance != null)
        {
            Destroy(gameObject);
            return;
        }

        Intance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetPlayerName(string playerName)
    {
        Intance.PlayerName = playerName;
    }

    public string GetPlayerName()
    {
        return PlayerName;
    }
}
