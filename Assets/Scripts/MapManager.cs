using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{


	public GameObject[] outWallArray;
	public GameObject[] floorArray;

	public int rows=10;
	public int cols=10; 
	 
 	// Use this for initialization
	void Start () {
		InitMap();
	}
	
	// Update is called once per frame
	void Update ()
	{
		

	}

	private void InitMap(){
		for (int x  = 0; x  < cols; x++)
		{
			for (int y = 0; y < rows; y++)
			{
				if (x == 0 || y == 0 || x == cols - 1 || y == rows - 1)
				{

					int index = Random.Range(0, outWallArray.Length);
					GameObject.Instantiate(outWallArray[index], new Vector3(x, y, 0), Quaternion.identity);
				}
				else
				{
					int index = Random.Range(0, floorArray.Length);
					GameObject.Instantiate(floorArray[index], new Vector3(x, y, 0), Quaternion.identity);
				}
			}
			
			
				
		
			
		}
		
		
		 
	}
	
	
	
	 
}
