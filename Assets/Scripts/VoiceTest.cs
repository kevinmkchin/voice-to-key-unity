using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceTest : MonoBehaviour
{

    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();


    // Start is called before the first frame update
    void Start()
    {
        actions.Add("up", Up);
        actions.Add("uh", Up);
        actions.Add("op", Up);
        actions.Add("cup", Up);
        actions.Add("pup", Up);
        actions.Add("awp", Up);
        actions.Add("down", Down);
        actions.Add("dow", Down);
        actions.Add("left", Left);
        actions.Add("f", Left);
        actions.Add("lef", Left);
        actions.Add("ef", Left);
        actions.Add("right", Right);
        actions.Add("write", Right);
        actions.Add("play", Play);
        actions.Add("ay", Play);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
        Debug.Log("Started Voice Recognition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech) {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Right() {
        if (transform.position.x < 1)
        {
            transform.Translate(1, 0, 0);
        }
    }

    private void Left() {
        if (transform.position.x > -1)
        {
            transform.Translate(-1, 0, 0);
        }
    }

    private void Up() {
        if (transform.position.y < 1)
        {
            transform.Translate(0, 1, 0);
        }
    }

    private void Down() {
        if (transform.position.y > -1)
        {
            transform.Translate(0, -1, 0);
        }
    }

    private void Play()
    {
        if (GameManager.died) {
            GameManager.died = false;
            GameManager.score = 0;
            GameManager.counter = 0;
        }
        Debug.Log("restart");
    }

}
