using BllImplementation;

namespace BlApi;

public class Factory
{
    public static IBL Get{
        get { return new Bl(); }
    }
}
