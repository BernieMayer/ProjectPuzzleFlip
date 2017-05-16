using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneScript : MonoBehaviour {


	public GameObject[] gamePieces;	

	// Use this for initialization
	void Start () {

		Debug.Log("Test");

		for (int i = 0; i < gamePieces.Length ; i++) {
			GameObject gamePiece = gamePieces [i];

			GameObject aObject = new GameObject ();
			//aObject.transform.
			if (gamePiece.tag == "GreenPiece") {
				
				
				//gamePiece.transform.position.x += 0.1f;
				Debug.Log ("Found a green Piece");

			}
		}
		//Console.Log ("LevelOneScriptCalled");
	}
	
	// Update is called once per frame
	void Update () {

	}
}
