using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.05f;
    public string fullText;
    private string currentText = "";

    private bool stop = false;

    void Write()
    {
        StartCoroutine(ShowText());
    }

    void Update()
    {
        if (!stop)
        {
            //check if the opacity is 1 to prevent from writing even if we don't see the dialogue text box
            if (this.GetComponent<Text>().color.a == 1f)
            {
                Write();
                stop = true;
            }
        }
    }

    //show the text letter by letter
    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length + 1; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
