using System;

class WeatherStation : IObservable
{
    List<IObserver> observers;

	public void add(IObserver observer)
	{
        this.observers.Add(observer);
	}

    public void remove(IObserver observer)
    {
        this.observers.Remove(observer);
    }

    public void notify() {

        foreach(IObserver observer : observers) {

            observer.update();
        }
    }
}
