using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public Car()
    {
        

    }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public string IsDrivable { get; set; }


    public string MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        if (engineNoise != null && engineNoise == "yes")
        {
            return "There is an engine noise.";
        }
        else
        {
            return "There is no engine noise.";
        }

    }

    public string MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        if (honkNoise != null && honkNoise == "yes")
        {
            return "There is a honking noise.";
        }
        else
        {
            return "There is no honking noise.";
        }



    }

    public string CarIsDriveable(string isDriveable)
    {
        IsDrivable = isDriveable;
        if (isDriveable != null && isDriveable == "yes")
        {
            return "The car is driveable.";
        }
        else
        {
            return "The car is not driveable.";
        }






    }



}