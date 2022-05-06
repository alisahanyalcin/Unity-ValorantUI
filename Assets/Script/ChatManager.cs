using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    [SerializeField] private string chatMode = "Party";
    [SerializeField] private string userName = "alisahanyalcin";
    [SerializeField] private List<Message> messageList = new List<Message>();
    [SerializeField] private GameObject chatPanel, textObject, scrollView;
    [SerializeField] private TMP_InputField chatBox;
    [SerializeField] private int maxMessages = 25;

    private void Update()
    {
        if(chatBox.text != "")
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                SendMessageToChat(chatBox.text);
                chatBox.text = "";
            }
        }
        else switch (chatBox.isFocused)
        {
            case true when Input.GetKeyDown(KeyCode.Escape):
                HideChat(true);
                break;
            case false when (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)):
                chatBox.ActivateInputField();
                break;
        }
    }
    
    public void HideChat(bool hide)
    {
        scrollView.SetActive(!hide);
    }
    
    private void SendMessageToChat(string text)
    {
        if (messageList.Count > maxMessages)
        { 
            Destroy(messageList[0].textObject.gameObject); 
            messageList.Remove(messageList[0]); 
        }
        
        Message newMessage = new Message
        {
            message = text
        };

        GameObject newText = Instantiate(textObject, chatPanel.transform);
        newMessage.textObject = newText.GetComponent<TextMeshProUGUI>();
        newMessage.textObject.text = "<color=#A7D6EA>(" + chatMode + ") <color=#EFF3B6>" + userName + ": <color=#FFF>" + text;
        
        messageList.Add(newMessage);
    }
}

[System.Serializable]
public class Message
{
    public string message;
    public TextMeshProUGUI textObject;
}