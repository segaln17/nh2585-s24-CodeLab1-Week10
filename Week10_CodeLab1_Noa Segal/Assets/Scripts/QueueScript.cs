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
    
    //Button functions to add phrases to the queue:
    public void AddHello() //Greeting 2
    {
        wordQueue.Enqueue("Good tidings.");
        //Debug.Log("I am adding a word");
    }

    public void AddGoodbye() //Greeting 1
    {
        wordQueue.Enqueue("Farewell.");
        //Debug.Log("I am saying goodbye");
    }

    public void AddCasualGreeting() //Greeting 3
    {
        wordQueue.Enqueue("Howdy, buckaroo.");
        //Debug.Log("cowboy greeting");
    }

    public void AskNicely() //Request 1
    {
        wordQueue.Enqueue("Might I get by you, good sir?");
        //Debug.Log("asking nicely");
    }
    
    public void DuelChallenge() //Request 2
    {
        wordQueue.Enqueue("I challenge you to a duel, bucko!");
        //Debug.Log("DUEL ME NOW");
    }

    public void RudeRequest() //Request 3
    {
        wordQueue.Enqueue("Hey, buddy, get outta my way, okay?");
        //Debug.Log("being rude");
    }

    //IN SCENE 2:
    
    public void PositiveResponse() //response 1
    {
        wordQueue.Enqueue("Yes I am, good sir!");
        //Debug.Log("positive");
    }

    public void WeirdResponse() //response 2
    {
        wordQueue.Enqueue("I don't know the meaning of the word.");
        //Debug.Log("weird response");
    }
    
    public void NegativeResponse() //response 3
    {
        wordQueue.Enqueue("You're the weird one, dude.");
        //Debug.Log("negative");
    }
    
    //go from QueueScene to SecondScene:
    public void HearResponse()
    {
        SceneManager.LoadScene("SecondScene");
    }

    //go from SecondScene to EndScene:
    public void Leave()
    {
        SceneManager.LoadScene("EndScene");
    }
    
    
    //I was thinking about making a keyboard so I did this but I'm not using it:
    /*
    public void Alphabet()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            wordQueue.Enqueue("a");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            wordQueue.Enqueue("b");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            wordQueue.Enqueue("c");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            wordQueue.Enqueue("d");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            wordQueue.Enqueue("e");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            wordQueue.Enqueue("f");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            wordQueue.Enqueue("g");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            wordQueue.Enqueue("h");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            wordQueue.Enqueue("i");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            wordQueue.Enqueue("j");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            wordQueue.Enqueue("k");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            wordQueue.Enqueue("l");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            wordQueue.Enqueue("m");
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            wordQueue.Enqueue("n");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            wordQueue.Enqueue("o");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            wordQueue.Enqueue("p");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            wordQueue.Enqueue("q");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            wordQueue.Enqueue("r");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            wordQueue.Enqueue("s");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            wordQueue.Enqueue("t");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            wordQueue.Enqueue("u");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            wordQueue.Enqueue("v");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            wordQueue.Enqueue("w");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            wordQueue.Enqueue("x");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            wordQueue.Enqueue("y");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            wordQueue.Enqueue("z");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wordQueue.Enqueue(" ");
        }
    }
    */

    
}
