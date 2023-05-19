using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneo : MonoBehaviour {

	public void StartMain() 
        {
        Debug.Log("버튼!!!!");
        SceneManager.LoadScene("alice");   
        }
		
	}
