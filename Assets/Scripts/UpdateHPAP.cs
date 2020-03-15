using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHPAP : MonoBehaviour {

    public Text _text;
    private string AP;
    private string HP;

    private void Start()
    {
        _text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update () {
        AP = FindObjectOfType<PlayerMains>().Armor.ToString();
        HP = FindObjectOfType<PlayerMains>().Health.ToString();
        _text.text = AP+" AP"+"   "+HP+" HP";
    }
}
