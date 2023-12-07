using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class LoadData : MonoBehaviour
{
    public Text lastName;
    public Text currName;
    private string lastfarmer;
    private string currFarmer;
    // Start is called before the first frame update
    private void Awake()
    {
        currFarmer = NameHandler.Instance.GetCurrName();   
    }
    void Start()
    {
        SetCurrName();
        lastfarmer = NameHandler.Instance.LoadPreviousName();
        if(lastfarmer!=null)
        {
            SetLoadedName();
        }
        NameHandler.Instance.SaveCurrName();
    }
    void SetCurrName()
    {
        string temp = "Current Owner : " + currFarmer;
        currName.text = temp;

    }
    void SetLoadedName()
    {
       lastName.text = "Last Owner : " + lastfarmer;
    }
    // Update is called once per frame
    
}
