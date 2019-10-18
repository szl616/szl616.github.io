using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlusOpgave : MonoBehaviour {

	[Header("Numbers")]
	public int MaxNumber;
	public int num1;
	public int num2;
	public int result;

    [Header("For text GO")]
    public string question;
    
    [Header("Random number")]
    public int[] numbers = new int[4];
    public string usedNumbers = "-";

    public int[] numbersForVisual = new int[4];
    public string usedNumbersForVisual = "-";


    [Header("Prefab for generating number")]
	public GameObject prefabNumber;

    [Header("Prefab for visual numbers")]
    public GameObject[] visualGO;

    [Header("Start and End position for visual")]
    public Vector3 visualStartPosition;
    public Vector3 visualEndPositiion;
    public Vector3[] visualPosition = new Vector3[4];

    [Header("Visual Scale value")]
    public float scaleMin;
    public float scaleMax;


	// Use this for initialization
	void Start () {
        visualPosition[0] = new Vector3(-700, -350, 0);
        visualPosition[1] = new Vector3(-350, -350, 0);
        visualPosition[2] = new Vector3(0, -350, 0);
        visualPosition[3] = new Vector3(350, -350, 0);



        num1 = Random.Range (0, MaxNumber);
		num2 = Random.Range (0, MaxNumber);
		result = num1 + num2;

        for (int i = 0; i < num1; i++)
        {
            GameObject tempGO = Instantiate(visualGO[Random.Range(0, visualGO.Length)],
                                            new Vector3(-800+(i*(700/num1)),
                                                        Random.Range(visualStartPosition.y, visualEndPositiion.y),
                                                        Random.Range(visualStartPosition.z, visualEndPositiion.z)),
                                            Quaternion.identity);

            tempGO.transform.SetParent(gameObject.transform, false);
            float scaleValue = Random.Range(scaleMin, scaleMax);
            tempGO.transform.localScale = new Vector3(scaleValue,
                                                      scaleValue,
                                                      scaleValue);
        }

        for (int i = 0; i < num2; i++)
        {
            GameObject tempGO = Instantiate(visualGO[Random.Range(0, visualGO.Length)],
                                            new Vector3(100 + (i * (700 / num2)),
                                                        Random.Range(visualStartPosition.y, visualEndPositiion.y),
                                                        Random.Range(visualStartPosition.z, visualEndPositiion.z)),
                                            Quaternion.identity);

            tempGO.transform.SetParent(gameObject.transform, false);
            float scaleValue = Random.Range(scaleMin, scaleMax);
            tempGO.transform.localScale = new Vector3(scaleValue,
                                                      scaleValue,
                                                      scaleValue);
        }




        question = "" + num1 + " + " + num2 + " = ";
        transform.Find("Text").GetComponent<Text>().text = question;

        usedNumbers += result.ToString() + "-";
        numbers[0] = result;

        for (int i = 1; i < 4; i++)
        {
            int randomNumber = Random.Range(0, MaxNumber);

            while(usedNumbers.Contains("-"+randomNumber.ToString()+"-"))
            {
                randomNumber = Random.Range(0, MaxNumber);
            }

            usedNumbers += randomNumber.ToString() + "-";
            numbers[i] = randomNumber;

        }

        for (int i = 0; i < 4; i++)
        {
            int randomNumber = Random.Range(0, 4);

            while (usedNumbersForVisual.Contains("-" + randomNumber.ToString() + "-"))
            {
                randomNumber = Random.Range(0, 4);
            }

            usedNumbersForVisual += randomNumber.ToString() + "-";
            numbersForVisual[i] = randomNumber;

        }

        GameObject _Number1 = Instantiate(prefabNumber, 
                                          visualPosition[numbersForVisual[0]],
                                          Quaternion.identity);

        _Number1.GetComponent<NumberProperties>().number = numbers[0];
        _Number1.transform.SetParent(gameObject.transform, false);


        GameObject _Number2 = Instantiate(prefabNumber,
                                          visualPosition[numbersForVisual[1]], 
                                          Quaternion.identity);

        _Number2.GetComponent<NumberProperties>().number = numbers[1];
        _Number2.transform.SetParent(gameObject.transform, false);


        GameObject _Number3 = Instantiate(prefabNumber,
                                          visualPosition[numbersForVisual[2]], 
                                          Quaternion.identity);

        _Number3.GetComponent<NumberProperties>().number = numbers[2];
        _Number3.transform.SetParent(gameObject.transform, false);


        GameObject _Number4 = Instantiate(prefabNumber,
                                          visualPosition[numbersForVisual[3]], 
                                          Quaternion.identity);

        _Number4.GetComponent<NumberProperties>().number = numbers[3];
        _Number4.transform.SetParent(gameObject.transform, false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public bool CheckAnswer(int _Number)
    {
        if(_Number == result)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
