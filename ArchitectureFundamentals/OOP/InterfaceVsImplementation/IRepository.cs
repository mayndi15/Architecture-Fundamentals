namespace Architecture_Fundamentals.OOP.InterfaceVsImplementation;

public interface IRepository
{
    void Add();
}

public class Repository : IRepository
{
    public void Add()
    {
        throw new NotImplementedException();
    }
}

public class RepositoryFake : IRepository
{
    public void Add()
    {
        throw new NotImplementedException();
    }
}

public class Implementation
{
    public void Process()
    {
        var repository = new Repository();
        repository.Add();
    }
}

public class Abstraction
{
    private readonly IRepository _repository;

    public Abstraction(IRepository repository)
    {
        _repository = repository;
    }

    public void Process()
    {
        _repository.Add();
    }
}

public class TestInterface
{
    public TestInterface()
    {
        var repoImp = new Implementation();
        repoImp.Process();

        var repoAbs = new Abstraction(new Repository());
        repoAbs.Process();

        var repoAbsFake = new Abstraction(new RepositoryFake());
        repoAbsFake.Process();
    }
}