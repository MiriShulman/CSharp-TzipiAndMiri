using BlImplementation;

namespace BlApi;

public class Factory
{
    public static IBL Get{
        get { return new Bl(); }
    }
}
