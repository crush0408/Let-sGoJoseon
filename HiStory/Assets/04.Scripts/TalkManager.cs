using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    
    public Text talkTest;
    //public GameObject scanObj;
    public List<string> textString = new List<string>(3);
    public int key = 0;
    public int maxKey;
    public bool IsKing = false;
    public Image kingImage;
    public Image fourTimeImage;
    public Image panelImage;
    public Text whoText;
    //private string replaceSTR;
    void Awake()
    {
        panelImage.color = new Color(255,255,255,0);
        talkTest.text = string.Format(" ");
        whoText.text = string.Format(" ");
    }

    // Update is called once per frame
    void Update()
    {
        if(textString != null && Input.GetMouseButtonUp(1) && key < maxKey){
            panelImage.color = new Color(255,255,255,255);

            if(textString[key].Contains("정조"))
            {
                whoText.text = string.Format("정조요!");
                RemoveName(key, "- 정조");
                fourTimeImage.rectTransform.localScale = new Vector3(1f,1f,1f);
                kingImage.rectTransform.localScale = new Vector3(1.2f,1.2f,1.2f);
            }
            else if(textString[key].Contains("내관")){
                whoText.text = string.Format("내관이요!");
                RemoveName(key,"- 내관");
                kingImage.rectTransform.localScale = new Vector3(1f,1f,1f);
                fourTimeImage.rectTransform.localScale = new Vector3(1.2f,1.2f,1.2f);
            }
            talkTest.text = string.Format(" ");
            //whoText.text = string.Format("누구인가?");
            talkTest.text = textString[key];
            key++;
            Debug.Log(key);
            
            //kingImage.rectTransform.localScale = new Vector3(1f,1f,1f);
            //fourTimeImage.rectTransform.localScale = new Vector3(1f,1f,1f);

        }
    }
    void RemoveName(int key,string n){
        string sPath = textString[key];
        int iIndex = sPath.LastIndexOf(n);
        if (iIndex > -1)                
            sPath = sPath.Remove( iIndex );
        //Debug.Log( sPath );
        textString[key] = sPath;
    }
}
