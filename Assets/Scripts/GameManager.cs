using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    public static int counter;
    public static int score;
    public Text Counter_Text;
    public static bool died;

    public Text GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        died = false;
        score = 0;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!died)
        {
            GameOverText.enabled = false;

            if (counter >= 240)
            {

                System.Random random = new System.Random();


                int x = random.Next(-1, 2);
                int y = random.Next(-1, 2);
                Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);

                x = random.Next(-1, 2);
                y = random.Next(-1, 2);
                Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);

                x = random.Next(-1, 2);
                y = random.Next(-1, 2);
                Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);

                if (score >= 3) {
                    x = random.Next(-1, 2);
                    y = random.Next(-1, 2);
                    Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);

                    x = random.Next(-1, 2);
                    y = random.Next(-1, 2);
                    Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);
                    while (GameObject.FindGameObjectsWithTag("box").Length < 4)
                    {
                        x = random.Next(-1, 2);
                        y = random.Next(-1, 2);
                        Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);
                    }
                }

                if (score >= 7) {

                    x = random.Next(-1, 2);
                    y = random.Next(-1, 2);
                    Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);

                    x = random.Next(-1, 2);
                    y = random.Next(-1, 2);
                    Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);

                    while (GameObject.FindGameObjectsWithTag("box").Length < 6)
                    {
                        x = random.Next(-1, 2);
                        y = random.Next(-1, 2);
                        Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);
                    }
                }

                if (score >= 12)
                {

                    x = random.Next(-1, 2);
                    y = random.Next(-1, 2);
                    Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);

                    while (GameObject.FindGameObjectsWithTag("box").Length  < 7) {
                        x = random.Next(-1, 2);
                        y = random.Next(-1, 2);
                        Instantiate(obstacle, new Vector3(x, y, 7), Quaternion.identity);
                    }
                }


                Debug.Log("spawn obstacles");

                counter = 0; //reset counter to 0
                score++;
            }

            Debug.Log(score.ToString());
            Counter_Text.text = "Score: " + score.ToString();
            counter += 1;
        }
        else {
            GameOverText.enabled = true;
        }
    }
}
