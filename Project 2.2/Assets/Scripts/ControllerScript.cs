using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject cubePrefab;
    Vector3 cubePosition;
    public static GameObject airplane;
    public static GameObject activeAirplane;
    public static GameObject[,] cubeGrid;
    int gridX = 16;
    int gridY = 9;
    int airplaneX = 0;
    int airplaneY = 8;

    // Start is called before the first frame update
   
    void Start()
    {
        cubeGrid = new GameObject[gridX, gridY];
        for (int y = 0; y <gridY; y ++)
        {
            for (int x = 0; x < gridX; x++)
            {
                cubePosition = new Vector3(x*2, y*2, 0);
                cubeGrid[x,y] = Instantiate(cubePrefab, cubePosition, Quaternion.identity);
            }
        }
        cubeGrid[airplaneX, airplaneY].GetComponent<Renderer>().material.color = Color.red;
        airplane = cubeGrid[airplaneX, airplaneY];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
