using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechRecognition : MonoBehaviour {

	private KeywordRecognizer keywordRecognizer;
	private Dictionary<string, Action> actions = new Dictionary<string, Action>();

	// Use this for initialization
	void Start () {
		actions.Add("forward", Forward);

		keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
		keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
	}
	
	private void RecognizedSpeech(PhraseRecognizedEventArgs speech){
		Debug.Log(speech.text);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void Forward(){

	}
}
