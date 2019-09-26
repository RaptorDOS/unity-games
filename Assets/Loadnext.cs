using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadnext : MonoBehaviour
{
    public void LoadNextLevel()
	{ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }//Will load the next scene in the Index queue
}
