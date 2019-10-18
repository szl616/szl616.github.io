using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickNumber : MonoBehaviour {
    public GameObject NextLevel;

    [Header("Numbers")]
    public int MaxNumber;    
    public int numberToPick;

    [Header("Random number")]
    public int[] numbers = new int[10];
    public string usedNumbers = "-";

    [Header("Random number")]
    public int[] numbers0To9 = new int[10];
    public string usedNumbers0To9 = "-";

    [Header("Prefab for generating number")]
    public GameObject prefabNumber;

    [Header("Start and End position for visual")]
    public Vector3 visualStartPosition;
    public Vector3 visualEndPositiion;
    public Vector3[] visualPos = new Vector3[10];

    private GameObject[] _Numbers = new GameObject[10];

    

    // Use this for initialization
    void Start () {

        NextLevel.SetActive(false);

        //Pick the number that shall be picked
        numberToPick = Random.Range(0, MaxNumber);

        usedNumbers += "-";
        usedNumbers += numberToPick.ToString() + "-";
        numbers[0] = numberToPick;

        for (int i = 1; i < 10; i++)
        {
            int randomNumber = Random.Range(0, MaxNumber);

            while (usedNumbers.Contains("-" + randomNumber.ToString() + "-"))
            {
                randomNumber = Random.Range(0, MaxNumber);
            }

            usedNumbers += randomNumber.ToString() + "-";
            numbers[i] = randomNumber;

        }

        for (int i = 0; i < 10; i++)
        {
            int randomNumber = Random.Range(0, 10);

            while (usedNumbers0To9.Contains("-" + randomNumber.ToString() + "-"))
            {
                randomNumber = Random.Range(0, 10);
            }

            usedNumbers0To9 += randomNumber.ToString() + "-";
            numbers0To9[i] = randomNumber;

        }

        for (int i = 0; i < 10; i++)
        {
            if (i < 5)
            {
                visualPos[i] = new Vector3(-700 + (1750 / 5) * i,
                                            380,
                                            0);
            }
            else
            {
                visualPos[i] = new Vector3(-700 + (1750 / 5) * (i-5),
                                            30,
                                            0);
            }
        }




        SpawnNumbers();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangePosition()
    {
        usedNumbers0To9 = "-";
        for (int i = 0; i < 10; i++)
        {
            int randomNumber = Random.Range(0, 10);

            while (usedNumbers0To9.Contains("-" + randomNumber.ToString() + "-"))
            {
                randomNumber = Random.Range(0, 10);
            }

            usedNumbers0To9 += randomNumber.ToString() + "-";
            numbers0To9[i] = randomNumber;

        }

        SpawnNumbers();
    }

    void SpawnNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            if(_Numbers[i] != null)
            {
                Destroy(_Numbers[i]);
            }

            _Numbers[i] = Instantiate(prefabNumber,
                                        visualPos[numbers0To9[i]],
                                        Quaternion.identity);

            _Numbers[i].GetComponent<NumberProperties>().number = numbers[i];
            _Numbers[i].transform.SetParent(gameObject.transform, false);
        }
    }

    public bool CheckAnswer(int answer)
    {
        if (answer == numberToPick)
        {
            NextLevel.SetActive(true);
            return true;
        }
        else
        {
            return false;
        }
    }
}
