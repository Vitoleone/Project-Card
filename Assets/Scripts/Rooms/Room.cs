using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public int floor;
    public int roomIndex;
    public RoomType roomType;
    public enum RoomType
    {
        Normal,
        Cursed,
        MainBoss,
        EliteBoss,
        RandomEvent
    }
}
