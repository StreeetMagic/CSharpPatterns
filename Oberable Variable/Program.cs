using System;
using UnityEngine;

namespace Utilities
{
    public interface IObservable<T> 
    {
        public event Action<T> OnChanged;
        public T Value { get; set; }
    }

    [Serializable]
    public class ObservableVariable<T> : IObservable<T>
    {
        [SerializeField]  private T _value;
        
        public event Action<T> OnChanged;

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                OnChanged?.Invoke(value);
            }
        }

        public ObservableVariable() => 
            Value = default;

        public ObservableVariable(T defaultValue) => 
            Value = defaultValue;

        public override string ToString() => 
            Value.ToString();
    }
}