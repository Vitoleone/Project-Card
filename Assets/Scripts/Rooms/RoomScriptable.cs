using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Room", menuName = "ScriptableObject/Room")]
public class RoomScriptable : ScriptableObject
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
