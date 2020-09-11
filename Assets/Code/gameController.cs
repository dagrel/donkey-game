
using UnityEngine;
using UnityEngine.UI;


public class gameController : MonoBehaviour
{
    public GameObject Donkey;
    public float positionA;
    public float positionB;
    public int points;
    public bool gameOver;

    void Start()
    {
        positionA = GameObject.Find("Car").GetComponent<carController>().positionA;
        positionB = GameObject.Find("Car").GetComponent<carController>().positionB;

        // place new donkey every 0,5 sec
        InvokeRepeating("PlaceDonkey", 0.5f, 0.5f);
    }

    void PlaceDonkey()
    {
        if (!gameOver)
        {
            int oneOrZero = UnityEngine.Random.Range(0, 2);

            if (oneOrZero == 0)
            {
                Instantiate(Donkey, new Vector3(positionA, -0.3f, 9), Quaternion.Euler(0, -180, 0));
            }
            else
            {
                Instantiate(Donkey, new Vector3(positionB, -0.3f, 9), Quaternion.Euler(0, -180, 0));

            }

            points++;
            GameObject.Find("Text").GetComponent<Text>().text = "Points: " + points;
        }
        else
        {
            GameObject.Find("Text").GetComponent<Text>().text = "Game over! You got " + points + " points.";
        }
    }
}
