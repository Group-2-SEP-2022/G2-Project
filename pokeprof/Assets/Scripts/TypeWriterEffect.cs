using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.05f;
    public string fullText;
    private string currentText = "";

    public bool stop = false;

    void Write()
    {
            StartCoroutine(ShowText());
    }

    void Update() {
        if(!stop) {
        if(this.GetComponent<Text>().color.a == 1f) {
            Write();
            stop = true;
        }
        }
        
    }

    IEnumerator ShowText(){
        for(int i = 0; i < fullText.Length + 1; i++) {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
        
    }
}
