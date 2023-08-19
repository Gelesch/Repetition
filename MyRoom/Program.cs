// See https://aka.ms/new-console-template for more information

MobilePhone mobilePhone = new MobilePhone("Samsung", true);
LightBbulb lightBbulb = new LightBbulb("cold");
Lamp lamp = new Lamp("Bra", true, lightBbulb);
Mouse mouse = new Mouse("Logitech", false);
Laptop laptop = new Laptop(mouse,"Asus","Black");
MyRomm myRomm = new MyRomm(laptop,lamp,mobilePhone);




public class MyRomm
{
    public MyRomm(Laptop laptop, Lamp lamp, MobilePhone mobilePhone)
    {
        Laptop = laptop;
        Lamp = lamp;
        MobilePhone = mobilePhone;
    }

    private Laptop Laptop;
    private Lamp Lamp;
    private MobilePhone MobilePhone;
}

public class Laptop
{
    public Laptop(Mouse mouse, string model, string color)
    {
        Mouse = mouse;
        Model = model;
        Color = color;
    }

    private Mouse Mouse;
    public string Model;
    public string Color;

}

public class Mouse
{
    public Mouse(string model, bool isEnabled)
    {
        Model = model;
        IsEnabled = isEnabled;
    }

    public string Model;
    public bool IsEnabled;
    
    public void IsSwitchOn()
    {
        IsEnabled = true;
    }

    public void IsSwitchOff()
    {
        IsEnabled = false;
    }

}

public class Lamp
{
    public Lamp(string model, bool isEnabled, LightBbulb lightBbulb)
    {
        Model = model;
        IsEnabled = isEnabled;
        LightBbulb = lightBbulb;
    }

    public string Model;
    public bool IsEnabled = true;
    private LightBbulb LightBbulb;
    
    public void IsSwitchOn()
    {
        IsEnabled = true;
    }

    public void IsSwitchOff()
    {
        IsEnabled = false;
    }
    
}

public class LightBbulb
{
    public string Light;

    public LightBbulb(string light)
    {
        Light = light;
    }
}

public class MobilePhone
{
    public MobilePhone(string model, bool isEnabled)
    {
        Model = model;
        IsEnabled = isEnabled;
    }

    public string Model;
    public bool IsEnabled = true;
    
    public void IsSwitchOn()
    {
        IsEnabled = true;
    }

    public void IsSwitchOff()
    {
        IsEnabled = false;
    }
    
}

