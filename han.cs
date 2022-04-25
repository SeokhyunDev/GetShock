using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class han : MonoBehaviour
{
    public List<string> dialog = new List<string>();
    public Text txt = null;


    private void Start()
    {
        Debug.Log(dialog.Count);
        Debug.Log(dialog[0].Length);

        StartCoroutine(Test());
    }

    private IEnumerator Test()
    {
        for (int i = 0; i < dialog.Count; i++)
        {
            for (int j = 0; j < dialog[i].Length; ++j)
            {
                Debug.Log("ASd");
                txt.text += dialog[i][j];
                yield return new WaitForSeconds(0.125f);
            }

            yield return new WaitForSeconds(1.0f);
            txt.text = "";
        }
    }
}