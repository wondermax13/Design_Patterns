using System;

class Duck
{
    IFlyBehavior flyBehavior_;
    IQuackBehavior quackBehavior_;
    IDisplayBehavior displayBehavior_;

    public Duck(
        FlyBehavior flyBehavior,
        QuackBehavior quackBehavior,
        DisplayBehavior displayBehavior) {

        this.flyBehavior_ = flyBehavior;
        this.quackBehavior_ = quackBehavior;
        this.displayBehavior_ = displayBehavior;
    }
}
