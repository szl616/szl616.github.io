using UnityEngine;
using System.Collections;

public class PickDestination : MonoBehaviour {

    

    public static GameObject[] house;
    public static int[] RandomNumber;
    public int AmountOfPickUpDest = 1;

    public string usedNumbers = "-";
    // Use this for initialization
    void Start () {
        
        house = GameObject.FindGameObjectsWithTag("House");

        Invoke("DestinationLocation", 1f);
        RandomNumber = new int[house.Length];
        

    }
	
	// Update is called once per frame
	void Update () {
       


    }

    void DestinationLocation()
    {
        usedNumbers = "-";
        

        for (int i = 0; i < RandomNumber.Length; i++)
        {
            int randomNumber = Random.Range(0, RandomNumber.Length);

            /*
            Checking if the random number you get is unique, if you already have 
            it in the string means that this random number is repeated, the "-X-" is 
            to make the difference between the numbers, like -1- from -11-, if 
            you dont have the "-X-" the 1 is in 21 and would be a "repeated" number
            */
            while (usedNumbers.Contains("-" + randomNumber.ToString() + "-"))
            {
                //if a number is repeated, then get a new random number
                randomNumber = Random.Range(0, RandomNumber.Length);
            }
            usedNumbers += randomNumber.ToString() + "-";
            RandomNumber[i] = randomNumber;
        }

        




    }

    

    public void PickDest()
    {
        DestinationLocation();
        
        



        for (int i = 0; i < AmountOfPickUpDest; i++)
        {
            house[RandomNumber[i]].SendMessage("DeliveryPointActivate",i+1);
            PlayerStats.Pizza = AmountOfPickUpDest;
        }
        
    }
}
