using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private bool _isCounterWork = false;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private int _CounterStartValue = 0;

    private void Start()
    {
        StartCoroutine(CountUp(_delay, _CounterStartValue));
    }

    private IEnumerator CountUp(float delay, int start)
    {
        bool isCounterEnable = true;
        var wait = new WaitForSeconds(delay);

        while (isCounterEnable)
        {
            if (_isCounterWork)
            {
                Debug.Log(start++);
            }

            yield return wait;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isCounterWork = !_isCounterWork;
        }
    }
}
