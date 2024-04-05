using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;

public class QueueScript : MonoBehaviour
{
    private Queue<string> wordQueue = new Queue<string>();

    public Button responseButton;

    public TextMeshProUGUI display;

    private float timer = 0;
    public float timeLeft = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //if you press space, reload:
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        //if time runs out, return:
        if (timer > timeLeft) return;

        //increment the timer:
        timer += Time.deltaTime;

        //if time is up, update display to reflect this:
        if (timer >= timeLeft)
        {
            display.text = "Time is up!\n";
            ShowQueue();
            responseButton.gameObject.SetActive(true);

        }
        else
        {
            display.text = (timeLeft - timer).ToString("F1");
        }
    }

    //show the queue:
    private void ShowQueue()
    {
        //while there are things in the queue, take them out and display them
        while (wordQueue.Count > 0)
        {
            display.text += "\n" + wordQueue.Dequeue();
        }
    }
    
    public void AddHello()
    {
        wordQueue.Enqueue("Good tidings.");
        Debug.Log("I am adding a word");
    }

    public void AddGoodbye()
    {
        wordQueue.Enqueue("Farewell.");
        Debug.Log("I am saying goodbye");
    }

    public void DuelChallenge()
    {
        wordQueue.Enqueue("I challenge you to a duel, sir.");
        Debug.Log("DUEL ME NOW");
    }

    public void HearResponse()
    {
        SceneManager.LoadScene("EndScene");
    }
}
