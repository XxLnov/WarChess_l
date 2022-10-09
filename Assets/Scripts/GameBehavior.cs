using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
	public string labelText = "Collect all 1 items and win yourfreedom!";
	public int maxItems = 4;
	private int _itemsCollected = 0;
	private int _playerHP = 10;
	public GameObject Menu;
	public int Items
	{
	// 2
	get { return _itemsCollected; }
	// 3
	set {
		_itemsCollected = value;
		Debug.LogFormat("Items: {0}", _itemsCollected);
		labelText = "Item found, only " +
		(maxItems - _itemsCollected) + " more to go!";
		}
	}

	public int HP
	{
	get { return _playerHP; }
	set {
		_playerHP = value;
		Debug.LogFormat("Lives: {0}", _playerHP);
		}
		}
	void OnGUI()
	{
		// 4
		GUI.Box(new Rect(20, 20, 150, 25),
		"Player Health:" + _playerHP);
		// 5
		GUI.Box(new Rect(20, 50, 150, 25),
		"Door Collected: " + _itemsCollected);
		// 6
		GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50,
		300, 50), labelText);

		if(GUI.Button(new Rect(Screen.width - 100, 50, 50, 50), "Menu")){
			
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			//G= GameObject.Find("MEnu");
			Menu.SetActive(!Menu.activeSelf);
			//Debug.Log(G);
		}

	}
	public void Exit()
	{
		Debug.Log("Exit");
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
	public void Play()
	{
		Debug.Log("Play");
		Menu.SetActive(!Menu.activeSelf);
	}
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}