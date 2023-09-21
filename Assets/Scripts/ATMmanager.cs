using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ATMmanager : MonoBehaviour
{
    public Text balanceText;
    public Text cashText;
    public InputField depositInput;
    public InputField withdrawInput;

    private int balance = 50000;
    private int cash = 100000;

    [SerializeField] private GameObject NotEnoughMoneyPopUp;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        UpdateBalance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateBalance() //�ܾ� ������Ʈ
    {
        balanceText.text = "�ܾ�: $" + balance.ToString("F2");
        cashText.text = "���� \n" + cash.ToString("N0"); // ���� ǥ��
        withdrawInput.text = ""; // ��� �Է� �ʵ� �ʱ�ȭ
        depositInput.text = "";
    }

    public void DepositAmount(int amount)
    {
        if (amount >= 0)
        {
            if (cash >= amount)
            {
                cash -= amount;
                balance += amount;
                UpdateBalance();
            }
            else
            {
                NotEnoughMoneyPopUp.SetActive(true);
            }
        }

    }

    public void WithdrawAmount(int amount)
    {
        if (amount >= 0)
        {
            if (balance >= amount)
            {
                cash += amount;
                balance -= amount;
                UpdateBalance();
            }
            else
            {
                NotEnoughMoneyPopUp.SetActive(true);
            }
        }

    }

    public void OnclickedSendBtn()
    {
        int value = GetInputValue(withdrawInput);
        WithdrawAmount(value);

    }

    public void OnclickedOutBtn()
    {
        int value = GetInputValue(depositInput);
        DepositAmount(value);
    }

    private int GetInputValue(InputField inputField)
    {
        int inputValue = 0;
        if (int.TryParse(inputField.text, out inputValue))
        {
            return inputValue;
        }
        return 0;
    }
}
