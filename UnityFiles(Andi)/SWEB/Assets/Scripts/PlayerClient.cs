﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerClient : MonoBehaviour
{

    Player player_;

    void Start()
    {
        player_ = GetComponent<Player>();
        if (Network.peerType == NetworkPeerType.Server)
        {
            GetComponentInChildren<Button>().enabled = false;
        }
    }

    void OnGUI()
    {
        //if (Network.peerType == NetworkPeerType.Client)
           // GUI.Label(new Rect(10, 400, 200, 25), "Cards in Deck: " + player_.GetDeck().cards_.Count);
    }
}