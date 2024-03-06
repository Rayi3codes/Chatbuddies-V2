using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownScript : MonoBehaviour
{
    [SerializeField] private TMP_Text Text;

    public void DropdownSample(int index)
    {
        switch (index) 
        {
            case 0: Text.text = "They are bring designed as we speak. We believe more avatars would come forth with every update! "; break;
            case 1: Text.text = "Of course you can! We plan to implement that once we fully grasp that technology."; break;
            case 2: Text.text = "That is more of a long term goal for us, The only way to find out is to stay posted;)"; break;
        }
    }
}
