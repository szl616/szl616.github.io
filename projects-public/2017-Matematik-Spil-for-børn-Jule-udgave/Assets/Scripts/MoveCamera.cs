using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    [Header("Camera Properties")]
    public float camSpeed = 10;

    [Header("Level")]
    public int currentLevel;

    [Header("State for moving camera")]
    public bool moveToMenu = false;
    public bool moveToLevel = false;
    public bool moveToNextLevel = false;
    public bool moveBackToMenu = false;


    private Vector3 moveToPosition;

    [Header("Levels Gameobjects")]
    public GameObject currentLevelGO;
    public GameObject nextLevelGO;

    public GameObject[] levels;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!CheckForMovingCamera())
                GoBacktoMenu();
        }


        // Gå tilbage til menu
        if (moveBackToMenu)
        {
            moveToPosition = new Vector3(10, 0, -10);
            transform.position = Vector3.Lerp(transform.position, moveToPosition, camSpeed * Time.deltaTime);

            if ((transform.position.x - moveToPosition.x) < 0.1f)
            {
                moveBackToMenu = false;
                Destroy(currentLevelGO);
            }
        }


        // Når man går fra start til Menu
        if (moveToMenu)
            {
                moveToPosition = new Vector3(10, 0, -10);
                transform.position = Vector3.Lerp(transform.position, moveToPosition, camSpeed * Time.deltaTime);

                if ((moveToPosition.x - transform.position.x) < 0.1f)
                {
                    moveToMenu = false;
                }
            }


        // Når man går fra Menu til level
        if (moveToLevel)
        {
            moveToPosition = new Vector3(30, 0, -10);
            transform.position = Vector3.Lerp(transform.position, moveToPosition, camSpeed * Time.deltaTime);

            if ((moveToPosition.x - transform.position.x) < 0.1f)
            {
                moveToLevel = false;
            }
        }


        // Når man går fra level til level
        if (moveToNextLevel)
        {
            currentLevelGO.transform.position = Vector3.Lerp(currentLevelGO.transform.position, 
                                                             new Vector3(10, 0, 0), 
                                                             camSpeed * Time.deltaTime);

            nextLevelGO.transform.position = Vector3.Lerp(nextLevelGO.transform.position, 
                                                          new Vector3(30, 0, 0), 
                                                          camSpeed * Time.deltaTime);

            if((currentLevelGO.transform.position.x-10) < 0.1f || (nextLevelGO.transform.position.x-30) < 0.1f)
            {
                moveToNextLevel = false;
                Destroy(currentLevelGO);
                currentLevelGO = nextLevelGO;
                nextLevelGO = null;
            }
        }
    }

      public bool CheckForMovingCamera()
    {
        if(moveToLevel || moveToMenu || moveToNextLevel || moveBackToMenu)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void GotoMenu()
    {
        if(!CheckForMovingCamera())
            moveToMenu = true;
    }

    public void GoBacktoMenu()
    {
        if (!CheckForMovingCamera())
            moveBackToMenu = true;
    }

    public void GotoLevel(int level)
    {
        if (!CheckForMovingCamera())
        {
            currentLevel = level;
            currentLevelGO = Instantiate(levels[currentLevel - 1], new Vector3(30, 0, 0), Quaternion.identity);
            moveToLevel = true;
        }
    }

    public void NextLevel()
    {
        if (!CheckForMovingCamera())
        {
            nextLevelGO = Instantiate(levels[currentLevel - 1], new Vector3(50, 0, 0), Quaternion.identity);
            //currentLevel++;
            moveToNextLevel = true;
        }
    }

   

}
