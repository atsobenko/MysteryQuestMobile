﻿using Objects.ActiveObject;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private Animator animator;

    public GameObject button;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open(ActiveObject activeObject)
    {
        gameObject.SetActive(true);
        animator.Play("Open");
        CreateButtons(activeObject);
    }

    public void OpenEnded()
    {
        //Time.timeScale = 0;
    }

    public void Close()
    {
        if (!isActiveAndEnabled)
        {
            return;
        }

        animator.Play("Close");
    }

    public void CloseEnded()
    {
        gameObject.SetActive(false);
        DestroyButtons();
    }

    private void CreateButtons(ActiveObject activeObject)
    {
        var newButton = Instantiate(button, transform.position, Quaternion.identity);
        newButton.transform.SetParent(transform, false);
        newButton.GetComponent<Button>().onClick.AddListener(activeObject.Interact);
        newButton.GetComponentInChildren<Text>().text = "Use";
    }

    private void DestroyButtons()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
