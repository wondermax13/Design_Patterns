using System;

class PhoneDisplay : IObserver
{
    WeatherStation weatherStation_;

	public PhoneDisplay(WeatherStation weatherStation){

        this.weatherStation_ = weatherStation;
	}

    public void update()
    {
        this.weatherStation_.getTemperature();
    }
}
