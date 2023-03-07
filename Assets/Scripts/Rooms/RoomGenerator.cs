using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
   [SerializeField] private List<Sprite> roomImages;
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
         AssingRoomType(roomComponent);
         SetRoomImage(roomComponent);
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

   public void SetRoomImage(Room roomComponent)
   {
      if (roomComponent.roomType == Room.RoomType.MainBoss)
      {
         roomComponent.roomImage = FindWantedSprite("BossRoom");
      }
      else if (roomComponent.roomType == Room.RoomType.Cursed)
      {
         roomComponent.roomImage = FindWantedSprite("CursedRoom");
      }
      else if (roomComponent.roomType == Room.RoomType.EliteBoss)
      {
         roomComponent.roomImage = FindWantedSprite("EliteRoom");
      }
      else if (roomComponent.roomType == Room.RoomType.Normal)
      {
         roomComponent.roomImage = FindWantedSprite("NormalRoom");
      }
      else if (roomComponent.roomType == Room.RoomType.RandomEvent)
      {
         roomComponent.roomImage = FindWantedSprite("RandomEvent");
      }
      
   }

   public Sprite FindWantedSprite(string spriteName)
   {
      var image = (from img in roomImages
         where img.name.Equals(spriteName)
         select img).ToList();
      return image[0];
   }
   public void AssingRoomType(Room roomComponent)
   {
      int randomValue = Random.Range(0, 100);
      if (randomValue <= 5)
      {
         roomComponent.roomType = Room.RoomType.MainBoss;
      }
      else if (randomValue > 5 && randomValue <=20)
      {
         roomComponent.roomType = Room.RoomType.EliteBoss;
      }
      else if (randomValue > 20 && randomValue <=40)
      {
         roomComponent.roomType = Room.RoomType.Cursed;
      }
      else if (randomValue > 40 && randomValue <=80)
      {
         roomComponent.roomType = Room.RoomType.Normal;
      }
      else if (randomValue > 80 && randomValue <=100)
      {
         roomComponent.roomType = Room.RoomType.RandomEvent;
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
