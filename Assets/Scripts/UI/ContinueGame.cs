﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour
{
    public void OnClickContinue()
    {
        GameManager.Instance.OnContinueButtonClickedInMenu();
    }
}
