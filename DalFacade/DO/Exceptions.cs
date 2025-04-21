namespace DO;

[Serializable]
public class DalIdNotExist : Exception
{
    public DalIdNotExist(String exception):base(exception)
    {
    }
}

[Serializable]
public class DalIdAlreadyExist : Exception
{
    public DalIdAlreadyExist(String exception) : base(exception)
    {
    }
}

[Serializable]
public class DalIsNotOption : Exception
{
    public DalIsNotOption(String exception) : base(exception)
    {
    }
}
