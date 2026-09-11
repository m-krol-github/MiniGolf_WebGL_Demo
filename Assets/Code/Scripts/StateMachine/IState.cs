using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState<T>
{
    void InitState(T manager);
    void UpdateState(T manager);
    void DeinitState(T manager);
}
