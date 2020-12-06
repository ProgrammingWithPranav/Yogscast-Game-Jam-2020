using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AnimationThingy : MonoBehaviour
{
    public int number;
    public int sceneNumber;
    void Start()
    {
        StartCoroutine("WaitThing");
    }

    void Update()
    {
        
    }

    IEnumerator WaitThing()
	{
        yield return new WaitForSeconds(number);
        SceneManager.LoadScene(sceneNumber);
	}
}
