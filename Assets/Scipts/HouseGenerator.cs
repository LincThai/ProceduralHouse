using System.Collections.Generic;
using UnityEngine;

public class HouseGenerator : MonoBehaviour
{
    public float floorHeight = 3.0f;

    // numbers for random generation
    [Header("Randomly Generated Values")]
    public int numOfFloors;
    public int floorType;
    public int numOfRooms;

    // Storage of gameObjects/prefabs to instantiate
    [Header("List of Generated Objects")]
    public List<GameObject> floorTypes = new List<GameObject>();
    public List<GameObject> roomTypes = new List<GameObject>();

    List<GameObject> currentHouseComp = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // random number generation
        numOfFloors = Random.Range(1, 4);
        Debug.Log(numOfFloors + " floors");
        floorType = Random.Range(0, floorTypes.Count);
        // make an array to store the number of room per floor
        // with the length of the arrey equal to the number of floors
        int[] floorRooms = new int[numOfFloors];

        // integer for assigning values to array
        int n = 0;
        do
        {
            // assign random values in 
            numOfRooms = Random.Range(1, 10);
            floorRooms[n] = numOfRooms;
            Debug.Log(floorRooms[n] + " Rooms");
            n++;
        } while (n < numOfFloors);

        
        for (int i = 0; i < floorRooms.Length; i++)
        {
            // spawn a floor every 3m then add to a list to later be destroyed
            GameObject floor = Instantiate(floorTypes[floorType], new Vector3(0, i * 3, 0), Quaternion.identity);
            currentHouseComp.Add(floor);

            for (int j = 0; j < floorRooms[i]; j++)
            {
                // spawn room as child of the floor then change transform.localPosition then
                // add to the list to later be destroyed 
                GameObject room = Instantiate(roomTypes[Random.Range(0, roomTypes.Count)],
                    new Vector3(0, 0, 0), Quaternion.identity, floor.transform);
                // calculate the position and move
                room.transform.localPosition = new Vector3(j, 1, 0);
                currentHouseComp.Add(room);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetHouse();
            Start();
        }
    }

    void ResetHouse()
    {
        // destroy all the game objects spawned
        for (int i = 0; i < currentHouseComp.Count; i++)
        {
            Destroy(currentHouseComp[i]);
        }
        currentHouseComp.Clear();
    }
}
