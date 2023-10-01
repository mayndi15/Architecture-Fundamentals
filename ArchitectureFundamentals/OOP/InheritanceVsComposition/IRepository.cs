using Architecture_Fundamentals.OOP.StateVsBehavior;

namespace Architecture_Fundamentals.OOP.InheritanceVsComposition;

public interface IRepository<T>
{
    void Add(T obj);
    void Delete(T obj);
}

public interface IRepositoryPerson
{
    void Add(Person person);
}

public class Repository<T> : IRepository<T>
{
    public void Add(T obj)
    {
        throw new NotImplementedException();
    }

    public void Delete(T obj)
    {
        throw new NotImplementedException();
    }
}

public class RepositoryInheritancePerson : Repository<Person>, IRepositoryPerson
{
}

public class RepositoryCompositionPerson : IRepositoryPerson
{
    private readonly IRepository<Person> _repositoryPerson;

    public RepositoryCompositionPerson(IRepository<Person> repositoryPerson)
    {
        _repositoryPerson = repositoryPerson;
    }

    public void Add(Person person)
    {
        _repositoryPerson.Add(person);
    }
}

public class TestTwo
{
    public TestTwo()
    {
        var repoInheritance = new RepositoryInheritancePerson();
        repoInheritance.Add(new Person());
        repoInheritance.Delete(new Person());

        var repoComposition = new RepositoryCompositionPerson(new Repository<Person>());
        repoComposition.Add(new Person());
    }
}