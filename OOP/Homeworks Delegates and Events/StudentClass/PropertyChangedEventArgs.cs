namespace StudentClass
{
    using System;

    public class PropertyChangedEventArgs<T> : EventArgs
    {
        public PropertyChangedEventArgs(string name, T oldValue, T newValue)
        {
            this.NewValue = newValue;
            this.PropertyName = name;
            this.OldValue = oldValue;
        }

        public T OldValue { get; set; }

        public T NewValue { get; set; }

        public string PropertyName { get; set; }
    }
}
