namespace BO;

[Serializable]
public class BlNotEnugh : Exception
{
    public BlNotEnugh(String exception) : base(exception)
    {
    }

    public BlNotEnugh(String exception, Exception innerException) : base(exception, innerException)
    {
    }
}
public class BlIdNotExist : Exception
{
    public BlIdNotExist(String exception) : base(exception)
    {
    }

    public BlIdNotExist(String exception, Exception innerException) : base(exception, innerException)
    {
    }
}

[Serializable]
public class BlIBlreadyExist : Exception
{
    public BlIBlreadyExist(String exception) : base(exception)
    {
    }

    public BlIBlreadyExist(String exception, Exception innerException) : base(exception, innerException)
    {
    }
}

[Serializable]
public class BlIsNotOption : Exception
{
    public BlIsNotOption(String exception) : base(exception)
    {
    }

    public BlIsNotOption(String exception, Exception innerException): base(exception, innerException) { }
}


