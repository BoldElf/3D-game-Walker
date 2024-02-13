using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActive : MonoBehaviour
{
    [SerializeField] private ZombieController zombieController;

    [SerializeField] private GameObject panelPrefab;

    private GameObject panel;

    private void Start()
    {
        zombieController.onPanelSkrim += SkrimPanelOn;
    }

    private void SkrimPanelOn()
    {
        panel = Instantiate(panelPrefab,gameObject.transform);
        Destroy(panel, 0.5f);
    }
}
