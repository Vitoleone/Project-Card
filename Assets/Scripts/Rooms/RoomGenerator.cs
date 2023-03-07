using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using DG.Tweening;

public class RoomGenerator : MonoBehaviour
{
   [SerializeField] GameObject room;
   [SerializeField] GameObject roomPanel;
   [SerializeField] List<GameObject> rooms;
   private int floor = 1;
   private int numberOfCreated = 1;

   private void Start()
   {
      GenerateRooms();
      DeleteRandomRoom();
   }

   public void GenerateRooms()
   {
      Room roomComponent = room.GetComponent<Room>();
      for (int i = 0; i < 35; i++)
      {
         roomComponent.roomIndex = numberOfCreated;
         roomComponent.floor = floor;
         if (numberOfCreated >= 6)
         {
            numberOfCreated = 1;
            floor++;
         }
         
         GameObject newRoom = Instantiate(room,roomPanel.transform.position,quaternion.identity);
         newRoom.transform.parent = roomPanel.transform;
         newRoom.transform.localScale = Vector3.one;
         rooms.Add(newRoom);
         numberOfCreated++;
      }
   }

   public void DeleteRandomRoom()
   {
      int deletedRoomNumber = 0;
      int checkedRoom = 0;
      foreach (var vRoom in rooms)
      {
         int randomInt = Random.Range(1, 100);
         if (randomInt <= 40 && deletedRoomNumber < 3)
         {
            
            vRoom.GetComponent<Image>().DOFade(0,0);
            deletedRoomNumber++;
            checkedRoom++;
         }
         else if (deletedRoomNumber >= 3 && checkedRoom < 5)
         {
            checkedRoom++;
         }
         else
         {
            checkedRoom = 0;
            deletedRoomNumber = 0;
         }
      }
   }
}
