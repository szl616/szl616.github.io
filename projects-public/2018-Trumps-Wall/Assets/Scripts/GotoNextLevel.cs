using UnityEngine;
using System.Collections;

public class GotoNextLevel : MonoBehaviour {
    public int NextLevelIndex;
    // Use this for initialization
    void Start () {
        int CurrentLevel = Application.loadedLevel;
        NextLevelIndex = CurrentLevel + 1;
    }
	
	// Update is called once per frame
	void Update () {


        
	
	}

    void OnMouseDown()
    {
        Debug.Log("You've clicked on me");
        NextLevel();
    }
    public void NextLevel()
    {
        

        Application.LoadLevel(NextLevelIndex);
    }
}
