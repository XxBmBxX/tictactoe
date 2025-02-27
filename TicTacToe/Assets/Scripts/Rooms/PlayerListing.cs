﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Realtime;

public class PlayerListing: MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    public Player Player { get; private set; }
    public void SetPlayerInfo(Player player)
    {
        
        Player = player;
        text.text = player.NickName;
    }
}
