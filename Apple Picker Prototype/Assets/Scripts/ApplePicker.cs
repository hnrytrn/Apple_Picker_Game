using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour {

	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottomY = -14f;
	public float basketSpacingY = 2f;
	public List<GameObject> basketList;

	// Use this for initialization
	void Start () {
		basketList = new List <GameObject> ();
		for (int i = 0; i < numBaskets; i++) {
			GameObject tBasketGO = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacingY * i);
			tBasketGO.transform.position = pos;
			basketList.Add (tBasketGO);
		}
	
	}
	public void AppleDestroyed() {
		//Destroy all of the falling Apples
		GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
		foreach (GameObject tGO in tAppleArray) {
			Destroy (tGO);
		}

		//Destroy one of the baskets
		int basketIndex = basketList.Count-1;//index of last basket
		//get a reference to that basket GameObject
		GameObject tBasketGo = basketList[basketIndex];
		//Remove the basket from the List and destroy the GameObject
		basketList.RemoveAt(basketIndex);
		Destroy (tBasketGo);

		//Restart the game
		if (basketList.Count == 0) {
			SceneManager.LoadScene ("_Scene_0");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
