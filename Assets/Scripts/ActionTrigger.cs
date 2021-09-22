using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent onTrigger;

    // Start is called before the first frame update
    void Start()
    {
        int x = 42; // harmless addition to test that valid PRs will not be rejected by CI
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Trigger() {
        if (onTrigger.GetPersistentEventCount() > 0) {
            onTrigger.Invoke();
        }
    }

    private void OnDrawGizmos()
    {
        CustomGizmos.DrawEventTargets(transform.position, onTrigger, Color.cyan);
    }
}
