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
        actions.Add("down", Down);
        actions.Add("left", Left);
        actions.Add("right", Right);

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
        transform.Translate(1, 0, 0);
    }

    private void Left() {
        transform.Translate(-1, 0, 0);
    }

    private void Up() {
        transform.Translate(0, 1, 0);
    }

    private void Down() {
        transform.Translate(0, -1, 0);
    }

}
