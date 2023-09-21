using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public string WaitingScene; // ���ȭ�� ��
    public string DepositScene; // ���� ����, ��ȸ ������
    public float delayTime = 5.0f; // ���� �ð� (��) ����
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickWithdraw() // ���� ���� ��ư Ŭ��
    {
        StartCoroutine(moneyWithdraw());
    }

    private IEnumerator moneyWithdraw()
    {
        SceneManager.LoadScene(WaitingScene);
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(DepositScene);

    }


    public void ClickDeposit() // ���� �Ա� ��ư Ŭ��
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
