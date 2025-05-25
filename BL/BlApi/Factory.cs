using BllImplementation;

namespace BlApi;

public class Factory
{
  
    public static IBL Get()
    {
        return new Bl();
    }
}
