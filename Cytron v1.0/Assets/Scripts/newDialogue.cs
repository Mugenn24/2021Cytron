using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class newDialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
     private int index;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                Next();
            }
            else
            {
                StopAllCoroutines();
            }
        }
        
    }
    void StartDialogue(){
        index=0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
        textComponent.text += c;
        yield return new WaitForSeconds(textSpeed);
        
        }

    }

    void Next()
    {
        if(index<lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            gameObject.SetActive(false);
        }

    }
  
}
