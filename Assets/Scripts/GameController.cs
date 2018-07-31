using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public float score, time;
	public Text txtScore, txtTime;
	private float _tempTime, _seconds;

	void Start () {
		_tempTime = time;
		_seconds = 60;
		if(_tempTime % 60 != 0){
			_seconds = _tempTime % 60;
		}
	}
	
	
	void Update () {
		UpdateTime();
	}

	private void UpdateTime(){
		_tempTime -= Time.deltaTime;
		_seconds -= Time.deltaTime;
		txtTime.text = (Mathf.FloorToInt(_tempTime)/60).ToString();
		txtTime.text = txtTime.text + ":" +  Mathf.FloorToInt(_seconds);
		if(_seconds <= 0)
			_seconds = 60;
	}

	private void ConvertTime(){
		Mathf.FloorToInt(_tempTime);
		//int _minute = Mathf.FloorToInt(seconds);

	}
}
