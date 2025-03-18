using System.Collections.Generic;
using UnityEngine;

public class HouseGenerator : MonoBehaviour
{
    public float floorHeight = 3.0f;

    // numbers for random generation
    [Header("Randomly Generated Values")]
    public int numOfFloors;
    public int numOfRooms;

    // Storage of gameObjects/prefabs to instantiate
    [Header("List of Generated Objects")]
    public List<GameObject> floors = new List<GameObject>();
    public List<GameObject> rooms = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // random number generation
        numOfFloors = Random.Range(1, 4);
        Debug.Log(numOfFloors + " floors");
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
            // spawn a floor every 3m
            //Instantiate()

            for (int j = 0; j < floorRooms[i]; j++) { 
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Start();
        }
    }
}
