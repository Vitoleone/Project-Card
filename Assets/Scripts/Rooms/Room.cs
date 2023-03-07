using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public int floor;
    public int roomIndex;
    public RoomType roomType;
    public Sprite roomImage;
    public enum RoomType
    {
        Normal,
        Cursed,
        MainBoss,
        EliteBoss,
        RandomEvent
    }

    private void Start()
    {
        GetComponent<Image>().sprite = roomImage;
    }
}
