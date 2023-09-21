using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public string WaitingScene; // 대기화면 씬
    public string DepositScene; // 예금 인출, 조회 페이지
    public float delayTime = 5.0f; // 일정 시간 (초) 설정
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickWithdraw() // 예금 인출 버튼 클릭
    {
        StartCoroutine(moneyWithdraw());
    }

    private IEnumerator moneyWithdraw()
    {
        SceneManager.LoadScene(WaitingScene);
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(DepositScene);

    }


    public void ClickDeposit() // 예금 입금 버튼 클릭
    {
        StartCoroutine(moneyDeposit());
    }

    private IEnumerator moneyDeposit()
    {
        SceneManager.LoadScene(WaitingScene);
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(DepositScene);

    }
}
