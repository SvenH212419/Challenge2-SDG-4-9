using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData : MonoBehaviour
{
    public int scene;
    
    public PlayerData (Player player)
    {
        scene = player.scene;
    }
}
