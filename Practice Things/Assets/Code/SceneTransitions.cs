using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public Animator transition;
    public Animator secondtransition;

    public string sceneToLoad;

    public float transitionTime = 1f;

    // Start is called before the first frame update
    public void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void LoadLevel()
    {
        PlayButtonSound();
        StartCoroutine(LoadScene());
    }

    void PlayButtonSound()
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PlaySFX("ButtonSelect");
        }
    }

    IEnumerator LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            transition.SetTrigger("Start");
            secondtransition.SetTrigger("Start");

            yield return new WaitForSeconds(transitionTime);

            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
