// IObservable Interface
using System;

public interface IObservable<T>
{
    void Attach(IObserver<T> observer);
    void Detach(IObserver<T> observer);
    void NotifyObservers();
}
