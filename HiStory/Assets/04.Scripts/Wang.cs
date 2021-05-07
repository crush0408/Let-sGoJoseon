using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wang : MonoBehaviour
{
    public List<string> s = new List<string>();
    private TalkManager talkManager;
    void Start()
    {
        talkManager = FindObjectOfType<TalkManager>();
        s[0] = "전하 아침 문안 여쭈옵나이다 - 내관";
        s[1] = "그래, 오늘은 하늘이 높고 날씨도 선선하니 쾌청하구나 - 정조" ;
        s[2] = "이런 날씨에 우리 백성들은 무엇을 하고 있을지 .. - 정조" ;
        s[3] = " 분명 왕위에 오르며 백성과 소통하는 친근한 왕이 되겠다 마음먹었지만 - 정조";
        s[4] = " 막상 왕이 되고 나니 왕궁 밖의 일은 너무도 멀게만 느껴지는 게 그저 아쉬울 뿐이다 - 정조";
        s[5] = "아닙니다 전하, 항상 백성 생각에 잠 못 이루시면서 어찌 그런 말씀을 하십니까 - 내관";
        s[6] = "실 어제도 수원화성 건축에 있어서 고민에 있어 잠자리가 편치 못하였다. - 정조";
        s[7] = "수원화성 정책은 꿈의 도시를 만들겠다는 내 오랜 계획이었을 뿐더러 - 정조";
        s[8] = "지금 한양이 노론세력이 너무 강하니 약해진 왕권을 강화할 수 있는 정책이다 - 정조";
        s[9] = "만약 잘 지어지기만 한다면 백성을 가까이서 만나 돌보고  - 정조";
        s[10] = "군사훈련도 하며 혹시 생길 반란에도 대비할 수 있게 될 것이다. - 정조";
        s[11] = "수원화성 건축 정책에 대해 백성들은 어떤 입장인지 궁금하기도 하구나 - 정조";
        s[12] = "전하 제가 출궁 하여 백성들의 생각을 수집해 오는 것은 어떻습니까? - 내관";
        s[13] = "그래 좋은 생각이다. 그리 하겠느냐? - 정조";
        s[14] = "내 전하. 백성들의 생각을 듣고 늦지 않게 돌아오겠습니다. - 내관";
        s[15] = "그래 조심히 다녀오거라 , 여봐라! 내관의 출궁 준비를 도와주어라 - 정조";
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
