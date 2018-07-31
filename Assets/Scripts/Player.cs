using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float playerSpeed;
	private string _CurrentPlayerPosition = "middle";
	public GameObject[] positions;
	void Start () {
		
	}
	
	
	void Update () {
		_CurrentPlayerPosition = DetectChangePosition(_CurrentPlayerPosition);
		PlayerMoviment();
	}

	private void PlayerMoviment(){
		string[] _tempDirections = new string[]{"down", "middle", "up"};
		for(int i = 0; i < positions.Length; i++){
			if (_tempDirections[i] == _CurrentPlayerPosition){
				transform.localPosition = Vector3.MoveTowards(transform.position, positions[i].transform.position, playerSpeed * Time.deltaTime);
			}
		}
		
	}

	private string DetectChangePosition(string _playerPosition){
		float _Direction;
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			_Direction = 1;
		} else if(Input.GetKeyDown(KeyCode.DownArrow)){
			_Direction = -1;
		}else{
			_Direction = 0;
		}

		switch(_playerPosition){
			case "middle":
				if (_Direction > 0){
					return "up";
				}else if (_Direction < 0){
					return "down";
				}else{
					return "middle";
				}
			case "down":
				if(_Direction > 0){
					return "middle";
				}else{
					return "down";
				}
			case "up":
				if(_Direction < 0){
					return "middle";
				}else{
					return "up";
				}	
		}
		return _playerPosition;
	}
}
