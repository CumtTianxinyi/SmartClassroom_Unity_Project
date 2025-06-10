using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;

public class begin : MonoBehaviour
{
    public GameObject textaaa;
    public int aaaaa;
    public void play()
    {
        SceneManager.LoadScene("all_objects");
    }
    public void quit()
    {
        Application.Quit();
    }
    private void Awake()
    {
        StartCoroutine(aaaa());
    }
    private void Update()
    {
        textaaa.GetComponent<UnityEngine.UI.Text>().text = aaaaa.ToString();
    }
    IEnumerator aaaa()
    {
        while(true)
        {
            aaaaa++;
            yield return new WaitForSeconds(1);
        }
    }
}