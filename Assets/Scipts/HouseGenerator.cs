using System.Collections.Generic;
using UnityEngine;

public class HouseGenerator : MonoBehaviour
{
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
        numOfRooms = Random.Range(0, 10);

        Debug.Log("Floors = " + numOfFloors + " Rooms = " + numOfRooms);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
