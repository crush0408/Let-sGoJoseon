using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wang2 : MonoBehaviour
{
    public List<string> s = new List<string>();
    private TalkManager talkManager;
    void Start()
    {
        talkManager = FindObjectOfType<TalkManager>();
        s[0] = "조사 다녀 왔습니다 전하 - 내관";
        s[1] = "그래 수고했다. 백성의 생각은 어떠해 보이더냐? - 정조" ;
        s[2] = "저잣거리에서 이 근방에서 가장 나이가 많은 할아버지를 만났습니다 - 내관" ;
        s[3] = "가장 나이가 많은 할아버지라니 꽤 운이 좋았구나 - 정조";
        s[4] = "맞습니다. 하지만 놀란 건 따로 있습니다 - 내관";
        s[5] = "더 놀라운 것 이라니, 그게 무엇이냐 - 정조";
        s[6] = "지금 백성들은 너무도 순수한 마음으로 전하의 정책을 기다리고 있습니다. - 내관";
        s[7] = "또한 일편단심의 마음으로 전하를 신뢰하고 있습니다. - 내관";
        s[8] = "하하하 내가 참 유복하구나 - 정조";
        s[9] = "근래에 쌓였던 답답함이 한번에 내려가는 것 같구나 - 정조";
        s[10] = "나를 신뢰하는 백성들에게 실망을 안겨주지는 않겠다 - 정조";
        s[11] = "좋다. 수원화성을 짓겠다. - 정조";
        s[12] = "정약용에게 수원화성 건축을 맡겨라 - 정조";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Debug.Log("input data");
            for(int i = 0;i <= s.Count;i ++){
                talkManager.textString[i] = s[i];
                talkManager.maxKey = s.Count;
                
            }

        }
    }
}
