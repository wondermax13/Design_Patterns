using System;

interface IObservable
{
    void add(IObserver);
    void remove(IObserver);
    void notify(IObserver);
}
